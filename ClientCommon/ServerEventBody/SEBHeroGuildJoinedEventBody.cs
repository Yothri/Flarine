using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroGuildJoinedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
		}

		public SEBHeroGuildJoinedEventBody()
		{
		}

		public int accountHeroId;

		public Guid guildId;

		public string guildName;
	}
}
