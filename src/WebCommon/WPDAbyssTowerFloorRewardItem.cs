using System;

namespace WebCommon
{
	public class WPDAbyssTowerFloorRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDAbyssTowerFloorRewardItem()
		{
		}

		public int floor;

		public int type;

		public int itemId;

		public int count;
	}
}
