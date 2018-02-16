using System;
using System.IO;

namespace ClientCommon
{
	public abstract class Body
	{
		public virtual byte[] Serialize()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				PacketWriter writer = new PacketWriter(memoryStream);
				this.Serialize(writer);
				result = memoryStream.ToArray();
			}
			return result;
		}

		public virtual void Serialize(PacketWriter writer)
		{
		}

		public virtual long Deserialize(byte[] data)
		{
			long position;
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				PacketReader reader = new PacketReader(memoryStream);
				this.Deserialize(reader);
				position = memoryStream.Position;
			}
			return position;
		}

		public virtual void Deserialize(PacketReader reader)
		{
		}

		public virtual string Trace()
		{
			return base.GetType().Name;
		}

		public static byte[] SerializeRaw(Body body)
		{
			if (body != null)
			{
				return body.Serialize();
			}
			return null;
		}

		public static Body DeserializeRaw(byte[] rawBody, Type type, out long lnReadCount)
		{
			lnReadCount = 0L;
			Type typeFromHandle = typeof(Body);
			if (type != typeFromHandle && !type.IsSubclassOf(typeFromHandle))
			{
				throw new ArgumentException("type이 Body의 서브클래스가 아닙니다.");
			}
			if (rawBody == null)
			{
				return null;
			}
			Body body = (Body)Activator.CreateInstance(type);
			lnReadCount = body.Deserialize(rawBody);
			return body;
		}

		public static T DeserializeRaw<T>(byte[] rawBody, out long lnReadCount) where T : Body
		{
			return (T)((object)Body.DeserializeRaw(rawBody, typeof(T), out lnReadCount));
		}

		public static T DeserializeRaw<T>(byte[] rawBody) where T : Body
		{
			long num;
			return Body.DeserializeRaw<T>(rawBody, out num);
		}

		protected Body()
		{
		}
	}
}
