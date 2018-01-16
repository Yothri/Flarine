using System;

namespace WebCommon
{
	public class WPDExpDungeonAvailableReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.expDungeonId);
			writer.Write(this.tradition);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.expDungeonId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDExpDungeonAvailableReward()
		{
		}

		public int expDungeonId;

		public int tradition;

		public int rewardNo;

		public int itemId;
	}
}
