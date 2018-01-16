using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickPetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlot);
			writer.Write(this.addedPet);
			writer.Write(this.dia);
			writer.Write(this.pickPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
			this.addedPet = reader.ReadPDPacketData<PDAccountHeroPetEx>();
			this.dia = reader.ReadInt32();
			this.pickPoint = reader.ReadInt32();
		}

		public PickPetResponseBody()
		{
		}

		public PDInventorySlot changedInventorySlot;

		public PDAccountHeroPetEx addedPet;

		public int dia;

		public int pickPoint;
	}
}
