using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class UseUniqueGearTicketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.gears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.gears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
		}

		public UseUniqueGearTicketResponseBody()
		{
		}

		public DateTime date;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx[] gears;
	}
}
