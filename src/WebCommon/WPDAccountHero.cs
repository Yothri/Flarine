using System;

namespace WebCommon
{
	public class WPDAccountHero : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.accountId);
			writer.Write(this.heroId);
			writer.Write(this.faceId);
			writer.Write(this.name);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.achieveId);
			writer.Write(this.achieveTitleKey);
			writer.Write(this.achievePoint);
			writer.Write(this.fameId);
			writer.Write(this.fameTitleKey);
			writer.Write(this.famePoint);
			writer.Write(this.tradition);
			writer.Write(this.vipLevel);
			writer.Write(this.dia);
			writer.Write(this.totalPurchasedDia);
			writer.Write(this.ownDia);
			writer.Write(this.gold);
			writer.Write(this.ownGold);
			writer.Write(this.warehouseGold);
			writer.Write(this.warehouseOwnGold);
			writer.Write(this.inventorySlotCount);
			writer.Write(this.warehouseSlotCount);
			writer.Write(this.petEquipSlotCount);
			writer.Write(this.beadSocketCount);
			writer.Write(this.inventoryExtendLoginDuration);
			writer.Write(this.warehouseExtendLoginDuration);
			writer.Write(this.magicPowder);
			writer.Write(this.starEssense);
			writer.Write(this.heart);
			writer.Write(this.beadPowder);
			writer.Write(this.hp);
			writer.Write(this.mp);
			writer.Write(this.hpUpdateTime);
			writer.Write(this.mpUpdateTime);
			writer.Write(this.fp);
			writer.Write(this.strength);
			writer.Write(this.agility);
			writer.Write(this.intelligence);
			writer.Write(this.stamina);
			writer.Write(this.maxHp);
			writer.Write(this.maxMp);
			writer.Write(this.hpRecovery);
			writer.Write(this.mpRecovery);
			writer.Write(this.physicalOffense);
			writer.Write(this.magicalOffense);
			writer.Write(this.physicalDefense);
			writer.Write(this.magicalDefense);
			writer.Write(this.accuracy);
			writer.Write(this.dodge);
			writer.Write(this.critical);
			writer.Write(this.block);
			writer.Write(this.attackSpeed);
			writer.Write(this.moveSpeed);
			writer.Write(this.statStrength);
			writer.Write(this.statStamina);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statPoint);
			writer.Write(this.statAutoDistribution);
			writer.Write(this.lastCompletedMainChapterId);
			writer.Write(this.openedContinentId);
			writer.Write(this.monsterKillCount);
			writer.Write(this.bossMonsterKillCount);
			writer.Write(this.composeSuccessCount);
			writer.Write(this.transcendSuccessCount);
			writer.Write(this.difficulty1DungeonClearCount);
			writer.Write(this.difficulty2DungeonClearCount);
			writer.Write(this.difficulty3DungeonClearCount);
			writer.Write(this.hpPotionAutoRate);
			writer.Write(this.freeItemPickTime);
			writer.Write(this.freePetPickTime);
			writer.Write(this.pickPoint);
			writer.Write(this.receivedCheerCount);
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
			writer.Write(this.partyInviteRefused);
			writer.Write(this.whisperRefused);
			writer.Write(this.tradeRequestRefused);
			writer.Write(this.dualRequestRefused);
			writer.Write(this.pushEnabled);
			writer.Write(this.trainingTimePushEnabled);
			writer.Write(this.fieldOfHonorRankingChangePushEnabled);
			writer.Write(this.receiveMailPushEnabled);
			writer.Write(this.activatedAccountHeroPetId);
			writer.Write(this.fieldOfHonorRanking);
			writer.Write(this.currentFieldOfHonorSuccessiveVictories);
			writer.Write(this.bestFieldOfHonorSuccessiveVictories);
			writer.Write(this.fieldOfHonorRankingRewardTime);
			writer.Write(this.pkPoint);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.accountId = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.faceId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.achieveId = reader.ReadInt32();
			this.achieveTitleKey = reader.ReadString();
			this.achievePoint = reader.ReadInt32();
			this.fameId = reader.ReadInt32();
			this.fameTitleKey = reader.ReadString();
			this.famePoint = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.vipLevel = reader.ReadInt32();
			this.dia = reader.ReadInt32();
			this.totalPurchasedDia = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.gold = reader.ReadInt64();
			this.ownGold = reader.ReadInt64();
			this.warehouseGold = reader.ReadInt64();
			this.warehouseOwnGold = reader.ReadInt64();
			this.inventorySlotCount = reader.ReadInt32();
			this.warehouseSlotCount = reader.ReadInt32();
			this.petEquipSlotCount = reader.ReadInt32();
			this.beadSocketCount = reader.ReadInt32();
			this.inventoryExtendLoginDuration = reader.ReadInt32();
			this.warehouseExtendLoginDuration = reader.ReadInt32();
			this.magicPowder = reader.ReadInt64();
			this.starEssense = reader.ReadInt64();
			this.heart = reader.ReadInt64();
			this.beadPowder = reader.ReadInt64();
			this.hp = reader.ReadInt32();
			this.mp = reader.ReadInt32();
			this.hpUpdateTime = reader.ReadString();
			this.mpUpdateTime = reader.ReadString();
			this.fp = reader.ReadInt32();
			this.strength = reader.ReadInt32();
			this.agility = reader.ReadInt32();
			this.intelligence = reader.ReadInt32();
			this.stamina = reader.ReadInt32();
			this.maxHp = reader.ReadInt32();
			this.maxMp = reader.ReadInt32();
			this.hpRecovery = reader.ReadInt32();
			this.mpRecovery = reader.ReadInt32();
			this.physicalOffense = reader.ReadInt32();
			this.magicalOffense = reader.ReadInt32();
			this.physicalDefense = reader.ReadInt32();
			this.magicalDefense = reader.ReadInt32();
			this.accuracy = reader.ReadInt32();
			this.dodge = reader.ReadInt32();
			this.critical = reader.ReadInt32();
			this.block = reader.ReadInt32();
			this.attackSpeed = reader.ReadDouble();
			this.moveSpeed = reader.ReadDouble();
			this.statStrength = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statPoint = reader.ReadInt32();
			this.statAutoDistribution = reader.ReadBoolean();
			this.lastCompletedMainChapterId = reader.ReadInt32();
			this.openedContinentId = reader.ReadInt32();
			this.monsterKillCount = reader.ReadInt64();
			this.bossMonsterKillCount = reader.ReadInt32();
			this.composeSuccessCount = reader.ReadInt32();
			this.transcendSuccessCount = reader.ReadInt32();
			this.difficulty1DungeonClearCount = reader.ReadInt32();
			this.difficulty2DungeonClearCount = reader.ReadInt32();
			this.difficulty3DungeonClearCount = reader.ReadInt32();
			this.hpPotionAutoRate = reader.ReadInt32();
			this.freeItemPickTime = reader.ReadString();
			this.freePetPickTime = reader.ReadString();
			this.pickPoint = reader.ReadInt32();
			this.receivedCheerCount = reader.ReadInt32();
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
			this.partyInviteRefused = reader.ReadBoolean();
			this.whisperRefused = reader.ReadBoolean();
			this.tradeRequestRefused = reader.ReadBoolean();
			this.dualRequestRefused = reader.ReadBoolean();
			this.pushEnabled = reader.ReadBoolean();
			this.trainingTimePushEnabled = reader.ReadBoolean();
			this.fieldOfHonorRankingChangePushEnabled = reader.ReadBoolean();
			this.receiveMailPushEnabled = reader.ReadBoolean();
			this.activatedAccountHeroPetId = reader.ReadString();
			this.fieldOfHonorRanking = reader.ReadInt32();
			this.currentFieldOfHonorSuccessiveVictories = reader.ReadInt32();
			this.bestFieldOfHonorSuccessiveVictories = reader.ReadInt32();
			this.fieldOfHonorRankingRewardTime = reader.ReadString();
			this.pkPoint = reader.ReadInt32();
		}

		public WPDAccountHero()
		{
		}

		public int accountHeroId;

		public string accountId;

		public int heroId;

		public int faceId;

		public string name;

		public int level;

		public long exp;

		public int achieveId;

		public string achieveTitleKey;

		public int achievePoint;

		public int fameId;

		public string fameTitleKey;

		public int famePoint;

		public int tradition;

		public int vipLevel;

		public int dia;

		public int totalPurchasedDia;

		public int ownDia;

		public long gold;

		public long ownGold;

		public long warehouseGold;

		public long warehouseOwnGold;

		public int inventorySlotCount;

		public int warehouseSlotCount;

		public int petEquipSlotCount;

		public int beadSocketCount;

		public int inventoryExtendLoginDuration;

		public int warehouseExtendLoginDuration;

		public long magicPowder;

		public long starEssense;

		public long heart;

		public long beadPowder;

		public int hp;

		public int mp;

		public string hpUpdateTime;

		public string mpUpdateTime;

		public int fp;

		public int strength;

		public int agility;

		public int intelligence;

		public int stamina;

		public int maxHp;

		public int maxMp;

		public int hpRecovery;

		public int mpRecovery;

		public int physicalOffense;

		public int magicalOffense;

		public int physicalDefense;

		public int magicalDefense;

		public int accuracy;

		public int dodge;

		public int critical;

		public int block;

		public double attackSpeed;

		public double moveSpeed;

		public int statStrength;

		public int statStamina;

		public int statAgility;

		public int statIntelligence;

		public int statPoint;

		public bool statAutoDistribution;

		public int lastCompletedMainChapterId;

		public int openedContinentId;

		public long monsterKillCount;

		public int bossMonsterKillCount;

		public int composeSuccessCount;

		public int transcendSuccessCount;

		public int difficulty1DungeonClearCount;

		public int difficulty2DungeonClearCount;

		public int difficulty3DungeonClearCount;

		public int hpPotionAutoRate;

		public string freeItemPickTime;

		public string freePetPickTime;

		public int pickPoint;

		public int receivedCheerCount;

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

		public bool partyInviteRefused;

		public bool whisperRefused;

		public bool tradeRequestRefused;

		public bool dualRequestRefused;

		public bool pushEnabled;

		public bool trainingTimePushEnabled;

		public bool fieldOfHonorRankingChangePushEnabled;

		public bool receiveMailPushEnabled;

		public string activatedAccountHeroPetId;

		public int fieldOfHonorRanking;

		public int currentFieldOfHonorSuccessiveVictories;

		public int bestFieldOfHonorSuccessiveVictories;

		public string fieldOfHonorRankingRewardTime;

		public int pkPoint;
	}
}
