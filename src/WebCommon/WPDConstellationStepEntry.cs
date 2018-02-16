using System;

namespace WebCommon
{
	public class WPDConstellationStepEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
			writer.Write(this.entryId);
			writer.Write(this.starEssense);
			writer.Write(this.requiredGold);
			writer.Write(this.successRate);
			writer.Write(this.failPoint);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.starEssense = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.successRate = reader.ReadInt32();
			this.failPoint = reader.ReadInt32();
		}

		public WPDConstellationStepEntry()
		{
		}

		public int constellationId;

		public int step;

		public int cycle;

		public int entryId;

		public int starEssense;

		public int requiredGold;

		public int successRate;

		public int failPoint;
	}
}
