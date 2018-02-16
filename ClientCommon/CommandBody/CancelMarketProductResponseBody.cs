using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class CancelMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGear);
			writer.Write(this.accountHeroPet);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.accountHeroPet = reader.ReadPDPacketData<PDAccountHeroPetEx>();
		}

		public CancelMarketProductResponseBody()
		{
		}

		public long gold;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx accountHeroGear;

		public PDAccountHeroPetEx accountHeroPet;
	}
}
