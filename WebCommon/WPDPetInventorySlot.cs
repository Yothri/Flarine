using System;

namespace WebCommon
{
	public class WPDPetInventorySlot : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.slotNo);
			writer.Write(this.accountHeroPetId);
			writer.Write(this.petId);
			writer.Write(this.level);
			writer.Write(this.owned);
			writer.Write(this.opt_dodge);
			writer.Write(this.opt_hpAmp);
			writer.Write(this.opt_hpPerHit);
			writer.Write(this.opt_addDamage);
			writer.Write(this.opt_damageReduction);
			writer.Write(this.opt_damageReflex);
			writer.Write(this.opt_maxHp);
			writer.Write(this.opt_accuracy);
			writer.Write(this.opt_physicalOffenseAmp);
			writer.Write(this.opt_magicalOffenseAmp);
			writer.Write(this.opt_physicalDefenseAmp);
			writer.Write(this.opt_magicalDefenseAmp);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.slotNo = reader.ReadInt32();
			this.accountHeroPetId = reader.ReadString();
			this.petId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.opt_dodge = reader.ReadInt32();
			this.opt_hpAmp = reader.ReadInt32();
			this.opt_hpPerHit = reader.ReadInt32();
			this.opt_addDamage = reader.ReadInt32();
			this.opt_damageReduction = reader.ReadInt32();
			this.opt_damageReflex = reader.ReadInt32();
			this.opt_maxHp = reader.ReadInt32();
			this.opt_accuracy = reader.ReadInt32();
			this.opt_physicalOffenseAmp = reader.ReadInt32();
			this.opt_magicalOffenseAmp = reader.ReadInt32();
			this.opt_physicalDefenseAmp = reader.ReadInt32();
			this.opt_magicalDefenseAmp = reader.ReadInt32();
		}

		public WPDPetInventorySlot()
		{
		}

		public int accountHeroId;

		public int slotNo;

		public string accountHeroPetId;

		public int petId;

		public int level;

		public bool owned;

		public int opt_dodge;

		public int opt_hpAmp;

		public int opt_hpPerHit;

		public int opt_addDamage;

		public int opt_damageReduction;

		public int opt_damageReflex;

		public int opt_maxHp;

		public int opt_accuracy;

		public int opt_physicalOffenseAmp;

		public int opt_magicalOffenseAmp;

		public int opt_physicalDefenseAmp;

		public int opt_magicalDefenseAmp;
	}
}
