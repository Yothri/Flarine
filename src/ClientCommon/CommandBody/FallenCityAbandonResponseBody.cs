using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FallenCityAbandonResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myAccountHero);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.continentId = reader.ReadInt32();
		}

		public FallenCityAbandonResponseBody()
		{
		}

		public PDAccountHero myAccountHero;

		public int continentId;
	}
}
