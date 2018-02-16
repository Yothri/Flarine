using System;

namespace ClientCommon.PacketData
{
	public class PDStoryDungeonClearRewardPickEntry : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.type);
			writer.Write(this.rewardGear);
			writer.Write(this.itemId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.rewardGear = reader.ReadPDPacketData<PDPickEntryGear>();
			this.itemId = reader.ReadInt32();
		}

		public PDStoryDungeonClearRewardPickEntry()
		{
		}

		public int id;

		public int type;

		public PDPickEntryGear rewardGear;

		public int itemId;
	}
}
