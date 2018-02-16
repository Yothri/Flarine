using System;

namespace ClientCommon.CommandBody
{
	public class GuildRequestGuildListCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isOnlyAutoJoinGuild);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isOnlyAutoJoinGuild = reader.ReadBoolean();
		}

		public GuildRequestGuildListCommandBody()
		{
		}

		public bool isOnlyAutoJoinGuild;
	}
}
