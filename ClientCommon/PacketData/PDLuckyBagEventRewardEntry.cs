using System;

namespace ClientCommon.PacketData
{
	public class PDLuckyBagEventRewardEntry : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.requiredLuckyBagCount);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.exchangeableCount);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.requiredLuckyBagCount = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.exchangeableCount = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public PDLuckyBagEventRewardEntry()
		{
		}

		public int entryId;

		public int requiredLuckyBagCount;

		public int type;

		public int itemId;

		public int itemCount;

		public int exchangeableCount;

		public int sortNo;
	}
}
