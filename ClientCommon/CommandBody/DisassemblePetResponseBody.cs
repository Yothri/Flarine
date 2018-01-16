using System;

namespace ClientCommon.CommandBody
{
	public class DisassemblePetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heart);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.heart = reader.ReadInt64();
		}

		public DisassemblePetResponseBody()
		{
		}

		public long heart;
	}
}
