using System;

namespace ClientCommon.CommandBody
{
	public class PetSlotExtendResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
		}

		public PetSlotExtendResponseBody()
		{
		}

		public int dia;
	}
}
