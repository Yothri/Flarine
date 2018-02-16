using System;

namespace WebCommon
{
	public class WPDTaskTraditionReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.tradition);
			writer.Write(this.exp);
			writer.Write(this.ownGold);
			writer.Write(this.ownDia);
			writer.Write(this.famePoint);
			writer.Write(this.achievePoint);
			writer.Write(this.beadPowder);
			writer.Write(this.magicPowder);
			writer.Write(this.starEssence);
			writer.Write(this.totalGoldPerCount);
			writer.Write(this.unOwnDiaPerCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.famePoint = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
			this.beadPowder = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.starEssence = reader.ReadInt32();
			this.totalGoldPerCount = reader.ReadInt32();
			this.unOwnDiaPerCount = reader.ReadInt32();
		}

		public WPDTaskTraditionReward()
		{
		}

		public int entryId;

		public int tradition;

		public int exp;

		public int ownGold;

		public int ownDia;

		public int famePoint;

		public int achievePoint;

		public int beadPowder;

		public int magicPowder;

		public int starEssence;

		public int totalGoldPerCount;

		public int unOwnDiaPerCount;
	}
}
