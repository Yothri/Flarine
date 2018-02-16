using System;

namespace ClientCommon.CommandBody
{
	public class GuildSearchByNameCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildName = reader.ReadString();
		}

		public GuildSearchByNameCommandBody()
		{
		}

		public string guildName;
	}
}
