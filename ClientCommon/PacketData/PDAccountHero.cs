using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHero : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.isGM);
			writer.Write(this.heroId);
			writer.Write(this.faceId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.achieveId);
			writer.Write(this.achievePoint);
			writer.Write(this.achieveTitleKey);
			writer.Write(this.fameId);
			writer.Write(this.famePoint);
			writer.Write(this.fameTitleKey);
			writer.Write(this.ownDia);
			writer.Write(this.gold);
			writer.Write(this.owndGold);
			writer.Write(this.magicPowder);
			writer.Write(this.starEssense);
			writer.Write(this.heart);
			writer.Write(this.beadPowder);
			writer.Write(this.hp);
			writer.Write(this.mp);
			writer.Write(this.strength);
			writer.Write(this.agility);
			writer.Write(this.intelligence);
			writer.Write(this.stamina);
			writer.Write(this.maxHP);
			writer.Write(this.maxMP);
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
			writer.Write(this.statPoint);
			writer.Write(this.statAutoDistribution);
			writer.Write(this.statStrength);
			writer.Write(this.statStamina);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.realMaxHP);
			writer.Write(this.realMaxMP);
			writer.Write(this.battlePower);
			writer.Write(this.mountTier);
			writer.Write(this.isFlying);
			writer.Write(this.takingOffAndLanding);
			writer.Write(this.fp);
			writer.Write(this.participatePetId);
			writer.Write(this.isRiding);
			writer.Write(this.pkPoint);
			writer.Write(this.revivalInvincibilityRemainingTime);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.abnormalStateEffects);
			writer.Write(this.partyDungeonEnterNo);
			writer.Write(this.partyDungeonReady);
			writer.Write(this.gouthanMineMiningMineralInstId);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
			writer.Write(this.equippedGears);
			writer.Write(this.equippedGearExs);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.isGM = reader.ReadBoolean();
			this.heroId = reader.ReadInt32();
			this.faceId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.achieveId = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
			this.achieveTitleKey = reader.ReadString();
			this.fameId = reader.ReadInt32();
			this.famePoint = reader.ReadInt32();
			this.fameTitleKey = reader.ReadString();
			this.ownDia = reader.ReadInt32();
			this.gold = reader.ReadInt64();
			this.owndGold = reader.ReadInt64();
			this.magicPowder = reader.ReadInt64();
			this.starEssense = reader.ReadInt64();
			this.heart = reader.ReadInt64();
			this.beadPowder = reader.ReadInt64();
			this.hp = reader.ReadInt32();
			this.mp = reader.ReadInt32();
			this.strength = reader.ReadInt32();
			this.agility = reader.ReadInt32();
			this.intelligence = reader.ReadInt32();
			this.stamina = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.maxMP = reader.ReadInt32();
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
			this.attackSpeed = reader.ReadSingle();
			this.moveSpeed = reader.ReadSingle();
			this.statPoint = reader.ReadInt32();
			this.statAutoDistribution = reader.ReadBoolean();
			this.statStrength = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.realMaxHP = reader.ReadInt32();
			this.realMaxMP = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.mountTier = reader.ReadInt32();
			this.isFlying = reader.ReadBoolean();
			this.takingOffAndLanding = reader.ReadInt32();
			this.fp = reader.ReadInt32();
			this.participatePetId = reader.ReadInt32();
			this.isRiding = reader.ReadBoolean();
			this.pkPoint = reader.ReadInt32();
			this.revivalInvincibilityRemainingTime = reader.ReadSingle();
			this.guildId = reader.ReadNullableGuid();
			this.guildName = reader.ReadString();
			this.abnormalStateEffects = reader.ReadPDPacketDatas<PDAbnormalStateEffect>();
			this.partyDungeonEnterNo = reader.ReadInt32();
			this.partyDungeonReady = reader.ReadBoolean();
			this.gouthanMineMiningMineralInstId = reader.ReadInt64();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
			this.equippedGears = reader.ReadPDPacketDatas<PDAccountHeroGear>();
			this.equippedGearExs = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public PDAccountHero()
		{
		}

		public int accountHeroId;

		public string name;

		public bool isGM;

		public int heroId;

		public int faceId;

		public int tradition;

		public int level;

		public long exp;

		public int achieveId;

		public int achievePoint;

		public string achieveTitleKey;

		public int fameId;

		public int famePoint;

		public string fameTitleKey;

		public int ownDia;

		public long gold;

		public long owndGold;

		public long magicPowder;

		public long starEssense;

		public long heart;

		public long beadPowder;

		public int hp;

		public int mp;

		public int strength;

		public int agility;

		public int intelligence;

		public int stamina;

		public int maxHP;

		public int maxMP;

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

		public float attackSpeed;

		public float moveSpeed;

		public int statPoint;

		public bool statAutoDistribution;

		public int statStrength;

		public int statStamina;

		public int statAgility;

		public int statIntelligence;

		public int realMaxHP;

		public int realMaxMP;

		public int battlePower;

		public int mountTier;

		public bool isFlying;

		public int takingOffAndLanding;

		public int fp;

		public int participatePetId;

		public bool isRiding;

		public int pkPoint;

		public float revivalInvincibilityRemainingTime;

		public Guid? guildId;

		public string guildName;

		public PDAbnormalStateEffect[] abnormalStateEffects;

		public int partyDungeonEnterNo;

		public bool partyDungeonReady;

		public long gouthanMineMiningMineralInstId;

		public int costumeId;

		public bool costumeVisible;

		public PDAccountHeroGear[] equippedGears;

		public PDAccountHeroGearEx[] equippedGearExs;

		public PDVector3 position;

		public float rotationY;
	}
}
