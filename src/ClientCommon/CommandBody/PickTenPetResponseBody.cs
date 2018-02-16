using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PickTenPetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedPets);
			writer.Write(this.dia);
			writer.Write(this.pickPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedPets = reader.ReadPDPacketDatas<PDAccountHeroPetEx>();
			this.dia = reader.ReadInt32();
			this.pickPoint = reader.ReadInt32();
		}

		public PickTenPetResponseBody()
		{
		}

		public PDAccountHeroPetEx[] addedPets;

		public int dia;

		public int pickPoint;
	}
}
