using System;

namespace ClientCommon.PacketData
{
	public class PDFieldOfHonorRanker : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.heroId);
			writer.Write(this.faceId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
			writer.Write(this.mountTier);
			writer.Write(this.battlePower);
			writer.Write(this.equippedGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.faceId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
			this.mountTier = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.equippedGears = reader.ReadPDPacketDatas<PDAccountHeroGear>();
		}

		public PDFieldOfHonorRanker()
		{
		}

		public int ranking;

		public int accountHeroId;

		public string name;

		public int heroId;

		public int faceId;

		public int tradition;

		public int level;

		public int costumeId;

		public bool costumeVisible;

		public int mountTier;

		public int battlePower;

		public PDAccountHeroGear[] equippedGears;
	}
}
