using System;

namespace WebCommon
{
	public class WPDContinuationChargeEntryReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDContinuationChargeEntryReward()
		{
		}

		public int entryId;

		public int rewardNo;

		public int itemId;

		public int count;
	}
}
