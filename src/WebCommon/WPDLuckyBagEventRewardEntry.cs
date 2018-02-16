using System;

namespace WebCommon
{
	public class WPDLuckyBagEventRewardEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.eventId);
			writer.Write(this.entryId);
			writer.Write(this.requiredLuckyBagCount);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.exchangeableCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.eventId = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.requiredLuckyBagCount = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.exchangeableCount = reader.ReadInt32();
		}

		public WPDLuckyBagEventRewardEntry()
		{
		}

		public int eventId;

		public int entryId;

		public int requiredLuckyBagCount;

		public int type;

		public int itemId;

		public int itemCount;

		public int exchangeableCount;
	}
}
