using System;

namespace ClientCommon.PacketData
{
	public class PDGuildDungeonMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 110;
			}
		}

		public PDGuildDungeonMonsterInstance()
		{
		}
	}
}
