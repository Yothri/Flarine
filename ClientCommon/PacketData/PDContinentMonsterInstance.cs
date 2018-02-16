using System;

namespace ClientCommon.PacketData
{
	public class PDContinentMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 10;
			}
		}

		public PDContinentMonsterInstance()
		{
		}
	}
}
