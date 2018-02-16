using System;

namespace WebCommon
{
	public class WPDJobBattlefieldAvailableReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadDouble();
		}

		public WPDJobBattlefieldAvailableReward()
		{
		}

		public int rewardNo;

		public double itemId;
	}
}
