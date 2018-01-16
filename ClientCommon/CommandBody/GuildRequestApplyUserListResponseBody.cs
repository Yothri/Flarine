using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildRequestApplyUserListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.appUsers);
			writer.Write(this.isAutoJoin);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.appUsers = reader.ReadPDPacketDatas<PDGuildApplyUser>();
			this.isAutoJoin = reader.ReadBoolean();
		}

		public GuildRequestApplyUserListResponseBody()
		{
		}

		public PDGuildApplyUser[] appUsers;

		public bool isAutoJoin;
	}
}
