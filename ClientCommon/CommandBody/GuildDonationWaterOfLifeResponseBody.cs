using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildDonationWaterOfLifeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildWaterOfLife);
			writer.Write(this.guildPoint);
			writer.Write(this.dailyGuildDonationCount);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildWaterOfLife = reader.ReadInt32();
			this.guildPoint = reader.ReadInt32();
			this.dailyGuildDonationCount = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public GuildDonationWaterOfLifeResponseBody()
		{
		}

		public DateTime date;

		public int guildWaterOfLife;

		public int guildPoint;

		public int dailyGuildDonationCount;

		public PDInventorySlot[] changedInventorySlots;
	}
}
