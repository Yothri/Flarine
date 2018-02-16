using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BuyMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
			writer.Write(this.dia);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGear);
			writer.Write(this.accountHeroPet);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
			this.dia = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.accountHeroPet = reader.ReadPDPacketData<PDAccountHeroPetEx>();
		}

		public BuyMarketProductResponseBody()
		{
		}

		public long gold;

		public int dia;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx accountHeroGear;

		public PDAccountHeroPetEx accountHeroPet;
	}
}
