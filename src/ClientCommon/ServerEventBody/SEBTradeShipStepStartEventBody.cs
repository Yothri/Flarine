using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeShipStepStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.stepId);
			writer.Write(this.objectId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.stepId = reader.ReadInt32();
			this.objectId = reader.ReadInt32();
		}

		public SEBTradeShipStepStartEventBody()
		{
		}

		public int stepId;

		public int objectId;
	}
}
