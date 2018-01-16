using System;

namespace WebCommon
{
	public class WPDLevelUpPackageEvent2Entry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.moneyType);
			writer.Write(this.amount);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.moneyType = reader.ReadInt32();
			this.amount = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
		}

		public WPDLevelUpPackageEvent2Entry()
		{
		}

		public int entryId;

		public int requiredHeroLevel;

		public int moneyType;

		public int amount;

		public int itemId;

		public int itemCount;
	}
}
