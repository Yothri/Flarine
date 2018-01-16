using System;

namespace ClientCommon.PacketData
{
	public class PDGuildApplyUser : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public PDGuildApplyUser()
		{
		}

		public int accountHeroId;

		public string name;

		public int heroId;

		public int tradition;

		public int level;
	}
}
