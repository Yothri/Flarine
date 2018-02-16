using System;

namespace ClientCommon.CommandBody
{
	public class UseBonusDiaPocketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.dia = reader.ReadInt32();
		}

		public UseBonusDiaPocketResponseBody()
		{
		}

		public DateTime date;

		public int dia;
	}
}
