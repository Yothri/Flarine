using System;

namespace ClientCommon.CommandBody
{
	public class GuildInfoOtherResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
			writer.Write(this.memberCount);
			writer.Write(this.level);
			writer.Write(this.waterOfLife);
			writer.Write(this.unOwnGold);
			writer.Write(this.message);
			writer.Write(this.isDisbanding);
			writer.Write(this.disbandRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadGuid();
			this.name = reader.ReadString();
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.memberCount = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.waterOfLife = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.message = reader.ReadString();
			this.isDisbanding = reader.ReadBoolean();
			this.disbandRemainingTime = reader.ReadSingle();
		}

		public GuildInfoOtherResponseBody()
		{
		}

		public Guid id;

		public string name;

		public int masterId;

		public string masterName;

		public int memberCount;

		public int level;

		public int waterOfLife;

		public long unOwnGold;

		public string message;

		public bool isDisbanding;

		public float disbandRemainingTime;
	}
}
