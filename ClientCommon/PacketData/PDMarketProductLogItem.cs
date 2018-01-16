using System;

namespace ClientCommon.PacketData
{
	public class PDMarketProductLogItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.logType);
			writer.Write(this.targetAccountHeroId);
			writer.Write(this.productType);
			writer.Write(this.name);
			writer.Write(this.eq_AccountHeroGearId);
			writer.Write(this.eq_GearId);
			writer.Write(this.eq_GearGrade);
			writer.Write(this.eq_GearEnchantLevel);
			writer.Write(this.identified);
			writer.Write(this.blessed);
			writer.Write(this.cm_ItemId);
			writer.Write(this.cm_Count);
			writer.Write(this.unOwnGold);
			writer.Write(this.accountHeroPetId);
			writer.Write(this.petId);
			writer.Write(this.petLevel);
			writer.Write(this.petGrade);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.price);
			writer.Write(this.fee);
			writer.Write(this.regTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadGuid();
			this.logType = reader.ReadInt32();
			this.targetAccountHeroId = reader.ReadInt32();
			this.productType = reader.ReadInt32();
			this.name = reader.ReadString();
			this.eq_AccountHeroGearId = reader.ReadGuid();
			this.eq_GearId = reader.ReadInt32();
			this.eq_GearGrade = reader.ReadInt32();
			this.eq_GearEnchantLevel = reader.ReadInt32();
			this.identified = reader.ReadBoolean();
			this.blessed = reader.ReadBoolean();
			this.cm_ItemId = reader.ReadInt32();
			this.cm_Count = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.accountHeroPetId = reader.ReadGuid();
			this.petId = reader.ReadInt32();
			this.petLevel = reader.ReadInt32();
			this.petGrade = reader.ReadInt32();
			this.paymentMoneyType = reader.ReadInt32();
			this.price = reader.ReadInt64();
			this.fee = reader.ReadInt32();
			this.regTime = reader.ReadString();
		}

		public PDMarketProductLogItem()
		{
		}

		public Guid productId = Guid.Empty;

		public int logType;

		public int targetAccountHeroId;

		public int productType;

		public string name = "";

		public Guid eq_AccountHeroGearId = default(Guid);

		public int eq_GearId;

		public int eq_GearGrade;

		public int eq_GearEnchantLevel;

		public bool identified;

		public bool blessed;

		public int cm_ItemId;

		public int cm_Count;

		public long unOwnGold;

		public Guid accountHeroPetId = default(Guid);

		public int petId;

		public int petLevel;

		public int petGrade;

		public int paymentMoneyType;

		public long price;

		public int fee;

		public string regTime;
	}
}
