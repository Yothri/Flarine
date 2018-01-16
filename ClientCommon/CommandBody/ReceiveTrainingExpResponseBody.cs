using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ReceiveTrainingExpResponseBody : ResponseBody
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

		public ReceiveTrainingExpResponseBody()
		{
		}

		public PDAccountHero accountHero;
	}
}
