using System;

namespace ClientCommon.PacketData
{
	public class PDMarketProductItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.accountHeroId);
			writer.Write(this.eq_AccountHeroGearId);
			writer.Write(this.type);
			writer.Write(this.eq_GearId);
			writer.Write(this.eq_GearGrade);
			writer.Write(this.eq_GearEnchantLevel);
			writer.Write(this.identified);
			writer.Write(this.blessed);
			writer.Write(this.equipRequirementIgnored);
			writer.Write(this.cm_ItemId);
			writer.Write(this.cm_Count);
			writer.Write(this.unOwnGold);
			writer.Write(this.accountHeroPetId);
			writer.Write(this.petId);
			writer.Write(this.petLevel);
			writer.Write(this.petGrade);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.price);
			writer.Write(this.unitPrice);
			writer.Write(this.status);
			writer.Write(this.received);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadGuid();
			this.accountHeroId = reader.ReadInt32();
			this.eq_AccountHeroGearId = reader.ReadGuid();
			this.type = reader.ReadInt32();
			this.eq_GearId = reader.ReadInt32();
			this.eq_GearGrade = reader.ReadInt32();
			this.eq_GearEnchantLevel = reader.ReadInt32();
			this.identified = reader.ReadBoolean();
			this.blessed = reader.ReadBoolean();
			this.equipRequirementIgnored = reader.ReadBoolean();
			this.cm_ItemId = reader.ReadInt32();
			this.cm_Count = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.accountHeroPetId = reader.ReadGuid();
			this.petId = reader.ReadInt32();
			this.petLevel = reader.ReadInt32();
			this.petGrade = reader.ReadInt32();
			this.paymentMoneyType = reader.ReadInt32();
			this.price = reader.ReadInt64();
			this.unitPrice = reader.ReadInt64();
			this.status = reader.ReadInt32();
			this.received = reader.ReadBoolean();
		}

		public PDMarketProductItem()
		{
		}

		public Guid productId;

		public int accountHeroId;

		public Guid eq_AccountHeroGearId;

		public int type;

		public int eq_GearId;

		public int eq_GearGrade;

		public int eq_GearEnchantLevel;

		public bool identified;

		public bool blessed;

		public bool equipRequirementIgnored;

		public int cm_ItemId;

		public int cm_Count;

		public long unOwnGold;

		public Guid accountHeroPetId;

		public int petId;

		public int petLevel;

		public int petGrade;

		public int paymentMoneyType;

		public long price;

		public long unitPrice;

		public int status;

		public bool received;
	}
}
