using System;

namespace ClientCommon.PacketData
{
	public class PDGoldDungeonMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 40;
			}
		}

		public PDGoldDungeonMonsterInstance()
		{
		}
	}
}
