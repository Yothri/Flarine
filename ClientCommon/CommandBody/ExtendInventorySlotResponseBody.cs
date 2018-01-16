using System;

namespace ClientCommon.CommandBody
{
	public class ExtendInventorySlotResponseBody : ResponseBody
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

		public ExtendInventorySlotResponseBody()
		{
		}

		public int dia;
	}
}
