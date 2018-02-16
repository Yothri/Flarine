using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SkyDungeonCreateResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public SkyDungeonCreateResponseBody()
		{
		}

		public long instanceId;

		public PDAccountHero myAccountHero;
	}
}
