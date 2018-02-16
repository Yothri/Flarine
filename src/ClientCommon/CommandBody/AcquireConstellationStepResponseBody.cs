using System;

namespace ClientCommon.CommandBody
{
	public class AcquireConstellationStepResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownDia);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownDia = reader.ReadInt32();
			this.dia = reader.ReadInt32();
		}

		public AcquireConstellationStepResponseBody()
		{
		}

		public int ownDia;

		public int dia;
	}
}
