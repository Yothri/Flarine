using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickTenCostumeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedPickWarehouseSlots);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedPickWarehouseSlots = reader.ReadPDPacketDatas<PDPickWarehouseSlot>();
			this.dia = reader.ReadInt32();
		}

		public PickTenCostumeResponseBody()
		{
		}

		public PDPickWarehouseSlot[] addedPickWarehouseSlots;

		public int dia;
	}
}
