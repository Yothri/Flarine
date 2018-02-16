using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PetDetailMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroPetEx);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroPetEx = reader.ReadPDPacketData<PDAccountHeroPetEx>();
		}

		public PetDetailMarketProductResponseBody()
		{
		}

		public PDAccountHeroPetEx accountHeroPetEx;
	}
}
