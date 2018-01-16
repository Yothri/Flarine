using System;

namespace WebCommon
{
	public class WPDMainQuestReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.rewardId);
			writer.Write(this.itemType);
			writer.Write(this.gearId);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.gearInstanceId);
			writer.Write(this.petId);
			writer.Write(this.petInstanceId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.rewardId = reader.ReadInt32();
			this.itemType = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.gearInstanceId = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.petInstanceId = reader.ReadInt32();
		}

		public WPDMainQuestReward()
		{
		}

		public int mainQuestId;

		public int rewardId;

		public int itemType;

		public int gearId;

		public int itemId;

		public int count;

		public int gearInstanceId;

		public int petId;

		public int petInstanceId;
	}
}
