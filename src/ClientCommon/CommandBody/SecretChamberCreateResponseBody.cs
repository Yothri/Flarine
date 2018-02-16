using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SecretChamberCreateResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.lastAdvertisementTime);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.lastAdvertisementTime = reader.ReadDateTimeOffset();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public SecretChamberCreateResponseBody()
		{
		}

		public long instanceId;

		public DateTimeOffset lastAdvertisementTime;

		public PDAccountHero myAccountHero;
	}
}
