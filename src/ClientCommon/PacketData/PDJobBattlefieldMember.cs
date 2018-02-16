using System;

namespace ClientCommon.PacketData
{
	public class PDJobBattlefieldMember : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
			writer.Write(this.heroId);
			writer.Write(this.killCount);
			writer.Write(this.point);
			writer.Write(this.pointUpdateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.killCount = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.pointUpdateTime = reader.ReadDateTimeOffset();
		}

		public PDJobBattlefieldMember()
		{
		}

		public int id;

		public string name;

		public int heroId;

		public int killCount;

		public int point;

		public DateTimeOffset pointUpdateTime;
	}
}
