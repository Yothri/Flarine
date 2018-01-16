using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildBattlefieldStatueChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.statue);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.statue = reader.ReadPDPacketData<PDGuildBattlefieldStatue>();
		}

		public SEBGuildBattlefieldStatueChangeEventBody()
		{
		}

		public PDGuildBattlefieldStatue statue;
	}
}
