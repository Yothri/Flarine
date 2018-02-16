using System;
using System.Collections.Generic;
using Flarine.Database.Context;

namespace Flarine.Database
{
    public static class DatabaseService
    {
        public static DatabaseContext GetContext()
        {
            if(Engine == null)
                throw new InvalidOperationException("Database has not been configured yet!");

            var type = default(Type);
            var instance = default(DatabaseContext);

            if (Engines.TryGetValue(Engine, out type))
                instance = (DatabaseContext)Activator.CreateInstance(type);

            return instance;
        }

        public static void SetEngine(string engine)
        {
            if (Engine != null)
                throw new InvalidOperationException("Database has already been configured!");

            if(!Engines.ContainsKey(engine))
                throw new InvalidOperationException("Database Engine does not exist!");

            Engine = engine;
        }

        private static readonly Dictionary<string, Type> Engines = new Dictionary<string, Type>
        {
            { "MySql", typeof(MySQLContext) }
        };
        private static string Engine { get; set; }
    }
}