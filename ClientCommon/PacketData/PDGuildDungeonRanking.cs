using System;

namespace ClientCommon.PacketData
{
	public class PDGuildDungeonRanking : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.damage);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.damage = reader.ReadInt32();
		}

		public PDGuildDungeonRanking()
		{
		}

		public int ranking;

		public int accountHeroId;

		public string name;

		public int damage;
	}
}
