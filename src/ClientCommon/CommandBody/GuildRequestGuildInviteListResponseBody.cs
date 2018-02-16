using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildRequestGuildInviteListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guilds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guilds = reader.ReadPDPacketDatas<PDGuild>();
		}

		public GuildRequestGuildInviteListResponseBody()
		{
		}

		public PDGuild[] guilds;
	}
}
