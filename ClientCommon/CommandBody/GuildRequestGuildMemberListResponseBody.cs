using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildRequestGuildMemberListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildMembers);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildMembers = reader.ReadPDPacketDatas<PDGuildMember>();
		}

		public GuildRequestGuildMemberListResponseBody()
		{
		}

		public PDGuildMember[] guildMembers;
	}
}
