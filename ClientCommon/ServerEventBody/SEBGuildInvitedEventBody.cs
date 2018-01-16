using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildInvitedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isMember);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.guildBattlefieldWinnerBuffRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isMember = reader.ReadBoolean();
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
			this.guildBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
		}

		public SEBGuildInvitedEventBody()
		{
		}

		public bool isMember;

		public Guid guildId;

		public string guildName;

		public float guildBattlefieldWinnerBuffRemainingTime;
	}
}
