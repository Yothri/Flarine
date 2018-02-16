using System;

namespace WebCommon
{
	public class WPDVipLevelReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
			writer.Write(this.rewardNo);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.petId);
			writer.Write(this.petInstanceId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.petInstanceId = reader.ReadInt32();
		}

		public WPDVipLevelReward()
		{
		}

		public int vipLevel;

		public int rewardNo;

		public int type;

		public int itemId;

		public int count;

		public int petId;

		public int petInstanceId;
	}
}
