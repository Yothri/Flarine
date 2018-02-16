using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class UseExchangeTicketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.gears);
			writer.Write(this.pets);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.gears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.pets = reader.ReadPDPacketDatas<PDAccountHeroPetEx>();
		}

		public UseExchangeTicketResponseBody()
		{
		}

		public DateTime date;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx[] gears;

		public PDAccountHeroPetEx[] pets;
	}
}
