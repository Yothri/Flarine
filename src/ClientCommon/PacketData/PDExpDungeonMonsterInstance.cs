using System;

namespace ClientCommon.PacketData
{
	public class PDExpDungeonMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 30;
			}
		}

		public PDExpDungeonMonsterInstance()
		{
		}
	}
}
