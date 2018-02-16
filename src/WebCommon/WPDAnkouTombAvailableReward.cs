using System;

namespace WebCommon
{
	public class WPDAnkouTombAvailableReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDAnkouTombAvailableReward()
		{
		}

		public int tradition;

		public int rewardNo;

		public int itemId;
	}
}
