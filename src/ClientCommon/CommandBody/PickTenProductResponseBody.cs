using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickTenProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedPickWarehouseSlots);
			writer.Write(this.addedGears);
			writer.Write(this.dia);
			writer.Write(this.pickPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedPickWarehouseSlots = reader.ReadPDPacketDatas<PDPickWarehouseSlot>();
			this.addedGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.dia = reader.ReadInt32();
			this.pickPoint = reader.ReadInt32();
		}

		public PickTenProductResponseBody()
		{
		}

		public PDPickWarehouseSlot[] addedPickWarehouseSlots;

		public PDAccountHeroGearEx[] addedGears;

		public int dia;

		public int pickPoint;
	}
}
