using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class CursedDockCreateResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.lastAdvertisementTime);
			writer.Write(this.myAccountHero);
			writer.Write(this.npc);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.lastAdvertisementTime = reader.ReadDateTimeOffset();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.npc = reader.ReadPDPacketData<PDCursedDockNpcInstance>();
		}

		public CursedDockCreateResponseBody()
		{
		}

		public long instanceId;

		public DateTimeOffset lastAdvertisementTime;

		public PDAccountHero myAccountHero;

		public PDCursedDockNpcInstance npc;
	}
}
