using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SecretChamberEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredBattlePower);
			writer.Write(this.autoStart);
			writer.Write(this.lastAdvertisementTime);
			writer.Write(this.myAccountHero);
			writer.Write(this.masterId);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredBattlePower = reader.ReadInt32();
			this.autoStart = reader.ReadBoolean();
			this.lastAdvertisementTime = reader.ReadDateTimeOffset();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.masterId = reader.ReadInt32();
			this.members = reader.ReadPDPacketDatas<PDAccountHero>();
		}

		public SecretChamberEnterResponseBody()
		{
		}

		public int requiredBattlePower;

		public bool autoStart;

		public DateTimeOffset lastAdvertisementTime;

		public PDAccountHero myAccountHero;

		public int masterId;

		public PDAccountHero[] members;
	}
}
