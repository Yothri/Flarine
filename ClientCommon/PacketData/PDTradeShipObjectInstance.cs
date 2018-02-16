using System;

namespace ClientCommon.PacketData
{
	public class PDTradeShipObjectInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 71;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.objectId);
			writer.Write(this.stepId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.objectId = reader.ReadInt32();
			this.stepId = reader.ReadInt32();
		}

		public PDTradeShipObjectInstance()
		{
		}

		public int objectId;

		public int stepId;
	}
}
