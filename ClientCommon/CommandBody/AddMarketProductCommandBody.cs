using System;

namespace ClientCommon.CommandBody
{
	public class AddMarketProductCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.unOwnGold);
			writer.Write(this.InventorySlotNo);
			writer.Write(this.cm_Count);
			writer.Write(this.accountHeroPetId);
			writer.Write(this.paymentMoneyType);
			writer.Write(this.price);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.InventorySlotNo = reader.ReadInt32();
			this.cm_Count = reader.ReadInt32();
			this.accountHeroPetId = reader.ReadGuid();
			this.paymentMoneyType = reader.ReadInt32();
			this.price = reader.ReadInt64();
		}

		public AddMarketProductCommandBody()
		{
		}

		public int type;

		public long unOwnGold;

		public int InventorySlotNo;

		public int cm_Count;

		public Guid accountHeroPetId;

		public int paymentMoneyType;

		public long price;
	}
}
