using System;

namespace ClientCommon.PacketData
{
	public class PDGuildDungeonSummonMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 111;
			}
		}

		public PDGuildDungeonSummonMonsterInstance()
		{
		}
	}
}
