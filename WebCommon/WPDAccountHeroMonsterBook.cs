using System;

namespace WebCommon
{
	public class WPDAccountHeroMonsterBook : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.continentId);
			writer.Write(this.essenceItemId);
			writer.Write(this.essenceCount);
			writer.Write(this.count);
			writer.Write(this.name);
			writer.Write(this.nameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterCharacterId = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
			this.essenceItemId = reader.ReadInt32();
			this.essenceCount = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
		}

		public WPDAccountHeroMonsterBook()
		{
		}

		public int monsterCharacterId;

		public int continentId;

		public int essenceItemId;

		public int essenceCount;

		public int count;

		public string name;

		public string nameKey;
	}
}
