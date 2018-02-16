using System;

namespace WebCommon
{
	public class WPDSuppressionQuestRoundReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardId);
			writer.Write(this.exp);
			writer.Write(this.ownDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardId = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
		}

		public WPDSuppressionQuestRoundReward()
		{
		}

		public int rewardId;

		public int exp;

		public int ownDia;
	}
}
