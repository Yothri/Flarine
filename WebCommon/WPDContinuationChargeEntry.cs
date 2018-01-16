using System;

namespace WebCommon
{
	public class WPDContinuationChargeEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.dayCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.dayCount = reader.ReadInt32();
		}

		public WPDContinuationChargeEntry()
		{
		}

		public int entryId;

		public int dayCount;
	}
}
