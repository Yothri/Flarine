using System;

namespace WebCommon
{
	public class WPDEssenceExchangeRoundEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.round);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.nameKey);
			writer.Write(this.essenceItemId);
			writer.Write(this.essenceCount);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.owned);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.round = reader.ReadInt32();
			this.monsterCharacterId = reader.ReadInt32();
			this.nameKey = reader.ReadString();
			this.essenceItemId = reader.ReadInt32();
			this.essenceCount = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
		}

		public WPDEssenceExchangeRoundEntry()
		{
		}

		public int continentId;

		public int round;

		public int monsterCharacterId;

		public string nameKey;

		public int essenceItemId;

		public int essenceCount;

		public int itemId;

		public int count;

		public bool owned;
	}
}
