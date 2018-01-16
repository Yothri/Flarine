using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ReceiveTrainingExp2xResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public ReceiveTrainingExp2xResponseBody()
		{
		}

		public PDAccountHero accountHero;
	}
}
