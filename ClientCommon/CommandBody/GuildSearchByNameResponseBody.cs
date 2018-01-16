using System;

namespace ClientCommon.CommandBody
{
	public class GuildSearchByNameResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
			writer.Write(this.memberCount);
			writer.Write(this.battlePower);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadNullableGuid();
			this.name = reader.ReadString();
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.memberCount = reader.ReadInt32();
			this.battlePower = reader.ReadInt64();
			this.level = reader.ReadInt32();
		}

		public GuildSearchByNameResponseBody()
		{
		}

		public Guid? id;

		public string name;

		public int masterId;

		public string masterName;

		public int memberCount;

		public long battlePower;

		public int level;
	}
}
