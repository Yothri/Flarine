using System;

namespace ClientCommon.PacketData
{
	public class PDGuildMember : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.battlePower);
			writer.Write(this.guildMemberGrade);
			writer.Write(this.logoutTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.guildMemberGrade = reader.ReadInt32();
			this.logoutTime = reader.ReadDateTime();
		}

		public PDGuildMember()
		{
		}

		public int accountHeroId;

		public string name;

		public int heroId;

		public int tradition;

		public int level;

		public int battlePower;

		public int guildMemberGrade;

		public DateTime logoutTime;
	}
}
