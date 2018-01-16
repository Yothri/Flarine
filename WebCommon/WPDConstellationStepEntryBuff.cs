using System;

namespace WebCommon
{
	public class WPDConstellationStepEntryBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
			writer.Write(this.entryId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDConstellationStepEntryBuff()
		{
		}

		public int constellationId;

		public int step;

		public int cycle;

		public int entryId;

		public int attrId;

		public double value;
	}
}
