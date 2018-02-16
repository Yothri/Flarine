using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildBattlefieldWinnerChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
		}

		public SEBGuildBattlefieldWinnerChangeEventBody()
		{
		}

		public Guid guildId;

		public string guildName;
	}
}
