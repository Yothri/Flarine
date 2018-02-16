using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class CompleteMainQuestResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.rewardGears);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.mountTier);
			writer.Write(this.mountTierExp);
			writer.Write(this.mountLevel);
			writer.Write(this.mountLevelExp);
			writer.Write(this.rewardPet);
			writer.Write(this.nextMainQuest);
			writer.Write(this.date);
			writer.Write(this.dailyQuest);
			writer.Write(this.suppressionQuest);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.rewardGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.mountTier = reader.ReadInt32();
			this.mountTierExp = reader.ReadInt32();
			this.mountLevel = reader.ReadInt32();
			this.mountLevelExp = reader.ReadInt32();
			this.rewardPet = reader.ReadPDPacketData<PDAccountHeroPetEx>();
			this.nextMainQuest = reader.ReadPDPacketData<PDMainQuest>();
			this.date = reader.ReadDateTime();
			this.dailyQuest = reader.ReadPDPacketData<PDAccountHeroDailyQuest>();
			this.suppressionQuest = reader.ReadPDPacketData<PDAccountHeroSuppressionQuest>();
		}

		public CompleteMainQuestResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public PDAccountHeroGearEx[] rewardGears;

		public PDInventorySlot[] changedInventorySlots;

		public int mountTier;

		public int mountTierExp;

		public int mountLevel;

		public int mountLevelExp;

		public PDAccountHeroPetEx rewardPet;

		public PDMainQuest nextMainQuest;

		public DateTime date;

		public PDAccountHeroDailyQuest dailyQuest;

		public PDAccountHeroSuppressionQuest suppressionQuest;
	}
}
