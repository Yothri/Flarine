using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroPetEx : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroPetId);
			writer.Write(this.petId);
			writer.Write(this.level);
			writer.Write(this.optDodge);
			writer.Write(this.optHPAmp);
			writer.Write(this.optHpPerHit);
			writer.Write(this.optAddDamage);
			writer.Write(this.optDamageReduction);
			writer.Write(this.optDamageReflection);
			writer.Write(this.optMaxHP);
			writer.Write(this.optAccuracy);
			writer.Write(this.optPhysicalOffenseAmp);
			writer.Write(this.optMagicalOffenseAmp);
			writer.Write(this.optPhysicalDefenseAmp);
			writer.Write(this.optMagicalDefenseAmp);
			writer.Write(this.owned);
			writer.Write(this.inventorySlotNo);
			writer.Write(this.pickWarehouseSlotNo);
			writer.Write(this.equippedPetSlotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroPetId = reader.ReadGuid();
			this.petId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.optDodge = reader.ReadInt32();
			this.optHPAmp = reader.ReadInt32();
			this.optHpPerHit = reader.ReadInt32();
			this.optAddDamage = reader.ReadInt32();
			this.optDamageReduction = reader.ReadInt32();
			this.optDamageReflection = reader.ReadInt32();
			this.optMaxHP = reader.ReadInt32();
			this.optAccuracy = reader.ReadInt32();
			this.optPhysicalOffenseAmp = reader.ReadInt32();
			this.optMagicalOffenseAmp = reader.ReadInt32();
			this.optPhysicalDefenseAmp = reader.ReadInt32();
			this.optMagicalDefenseAmp = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.inventorySlotNo = reader.ReadInt32();
			this.pickWarehouseSlotNo = reader.ReadInt32();
			this.equippedPetSlotId = reader.ReadInt32();
		}

		public PDAccountHeroPetEx()
		{
		}

		public Guid accountHeroPetId;

		public int petId;

		public int level;

		public int optDodge;

		public int optHPAmp;

		public int optHpPerHit;

		public int optAddDamage;

		public int optDamageReduction;

		public int optDamageReflection;

		public int optMaxHP;

		public int optAccuracy;

		public int optPhysicalOffenseAmp;

		public int optMagicalOffenseAmp;

		public int optPhysicalDefenseAmp;

		public int optMagicalDefenseAmp;

		public bool owned;

		public int inventorySlotNo;

		public int pickWarehouseSlotNo;

		public int equippedPetSlotId;
	}
}
