using System;

namespace WebCommon
{
	public class WPDTradeShipStep : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.stepId);
			writer.Write(this.requiredMonsterCount);
			writer.Write(this.obstacleId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.stepId = reader.ReadInt32();
			this.requiredMonsterCount = reader.ReadInt32();
			this.obstacleId = reader.ReadInt32();
		}

		public WPDTradeShipStep()
		{
		}

		public int stepId;

		public int requiredMonsterCount;

		public int obstacleId;
	}
}
