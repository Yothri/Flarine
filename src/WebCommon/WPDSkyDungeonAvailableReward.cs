using System;

namespace WebCommon
{
	public class WPDSkyDungeonAvailableReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDSkyDungeonAvailableReward()
		{
		}

		public int dungeonId;

		public int rewardNo;

		public int itemId;
	}
}
