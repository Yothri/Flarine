using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BuyProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.ownDia);
			writer.Write(this.gold);
			writer.Write(this.ownGold);
			writer.Write(this.magicPowder);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.gold = reader.ReadInt64();
			this.ownGold = reader.ReadInt64();
			this.magicPowder = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public BuyProductResponseBody()
		{
		}

		public int dia;

		public int ownDia;

		public long gold;

		public long ownGold;

		public long magicPowder;

		public PDInventorySlot[] changedInventorySlots;
	}
}
