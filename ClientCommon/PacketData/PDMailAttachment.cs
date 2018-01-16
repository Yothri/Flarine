using System;

namespace ClientCommon.PacketData
{
	public class PDMailAttachment : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attachmentNo);
			writer.Write(this.type);
			writer.Write(this.cm_itemId);
			writer.Write(this.cm_count);
			writer.Write(this.cm_owned);
			writer.Write(this.eq_gearId);
			writer.Write(this.eq_grade);
			writer.Write(this.eq_owned);
			writer.Write(this.eq_identified);
			writer.Write(this.eq_enchantLevel);
			writer.Write(this.eq_elemental);
			writer.Write(this.eq_elementalLevel);
			writer.Write(this.eq_socketCount);
			writer.Write(this.eq_strength);
			writer.Write(this.eq_agility);
			writer.Write(this.eq_intelligence);
			writer.Write(this.eq_stamina);
			writer.Write(this.eq_maxHp);
			writer.Write(this.eq_maxMp);
			writer.Write(this.eq_physicalOffense);
			writer.Write(this.eq_magicalOffense);
			writer.Write(this.eq_physicalDefense);
			writer.Write(this.eq_magicalDefense);
			writer.Write(this.eq_accuracy);
			writer.Write(this.eq_dodge);
			writer.Write(this.eq_critical);
			writer.Write(this.eq_block);
			writer.Write(this.eq_attackSpeed);
			writer.Write(this.eq_moveSpeed);
			writer.Write(this.eq_physicalOffenseAmp);
			writer.Write(this.eq_magicalOffenseAmp);
			writer.Write(this.eq_physicalDefenseAmp);
			writer.Write(this.eq_magicalDefenseAmp);
			writer.Write(this.eq_hpAmp);
			writer.Write(this.eq_opt_strength);
			writer.Write(this.eq_opt_agility);
			writer.Write(this.eq_opt_intelligence);
			writer.Write(this.eq_opt_stamina);
			writer.Write(this.eq_opt_maxHp);
			writer.Write(this.eq_opt_maxMp);
			writer.Write(this.eq_opt_physicalOffense);
			writer.Write(this.eq_opt_magicalOffense);
			writer.Write(this.eq_opt_physicalDefense);
			writer.Write(this.eq_opt_magicalDefense);
			writer.Write(this.eq_opt_accuracy);
			writer.Write(this.eq_opt_dodge);
			writer.Write(this.eq_opt_critical);
			writer.Write(this.eq_opt_block);
			writer.Write(this.eq_opt_attackSpeed);
			writer.Write(this.eq_opt_moveSpeed);
			writer.Write(this.eq_opt_physicalOffenseAmp);
			writer.Write(this.eq_opt_magicalOffenseAmp);
			writer.Write(this.eq_opt_physicalDefenseAmp);
			writer.Write(this.eq_opt_magicalDefenseAmp);
			writer.Write(this.eq_opt_hpAmp);
			writer.Write(this.eq_opt_mpAmp);
			writer.Write(this.eq_opt_hpPerSecond);
			writer.Write(this.eq_opt_mpPerSecond);
			writer.Write(this.eq_opt_hpPerHit);
			writer.Write(this.eq_opt_mpPerHit);
			writer.Write(this.eq_opt_addDamage);
			writer.Write(this.eq_opt_damageReduction);
			writer.Write(this.eq_opt_damageReflex);
			writer.Write(this.eq_opt_allStat);
			writer.Write(this.eq_bless_strength);
			writer.Write(this.eq_bless_agility);
			writer.Write(this.eq_bless_intelligence);
			writer.Write(this.eq_bless_stamina);
			writer.Write(this.eq_bless_critical);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attachmentNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.cm_itemId = reader.ReadInt32();
			this.cm_count = reader.ReadInt32();
			this.cm_owned = reader.ReadBoolean();
			this.eq_gearId = reader.ReadInt32();
			this.eq_grade = reader.ReadInt32();
			this.eq_owned = reader.ReadBoolean();
			this.eq_identified = reader.ReadBoolean();
			this.eq_enchantLevel = reader.ReadInt32();
			this.eq_elemental = reader.ReadInt32();
			this.eq_elementalLevel = reader.ReadInt32();
			this.eq_socketCount = reader.ReadInt32();
			this.eq_strength = reader.ReadInt32();
			this.eq_agility = reader.ReadInt32();
			this.eq_intelligence = reader.ReadInt32();
			this.eq_stamina = reader.ReadInt32();
			this.eq_maxHp = reader.ReadInt32();
			this.eq_maxMp = reader.ReadInt32();
			this.eq_physicalOffense = reader.ReadInt32();
			this.eq_magicalOffense = reader.ReadInt32();
			this.eq_physicalDefense = reader.ReadInt32();
			this.eq_magicalDefense = reader.ReadInt32();
			this.eq_accuracy = reader.ReadInt32();
			this.eq_dodge = reader.ReadInt32();
			this.eq_critical = reader.ReadInt32();
			this.eq_block = reader.ReadInt32();
			this.eq_attackSpeed = reader.ReadSingle();
			this.eq_moveSpeed = reader.ReadSingle();
			this.eq_physicalOffenseAmp = reader.ReadInt32();
			this.eq_magicalOffenseAmp = reader.ReadInt32();
			this.eq_physicalDefenseAmp = reader.ReadInt32();
			this.eq_magicalDefenseAmp = reader.ReadInt32();
			this.eq_hpAmp = reader.ReadInt32();
			this.eq_opt_strength = reader.ReadInt32();
			this.eq_opt_agility = reader.ReadInt32();
			this.eq_opt_intelligence = reader.ReadInt32();
			this.eq_opt_stamina = reader.ReadInt32();
			this.eq_opt_maxHp = reader.ReadInt32();
			this.eq_opt_maxMp = reader.ReadInt32();
			this.eq_opt_physicalOffense = reader.ReadInt32();
			this.eq_opt_magicalOffense = reader.ReadInt32();
			this.eq_opt_physicalDefense = reader.ReadInt32();
			this.eq_opt_magicalDefense = reader.ReadInt32();
			this.eq_opt_accuracy = reader.ReadInt32();
			this.eq_opt_dodge = reader.ReadInt32();
			this.eq_opt_critical = reader.ReadInt32();
			this.eq_opt_block = reader.ReadInt32();
			this.eq_opt_attackSpeed = reader.ReadSingle();
			this.eq_opt_moveSpeed = reader.ReadSingle();
			this.eq_opt_physicalOffenseAmp = reader.ReadInt32();
			this.eq_opt_magicalOffenseAmp = reader.ReadInt32();
			this.eq_opt_physicalDefenseAmp = reader.ReadInt32();
			this.eq_opt_magicalDefenseAmp = reader.ReadInt32();
			this.eq_opt_hpAmp = reader.ReadInt32();
			this.eq_opt_mpAmp = reader.ReadInt32();
			this.eq_opt_hpPerSecond = reader.ReadInt32();
			this.eq_opt_mpPerSecond = reader.ReadInt32();
			this.eq_opt_hpPerHit = reader.ReadInt32();
			this.eq_opt_mpPerHit = reader.ReadInt32();
			this.eq_opt_addDamage = reader.ReadInt32();
			this.eq_opt_damageReduction = reader.ReadInt32();
			this.eq_opt_damageReflex = reader.ReadInt32();
			this.eq_opt_allStat = reader.ReadInt32();
			this.eq_bless_strength = reader.ReadInt32();
			this.eq_bless_agility = reader.ReadInt32();
			this.eq_bless_intelligence = reader.ReadInt32();
			this.eq_bless_stamina = reader.ReadInt32();
			this.eq_bless_critical = reader.ReadInt32();
		}

		public PDMailAttachment()
		{
		}

		public int attachmentNo;

		public int type;

		public int cm_itemId;

		public int cm_count;

		public bool cm_owned;

		public int eq_gearId;

		public int eq_grade;

		public bool eq_owned;

		public bool eq_identified;

		public int eq_enchantLevel;

		public int eq_elemental;

		public int eq_elementalLevel;

		public int eq_socketCount;

		public int eq_strength;

		public int eq_agility;

		public int eq_intelligence;

		public int eq_stamina;

		public int eq_maxHp;

		public int eq_maxMp;

		public int eq_physicalOffense;

		public int eq_magicalOffense;

		public int eq_physicalDefense;

		public int eq_magicalDefense;

		public int eq_accuracy;

		public int eq_dodge;

		public int eq_critical;

		public int eq_block;

		public float eq_attackSpeed;

		public float eq_moveSpeed;

		public int eq_physicalOffenseAmp;

		public int eq_magicalOffenseAmp;

		public int eq_physicalDefenseAmp;

		public int eq_magicalDefenseAmp;

		public int eq_hpAmp;

		public int eq_opt_strength;

		public int eq_opt_agility;

		public int eq_opt_intelligence;

		public int eq_opt_stamina;

		public int eq_opt_maxHp;

		public int eq_opt_maxMp;

		public int eq_opt_physicalOffense;

		public int eq_opt_magicalOffense;

		public int eq_opt_physicalDefense;

		public int eq_opt_magicalDefense;

		public int eq_opt_accuracy;

		public int eq_opt_dodge;

		public int eq_opt_critical;

		public int eq_opt_block;

		public float eq_opt_attackSpeed;

		public float eq_opt_moveSpeed;

		public int eq_opt_physicalOffenseAmp;

		public int eq_opt_magicalOffenseAmp;

		public int eq_opt_physicalDefenseAmp;

		public int eq_opt_magicalDefenseAmp;

		public int eq_opt_hpAmp;

		public int eq_opt_mpAmp;

		public int eq_opt_hpPerSecond;

		public int eq_opt_mpPerSecond;

		public int eq_opt_hpPerHit;

		public int eq_opt_mpPerHit;

		public int eq_opt_addDamage;

		public int eq_opt_damageReduction;

		public int eq_opt_damageReflex;

		public int eq_opt_allStat;

		public int eq_bless_strength;

		public int eq_bless_agility;

		public int eq_bless_intelligence;

		public int eq_bless_stamina;

		public int eq_bless_critical;
	}
}
