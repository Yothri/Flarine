using System;

namespace WebCommon
{
	public class WPDDay30Reward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.day);
			writer.Write(this.fixedItemId);
			writer.Write(this.fixedItemCount);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.day = reader.ReadInt32();
			this.fixedItemId = reader.ReadInt32();
			this.fixedItemCount = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
		}

		public WPDDay30Reward()
		{
		}

		public int day;

		public int fixedItemId;

		public int fixedItemCount;

		public int itemId;

		public int itemCount;
	}
}
