using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ReceiveTrainingExp4xResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.dia = reader.ReadInt32();
		}

		public ReceiveTrainingExp4xResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public int dia;
	}
}
