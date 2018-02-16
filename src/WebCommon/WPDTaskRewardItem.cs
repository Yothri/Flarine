using System;

namespace WebCommon
{
	public class WPDTaskRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDTaskRewardItem()
		{
		}

		public int entryId;

		public int itemId;

		public int count;
	}
}
