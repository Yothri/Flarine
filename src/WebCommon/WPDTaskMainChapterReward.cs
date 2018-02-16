using System;

namespace WebCommon
{
	public class WPDTaskMainChapterReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.mainChapterId);
			writer.Write(this.exp);
			writer.Write(this.ownGold);
			writer.Write(this.ownDia);
			writer.Write(this.totalGoldPerCount);
			writer.Write(this.unOwnDiaPerCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.mainChapterId = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.totalGoldPerCount = reader.ReadInt32();
			this.unOwnDiaPerCount = reader.ReadInt32();
		}

		public WPDTaskMainChapterReward()
		{
		}

		public int entryId;

		public int mainChapterId;

		public int exp;

		public int ownGold;

		public int ownDia;

		public int totalGoldPerCount;

		public int unOwnDiaPerCount;
	}
}
