using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildApplicationAcceptedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.guildBattlefieldWinnerBuffRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
			this.guildBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
		}

		public SEBGuildApplicationAcceptedEventBody()
		{
		}

		public Guid guildId;

		public string guildName;

		public float guildBattlefieldWinnerBuffRemainingTime;
	}
}
