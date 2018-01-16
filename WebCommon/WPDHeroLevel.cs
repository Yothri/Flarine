using System;

namespace WebCommon
{
	public class WPDHeroLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.requiredLevelUpExp);
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
			writer.Write(this.recommendBattlePower);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.requiredLevelUpExp = reader.ReadInt64();
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
			this.recommendBattlePower = reader.ReadInt32();
		}

		public WPDHeroLevel()
		{
		}

		public int heroId;

		public int tradition;

		public int level;

		public long requiredLevelUpExp;

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

		public int recommendBattlePower;
	}
}
