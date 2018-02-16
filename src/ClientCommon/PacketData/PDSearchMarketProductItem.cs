using System;

namespace ClientCommon.PacketData
{
	public class PDSearchMarketProductItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.accountHeroId);
			writer.Write(this.type);
			writer.Write(this.gearId);
			writer.Write(this.identified);
			writer.Write(this.blessed);
			writer.Write(this.grade);
			writer.Write(this.enchantLevel);
			writer.Write(this.battlePower);
			writer.Write(this.equipRequirementIgnored);
			writer.Write(this.ItemId);
			writer.Write(this.Count);
			writer.Write(this.unOwnGold);
			writer.Write(this.petId);
			writer.Write(this.petLevel);
			writer.Write(this.petGrade);
			writer.Write(this.petBattlePower);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.price);
			writer.Write(this.unitPrice);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadGuid();
			this.accountHeroId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.identified = reader.ReadBoolean();
			this.blessed = reader.ReadBoolean();
			this.grade = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.equipRequirementIgnored = reader.ReadBoolean();
			this.ItemId = reader.ReadInt32();
			this.Count = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.petId = reader.ReadInt32();
			this.petLevel = reader.ReadInt32();
			this.petGrade = reader.ReadInt32();
			this.petBattlePower = reader.ReadInt32();
			this.paymentMoneyType = reader.ReadInt32();
			this.price = reader.ReadInt64();
			this.unitPrice = reader.ReadInt64();
		}

		public PDSearchMarketProductItem()
		{
		}

		public Guid productId;

		public int accountHeroId;

		public int type;

		public int gearId;

		public bool identified;

		public bool blessed;

		public int grade;

		public int enchantLevel;

		public int battlePower;

		public bool equipRequirementIgnored;

		public int ItemId;

		public int Count;

		public long unOwnGold;

		public int petId;

		public int petLevel;

		public int petGrade;

		public int petBattlePower;

		public int paymentMoneyType;

		public long price;

		public long unitPrice;
	}
}
