using System;

namespace ClientCommon.CommandBody
{
	public class LootingBattleSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isLootGearGrade1);
			writer.Write(this.isLootGearGrade2);
			writer.Write(this.isLootGearGrade3);
			writer.Write(this.isLootGearGrade4);
			writer.Write(this.isLootGearGrade5);
			writer.Write(this.isLootJewel);
			writer.Write(this.isLootPotion);
			writer.Write(this.isLootGold);
			writer.Write(this.isLootMonsterEssense);
			writer.Write(this.isLootEtc);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isLootGearGrade1 = reader.ReadBoolean();
			this.isLootGearGrade2 = reader.ReadBoolean();
			this.isLootGearGrade3 = reader.ReadBoolean();
			this.isLootGearGrade4 = reader.ReadBoolean();
			this.isLootGearGrade5 = reader.ReadBoolean();
			this.isLootJewel = reader.ReadBoolean();
			this.isLootPotion = reader.ReadBoolean();
			this.isLootGold = reader.ReadBoolean();
			this.isLootMonsterEssense = reader.ReadBoolean();
			this.isLootEtc = reader.ReadBoolean();
		}

		public LootingBattleSettingCommandBody()
		{
		}

		public bool isLootGearGrade1;

		public bool isLootGearGrade2;

		public bool isLootGearGrade3;

		public bool isLootGearGrade4;

		public bool isLootGearGrade5;

		public bool isLootJewel;

		public bool isLootPotion;

		public bool isLootGold;

		public bool isLootMonsterEssense;

		public bool isLootEtc;
	}
}
