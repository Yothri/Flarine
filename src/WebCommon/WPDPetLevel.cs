using System;

namespace WebCommon
{
	public class WPDPetLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petId);
			writer.Write(this.level);
			writer.Write(this.requiredHeart);
			writer.Write(this.disassembleHeart);
			writer.Write(this.qualityDisassembleUnOwnDia);
			writer.Write(this.qualityDisassembleHeart);
			writer.Write(this.physicalOffense);
			writer.Write(this.magicalOffense);
			writer.Write(this.physicalDefense);
			writer.Write(this.magicalDefense);
			writer.Write(this.accuracy);
			writer.Write(this.maxHp);
			writer.Write(this.moveSpeed);
			writer.Write(this.dodge);
			writer.Write(this.addDamage);
			writer.Write(this.hpPerHit);
			writer.Write(this.hpAmp);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.petId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.requiredHeart = reader.ReadInt32();
			this.disassembleHeart = reader.ReadInt32();
			this.qualityDisassembleUnOwnDia = reader.ReadInt32();
			this.qualityDisassembleHeart = reader.ReadInt32();
			this.physicalOffense = reader.ReadInt32();
			this.magicalOffense = reader.ReadInt32();
			this.physicalDefense = reader.ReadInt32();
			this.magicalDefense = reader.ReadInt32();
			this.accuracy = reader.ReadInt32();
			this.maxHp = reader.ReadInt32();
			this.moveSpeed = reader.ReadDouble();
			this.dodge = reader.ReadInt32();
			this.addDamage = reader.ReadInt32();
			this.hpPerHit = reader.ReadInt32();
			this.hpAmp = reader.ReadInt32();
		}

		public WPDPetLevel()
		{
		}

		public int petId;

		public int level;

		public int requiredHeart;

		public int disassembleHeart;

		public int qualityDisassembleUnOwnDia;

		public int qualityDisassembleHeart;

		public int physicalOffense;

		public int magicalOffense;

		public int physicalDefense;

		public int magicalDefense;

		public int accuracy;

		public int maxHp;

		public double moveSpeed;

		public int dodge;

		public int addDamage;

		public int hpPerHit;

		public int hpAmp;
	}
}
