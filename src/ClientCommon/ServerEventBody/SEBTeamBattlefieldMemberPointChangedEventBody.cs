using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTeamBattlefieldMemberPointChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.killCount);
			writer.Write(this.point);
			writer.Write(this.pointUpdateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.killCount = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.pointUpdateTime = reader.ReadDateTimeOffset();
		}

		public SEBTeamBattlefieldMemberPointChangedEventBody()
		{
		}

		public int id;

		public int killCount;

		public int point;

		public DateTimeOffset pointUpdateTime;
	}
}
