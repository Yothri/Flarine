using System;

namespace WebCommon
{
	public class WPDMountTierLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.level);
			writer.Write(this.physicalOffense);
			writer.Write(this.magicalOffense);
			writer.Write(this.physicalDefense);
			writer.Write(this.magicalDefense);
			writer.Write(this.accuracy);
			writer.Write(this.dodge);
			writer.Write(this.maxHP);
			writer.Write(this.hpPerHit);
			writer.Write(this.moveSpeed);
			writer.Write(this.fpConsume);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.physicalOffense = reader.ReadInt32();
			this.magicalOffense = reader.ReadInt32();
			this.physicalDefense = reader.ReadInt32();
			this.magicalDefense = reader.ReadInt32();
			this.accuracy = reader.ReadInt32();
			this.dodge = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.hpPerHit = reader.ReadInt32();
			this.moveSpeed = reader.ReadDouble();
			this.fpConsume = reader.ReadInt32();
		}

		public WPDMountTierLevel()
		{
		}

		public int tier;

		public int level;

		public int physicalOffense;

		public int magicalOffense;

		public int physicalDefense;

		public int magicalDefense;

		public int accuracy;

		public int dodge;

		public int maxHP;

		public int hpPerHit;

		public double moveSpeed;

		public int fpConsume;
	}
}
