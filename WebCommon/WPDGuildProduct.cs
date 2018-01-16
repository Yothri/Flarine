using System;

namespace WebCommon
{
	public class WPDGuildProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.requiredGuildLevel);
			writer.Write(this.dailyChangeLimit);
			writer.Write(this.guildPoint);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.requiredGuildLevel = reader.ReadInt32();
			this.dailyChangeLimit = reader.ReadInt32();
			this.guildPoint = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public WPDGuildProduct()
		{
		}

		public int productId;

		public int requiredGuildLevel;

		public int dailyChangeLimit;

		public int guildPoint;

		public int itemId;

		public int count;

		public int sortNo;
	}
}
