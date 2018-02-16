using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickPointExchangeProductBuyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pickPoint);
			writer.Write(this.date);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pickPoint = reader.ReadInt32();
			this.date = reader.ReadDateTime();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public PickPointExchangeProductBuyResponseBody()
		{
		}

		public int pickPoint;

		public DateTime date;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx accountHeroGear;
	}
}
