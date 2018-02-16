using System;

namespace ClientCommon.PacketData
{
	public class PDFriendRecommendAccountHero : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public PDFriendRecommendAccountHero()
		{
		}

		public int accountHeroId;

		public int heroId;

		public int tradition;

		public int level;

		public string name;
	}
}
