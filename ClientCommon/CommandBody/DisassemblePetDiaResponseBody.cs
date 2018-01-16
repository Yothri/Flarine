using System;

namespace ClientCommon.CommandBody
{
	public class DisassemblePetDiaResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heart);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.heart = reader.ReadInt64();
			this.dia = reader.ReadInt32();
		}

		public DisassemblePetDiaResponseBody()
		{
		}

		public long heart;

		public int dia;
	}
}
