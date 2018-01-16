using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildMemberGradeChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildMemberGrade);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildMemberGrade = reader.ReadInt32();
		}

		public SEBGuildMemberGradeChangedEventBody()
		{
		}

		public int guildMemberGrade;
	}
}
