using System;

namespace WebCommon
{
	public class WPDMonster : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterId);
			writer.Write(this.level);
			writer.Write(this.scale);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.maxHp);
			writer.Write(this.hpRecovery);
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
			writer.Write(this.attackRange);
			writer.Write(this.hitRange);
			writer.Write(this.hpPerHit);
			writer.Write(this.addDamage);
			writer.Write(this.damageReduction);
			writer.Write(this.damageReflex);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.visibilityDistance);
			writer.Write(this.knockBackImmune);
			writer.Write(this.activityRange);
			writer.Write(this.monsterSkillId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.scale = reader.ReadDouble();
			this.monsterCharacterId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.maxHp = reader.ReadInt32();
			this.hpRecovery = reader.ReadInt32();
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
			this.attackRange = reader.ReadDouble();
			this.hitRange = reader.ReadDouble();
			this.hpPerHit = reader.ReadInt32();
			this.addDamage = reader.ReadInt32();
			this.damageReduction = reader.ReadInt32();
			this.damageReflex = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.visibilityDistance = reader.ReadDouble();
			this.knockBackImmune = reader.ReadBoolean();
			this.activityRange = reader.ReadDouble();
			this.monsterSkillId = reader.ReadInt32();
		}

		public WPDMonster()
		{
		}

		public int monsterId;

		public int level;

		public double scale;

		public int monsterCharacterId;

		public string name;

		public string nameKey;

		public int maxHp;

		public int hpRecovery;

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

		public double attackRange;

		public double hitRange;

		public int hpPerHit;

		public int addDamage;

		public int damageReduction;

		public int damageReflex;

		public int elemental;

		public int elementalLevel;

		public double visibilityDistance;

		public bool knockBackImmune;

		public double activityRange;

		public int monsterSkillId;
	}
}
