using System;

namespace WebCommon
{
	public class WPDFirstChargeEventReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.petId);
			writer.Write(this.petInstanceId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.petInstanceId = reader.ReadInt32();
		}

		public WPDFirstChargeEventReward()
		{
		}

		public int rewardNo;

		public int type;

		public int itemId;

		public int itemCount;

		public int petId;

		public int petInstanceId;
	}
}
