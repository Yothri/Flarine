using System;

namespace WebCommon
{
	public class WPDGuildMemberGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildMemberGrade);
			writer.Write(this.name);
			writer.Write(this.nameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.guildMemberGrade = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
		}

		public WPDGuildMemberGrade()
		{
		}

		public int guildMemberGrade;

		public string name;

		public string nameKey;
	}
}
