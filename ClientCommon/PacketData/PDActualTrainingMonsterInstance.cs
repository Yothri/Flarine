using System;

namespace ClientCommon.PacketData
{
	public class PDActualTrainingMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 90;
			}
		}

		public PDActualTrainingMonsterInstance()
		{
		}
	}
}
