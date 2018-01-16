using System;

namespace ClientCommon.PacketData
{
	public abstract class PDRanking : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.accountHeroId);
			writer.Write(this.heroId);
			writer.Write(this.name);
			writer.Write(this.heroLevel);
			writer.Write(this.tradition);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
			writer.Write(this.mountTier);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroLevel = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
			this.mountTier = reader.ReadInt32();
		}

		protected PDRanking()
		{
		}

		public int ranking;

		public int accountHeroId;

		public int heroId;

		public string name;

		public int heroLevel;

		public int tradition;

		public int costumeId;

		public bool costumeVisible;

		public int mountTier;
	}
}
