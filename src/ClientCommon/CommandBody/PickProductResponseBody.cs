using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlot);
			writer.Write(this.addedPickWarehouseSlot);
			writer.Write(this.addedGear);
			writer.Write(this.dia);
			writer.Write(this.pickPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
			this.addedPickWarehouseSlot = reader.ReadPDPacketData<PDPickWarehouseSlot>();
			this.addedGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.dia = reader.ReadInt32();
			this.pickPoint = reader.ReadInt32();
		}

		public PickProductResponseBody()
		{
		}

		public PDInventorySlot changedInventorySlot;

		public PDPickWarehouseSlot addedPickWarehouseSlot;

		public PDAccountHeroGearEx addedGear;

		public int dia;

		public int pickPoint;
	}
}
