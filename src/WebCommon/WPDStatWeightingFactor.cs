using System;

namespace WebCommon
{
	public class WPDStatWeightingFactor : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.statId);
			writer.Write(this.heroId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.statId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDStatWeightingFactor()
		{
		}

		public int statId;

		public int heroId;

		public int attrId;

		public double value;
	}
}
