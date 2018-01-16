using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroGearEx : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.owned);
			writer.Write(this.identified);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.strength);
			writer.Write(this.agility);
			writer.Write(this.intelligence);
			writer.Write(this.stamina);
			writer.Write(this.maxHP);
			writer.Write(this.maxMP);
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
			writer.Write(this.physicalOffenseAmp);
			writer.Write(this.magicalOffenseAmp);
			writer.Write(this.physicalDefenseAmp);
			writer.Write(this.magicalDefenseAmp);
			writer.Write(this.hpAmp);
			writer.Write(this.optStrength);
			writer.Write(this.optAgility);
			writer.Write(this.optIntelligence);
			writer.Write(this.optStamina);
			writer.Write(this.optMaxHP);
			writer.Write(this.optMaxMP);
			writer.Write(this.optPhysicalOffense);
			writer.Write(this.optMagicalOffense);
			writer.Write(this.optPhysicalDefense);
			writer.Write(this.optMagicalDefense);
			writer.Write(this.optAccuracy);
			writer.Write(this.optDodge);
			writer.Write(this.optCritical);
			writer.Write(this.optBlock);
			writer.Write(this.optAttackSpeed);
			writer.Write(this.optMoveSpeed);
			writer.Write(this.optPhysicalOffenseAmp);
			writer.Write(this.optMagicalOffenseAmp);
			writer.Write(this.optPhysicalDefenseAmp);
			writer.Write(this.optMagicalDefenseAmp);
			writer.Write(this.optHPAmp);
			writer.Write(this.optMPAmp);
			writer.Write(this.optHPPerSecond);
			writer.Write(this.optMPPerSecond);
			writer.Write(this.optHPPerHit);
			writer.Write(this.optMPPerHit);
			writer.Write(this.optAdditionalDamage);
			writer.Write(this.optDamageReduction);
			writer.Write(this.optDamageReflection);
			writer.Write(this.optAllStat);
			writer.Write(this.blessingStrength);
			writer.Write(this.blessingAgility);
			writer.Write(this.blessingIntelligence);
			writer.Write(this.blessingStamina);
			writer.Write(this.blessingCritical);
			writer.Write(this.skillDegree);
			writer.Write(this.equipRequirementIgnored);
			writer.Write(this.sockets);
			writer.Write(this.equippedGearSlotId);
			writer.Write(this.runes);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadGuid();
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.identified = reader.ReadBoolean();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.attrEnchantLevel = reader.ReadInt32();
			this.strength = reader.ReadInt32();
			this.agility = reader.ReadInt32();
			this.intelligence = reader.ReadInt32();
			this.stamina = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.maxMP = reader.ReadInt32();
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
			this.physicalOffenseAmp = reader.ReadInt32();
			this.magicalOffenseAmp = reader.ReadInt32();
			this.physicalDefenseAmp = reader.ReadInt32();
			this.magicalDefenseAmp = reader.ReadInt32();
			this.hpAmp = reader.ReadInt32();
			this.optStrength = reader.ReadInt32();
			this.optAgility = reader.ReadInt32();
			this.optIntelligence = reader.ReadInt32();
			this.optStamina = reader.ReadInt32();
			this.optMaxHP = reader.ReadInt32();
			this.optMaxMP = reader.ReadInt32();
			this.optPhysicalOffense = reader.ReadInt32();
			this.optMagicalOffense = reader.ReadInt32();
			this.optPhysicalDefense = reader.ReadInt32();
			this.optMagicalDefense = reader.ReadInt32();
			this.optAccuracy = reader.ReadInt32();
			this.optDodge = reader.ReadInt32();
			this.optCritical = reader.ReadInt32();
			this.optBlock = reader.ReadInt32();
			this.optAttackSpeed = reader.ReadSingle();
			this.optMoveSpeed = reader.ReadSingle();
			this.optPhysicalOffenseAmp = reader.ReadInt32();
			this.optMagicalOffenseAmp = reader.ReadInt32();
			this.optPhysicalDefenseAmp = reader.ReadInt32();
			this.optMagicalDefenseAmp = reader.ReadInt32();
			this.optHPAmp = reader.ReadInt32();
			this.optMPAmp = reader.ReadInt32();
			this.optHPPerSecond = reader.ReadInt32();
			this.optMPPerSecond = reader.ReadInt32();
			this.optHPPerHit = reader.ReadInt32();
			this.optMPPerHit = reader.ReadInt32();
			this.optAdditionalDamage = reader.ReadInt32();
			this.optDamageReduction = reader.ReadInt32();
			this.optDamageReflection = reader.ReadInt32();
			this.optAllStat = reader.ReadInt32();
			this.blessingStrength = reader.ReadInt32();
			this.blessingAgility = reader.ReadInt32();
			this.blessingIntelligence = reader.ReadInt32();
			this.blessingStamina = reader.ReadInt32();
			this.blessingCritical = reader.ReadInt32();
			this.skillDegree = reader.ReadInt32();
			this.equipRequirementIgnored = reader.ReadBoolean();
			this.sockets = reader.ReadPDPacketDatas<PDSocket>();
			this.equippedGearSlotId = reader.ReadInt32();
			this.runes = reader.ReadPDPacketDatas<PDAccountHeroGearRune>();
		}

		public PDAccountHeroGearEx()
		{
		}

		public Guid id;

		public int gearId;

		public int grade;

		public bool owned;

		public bool identified;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int attrEnchantLevel;

		public int strength;

		public int agility;

		public int intelligence;

		public int stamina;

		public int maxHP;

		public int maxMP;

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

		public int physicalOffenseAmp;

		public int magicalOffenseAmp;

		public int physicalDefenseAmp;

		public int magicalDefenseAmp;

		public int hpAmp;

		public int optStrength;

		public int optAgility;

		public int optIntelligence;

		public int optStamina;

		public int optMaxHP;

		public int optMaxMP;

		public int optPhysicalOffense;

		public int optMagicalOffense;

		public int optPhysicalDefense;

		public int optMagicalDefense;

		public int optAccuracy;

		public int optDodge;

		public int optCritical;

		public int optBlock;

		public float optAttackSpeed;

		public float optMoveSpeed;

		public int optPhysicalOffenseAmp;

		public int optMagicalOffenseAmp;

		public int optPhysicalDefenseAmp;

		public int optMagicalDefenseAmp;

		public int optHPAmp;

		public int optMPAmp;

		public int optHPPerSecond;

		public int optMPPerSecond;

		public int optHPPerHit;

		public int optMPPerHit;

		public int optAdditionalDamage;

		public int optDamageReduction;

		public int optDamageReflection;

		public int optAllStat;

		public int blessingStrength;

		public int blessingAgility;

		public int blessingIntelligence;

		public int blessingStamina;

		public int blessingCritical;

		public int skillDegree;

		public bool equipRequirementIgnored;

		public PDSocket[] sockets;

		public int equippedGearSlotId;

		public PDAccountHeroGearRune[] runes;
	}
}
