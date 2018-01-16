using System;

namespace ClientCommon.CommandBody
{
	public class BeadMakeStepChangeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.beadMakeStepId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.beadMakeStepId = reader.ReadInt32();
		}

		public BeadMakeStepChangeResponseBody()
		{
		}

		public int dia;

		public int beadMakeStepId;
	}
}
