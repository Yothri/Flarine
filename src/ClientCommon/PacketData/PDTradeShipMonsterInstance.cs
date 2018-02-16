using System;

namespace ClientCommon.PacketData
{
	public class PDTradeShipMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 70;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.stepId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.stepId = reader.ReadInt32();
		}

		public PDTradeShipMonsterInstance()
		{
		}

		public int stepId;
	}
}
