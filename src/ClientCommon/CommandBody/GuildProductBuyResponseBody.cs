using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildProductBuyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildPoint);
			writer.Write(this.dailyBuyProductCount);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildPoint = reader.ReadInt32();
			this.dailyBuyProductCount = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public GuildProductBuyResponseBody()
		{
		}

		public DateTime date;

		public int guildPoint;

		public int dailyBuyProductCount;

		public PDInventorySlot[] changedInventorySlots;
	}
}
