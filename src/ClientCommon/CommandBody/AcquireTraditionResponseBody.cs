using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AcquireTraditionResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.vipLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.vipLevel = reader.ReadInt32();
		}

		public AcquireTraditionResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public int vipLevel;
	}
}
