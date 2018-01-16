using System;

namespace WebCommon
{
	public class WPDPickAvailableProductGear : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productNo);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.owned);
			writer.Write(this.identified);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.attrEnchantLevel);
			writer.Write(this.socketCount);
			writer.Write(this.strength);
			writer.Write(this.agility);
			writer.Write(this.intelligence);
			writer.Write(this.stamina);
			writer.Write(this.maxHp);
			writer.Write(this.maxMp);
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
			writer.Write(this.opt_strength);
			writer.Write(this.opt_agility);
			writer.Write(this.opt_intelligence);
			writer.Write(this.opt_stamina);
			writer.Write(this.opt_maxHp);
			writer.Write(this.opt_maxMp);
			writer.Write(this.opt_physicalOffense);
			writer.Write(this.opt_magicalOffense);
			writer.Write(this.opt_physicalDefense);
			writer.Write(this.opt_magicalDefense);
			writer.Write(this.opt_accuracy);
			writer.Write(this.opt_dodge);
			writer.Write(this.opt_critical);
			writer.Write(this.opt_block);
			writer.Write(this.opt_attackSpeed);
			writer.Write(this.opt_moveSpeed);
			writer.Write(this.opt_physicalOffenseAmp);
			writer.Write(this.opt_magicalOffenseAmp);
			writer.Write(this.opt_physicalDefenseAmp);
			writer.Write(this.opt_magicalDefenseAmp);
			writer.Write(this.opt_hpAmp);
			writer.Write(this.opt_mpAmp);
			writer.Write(this.opt_hpPerSecond);
			writer.Write(this.opt_mpPerSecond);
			writer.Write(this.opt_hpPerHit);
			writer.Write(this.opt_mpPerHit);
			writer.Write(this.opt_addDamage);
			writer.Write(this.opt_damageReduction);
			writer.Write(this.opt_damageReflex);
			writer.Write(this.opt_allStat);
			writer.Write(this.bless_strength);
			writer.Write(this.bless_agility);
			writer.Write(this.bless_intelligence);
			writer.Write(this.bless_stamina);
			writer.Write(this.bless_critical);
			writer.Write(this.equipRequirementIgnored);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productNo = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.identified = reader.ReadBoolean();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.attrEnchantLevel = reader.ReadInt32();
			this.socketCount = reader.ReadInt32();
			this.strength = reader.ReadInt32();
			this.agility = reader.ReadInt32();
			this.intelligence = reader.ReadInt32();
			this.stamina = reader.ReadInt32();
			this.maxHp = reader.ReadInt32();
			this.maxMp = reader.ReadInt32();
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
			this.physicalOffenseAmp = reader.ReadInt32();
			this.magicalOffenseAmp = reader.ReadInt32();
			this.physicalDefenseAmp = reader.ReadInt32();
			this.magicalDefenseAmp = reader.ReadInt32();
			this.hpAmp = reader.ReadInt32();
			this.opt_strength = reader.ReadInt32();
			this.opt_agility = reader.ReadInt32();
			this.opt_intelligence = reader.ReadInt32();
			this.opt_stamina = reader.ReadInt32();
			this.opt_maxHp = reader.ReadInt32();
			this.opt_maxMp = reader.ReadInt32();
			this.opt_physicalOffense = reader.ReadInt32();
			this.opt_magicalOffense = reader.ReadInt32();
			this.opt_physicalDefense = reader.ReadInt32();
			this.opt_magicalDefense = reader.ReadInt32();
			this.opt_accuracy = reader.ReadInt32();
			this.opt_dodge = reader.ReadInt32();
			this.opt_critical = reader.ReadInt32();
			this.opt_block = reader.ReadInt32();
			this.opt_attackSpeed = reader.ReadDouble();
			this.opt_moveSpeed = reader.ReadDouble();
			this.opt_physicalOffenseAmp = reader.ReadInt32();
			this.opt_magicalOffenseAmp = reader.ReadInt32();
			this.opt_physicalDefenseAmp = reader.ReadInt32();
			this.opt_magicalDefenseAmp = reader.ReadInt32();
			this.opt_hpAmp = reader.ReadInt32();
			this.opt_mpAmp = reader.ReadInt32();
			this.opt_hpPerSecond = reader.ReadInt32();
			this.opt_mpPerSecond = reader.ReadInt32();
			this.opt_hpPerHit = reader.ReadInt32();
			this.opt_mpPerHit = reader.ReadInt32();
			this.opt_addDamage = reader.ReadInt32();
			this.opt_damageReduction = reader.ReadInt32();
			this.opt_damageReflex = reader.ReadInt32();
			this.opt_allStat = reader.ReadInt32();
			this.bless_strength = reader.ReadInt32();
			this.bless_agility = reader.ReadInt32();
			this.bless_intelligence = reader.ReadInt32();
			this.bless_stamina = reader.ReadInt32();
			this.bless_critical = reader.ReadInt32();
			this.equipRequirementIgnored = reader.ReadBoolean();
		}

		public WPDPickAvailableProductGear()
		{
		}

		public int productNo;

		public int gearId;

		public int grade;

		public bool owned;

		public bool identified;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int attrEnchantLevel;

		public int socketCount;

		public int strength;

		public int agility;

		public int intelligence;

		public int stamina;

		public int maxHp;

		public int maxMp;

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

		public int physicalOffenseAmp;

		public int magicalOffenseAmp;

		public int physicalDefenseAmp;

		public int magicalDefenseAmp;

		public int hpAmp;

		public int opt_strength;

		public int opt_agility;

		public int opt_intelligence;

		public int opt_stamina;

		public int opt_maxHp;

		public int opt_maxMp;

		public int opt_physicalOffense;

		public int opt_magicalOffense;

		public int opt_physicalDefense;

		public int opt_magicalDefense;

		public int opt_accuracy;

		public int opt_dodge;

		public int opt_critical;

		public int opt_block;

		public double opt_attackSpeed;

		public double opt_moveSpeed;

		public int opt_physicalOffenseAmp;

		public int opt_magicalOffenseAmp;

		public int opt_physicalDefenseAmp;

		public int opt_magicalDefenseAmp;

		public int opt_hpAmp;

		public int opt_mpAmp;

		public int opt_hpPerSecond;

		public int opt_mpPerSecond;

		public int opt_hpPerHit;

		public int opt_mpPerHit;

		public int opt_addDamage;

		public int opt_damageReduction;

		public int opt_damageReflex;

		public int opt_allStat;

		public int bless_strength;

		public int bless_agility;

		public int bless_intelligence;

		public int bless_stamina;

		public int bless_critical;

		public bool equipRequirementIgnored;
	}
}
