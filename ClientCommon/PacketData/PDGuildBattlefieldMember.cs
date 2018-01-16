using System;

namespace ClientCommon.PacketData
{
	public class PDGuildBattlefieldMember : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
			writer.Write(this.campId);
			writer.Write(this.killCount);
			writer.Write(this.point);
			writer.Write(this.pointUpdateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.name = reader.ReadString();
			this.campId = reader.ReadGuid();
			this.killCount = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.pointUpdateTime = reader.ReadDateTimeOffset();
		}

		public PDGuildBattlefieldMember()
		{
		}

		public int id;

		public string name;

		public Guid campId;

		public int killCount;

		public int point;

		public DateTimeOffset pointUpdateTime;
	}
}
