using System;

namespace ClientCommon.CommandBody
{
	public class GuildApplyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isMember);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.guildBattlefieldWinnerBuffRemainingTime);
			writer.Write(this.guildMemberGrade);
			writer.Write(this.guildPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isMember = reader.ReadBoolean();
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
			this.guildBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
			this.guildMemberGrade = reader.ReadInt32();
			this.guildPoint = reader.ReadInt32();
		}

		public GuildApplyResponseBody()
		{
		}

		public bool isMember;

		public Guid guildId;

		public string guildName;

		public float guildBattlefieldWinnerBuffRemainingTime;

		public int guildMemberGrade;

		public int guildPoint;
	}
}
