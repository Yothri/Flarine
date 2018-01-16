using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBEssenceExchangeInitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.essenceExchangeContinents);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.essenceExchangeContinents = reader.ReadPDPacketDatas<PDAccountHeroEssenceExchangeContinent>();
		}

		public SEBEssenceExchangeInitEventBody()
		{
		}

		public PDAccountHeroEssenceExchangeContinent[] essenceExchangeContinents;
	}
}
