using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickCostumeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedPickWarehouseSlot);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedPickWarehouseSlot = reader.ReadPDPacketData<PDPickWarehouseSlot>();
			this.dia = reader.ReadInt32();
		}

		public PickCostumeResponseBody()
		{
		}

		public PDPickWarehouseSlot addedPickWarehouseSlot;

		public int dia;
	}
}
