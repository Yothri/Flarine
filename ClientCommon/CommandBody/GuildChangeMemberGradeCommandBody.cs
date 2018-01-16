using System;

namespace ClientCommon.CommandBody
{
	public class GuildChangeMemberGradeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.guildMemberGrade);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.guildMemberGrade = reader.ReadInt32();
		}

		public GuildChangeMemberGradeCommandBody()
		{
		}

		public int accountHeroId;

		public int guildMemberGrade;
	}
}
