using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBSecretChamberFailEventBody : SEBServerEventBody
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

		public SEBSecretChamberFailEventBody()
		{
		}

		public PDAccountHero accountHero;
	}
}
