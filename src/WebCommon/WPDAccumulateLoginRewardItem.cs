using System;

namespace WebCommon
{
	public class WPDAccumulateLoginRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.loginCount);
			writer.Write(this.rewardNo);
			writer.Write(this.type);
			writer.Write(this.heroId);
			writer.Write(this.gearId);
			writer.Write(this.gearGrade);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.loginCount = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.gearGrade = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
		}

		public WPDAccumulateLoginRewardItem()
		{
		}

		public int loginCount;

		public int rewardNo;

		public int type;

		public int heroId;

		public int gearId;

		public int gearGrade;

		public int itemId;

		public int itemCount;
	}
}
