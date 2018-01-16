using System;

namespace ClientCommon.CommandBody
{
	public class GuildInviteAcceptResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildBattlefieldWinnerBuffRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
		}

		public GuildInviteAcceptResponseBody()
		{
		}

		public float guildBattlefieldWinnerBuffRemainingTime;
	}
}
