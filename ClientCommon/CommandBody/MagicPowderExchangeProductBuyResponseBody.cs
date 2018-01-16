using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MagicPowderExchangeProductBuyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.magicPowder);
			writer.Write(this.date);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.magicPowder = reader.ReadInt64();
			this.date = reader.ReadDateTime();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public MagicPowderExchangeProductBuyResponseBody()
		{
		}

		public long magicPowder;

		public DateTime date;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx accountHeroGear;
	}
}
