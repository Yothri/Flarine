using System;

namespace ClientCommon.CommandBody
{
	public class GuildApplyCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildId = reader.ReadGuid();
		}

		public GuildApplyCommandBody()
		{
		}

		public Guid guildId;
	}
}
