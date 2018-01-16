using System;

namespace ClientCommon.CommandBody
{
	public class GuildDonationUnOwnGoldResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildUnOwnGold);
			writer.Write(this.guildPoint);
			writer.Write(this.dailyGuildDonationCount);
			writer.Write(this.UnOwnGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildUnOwnGold = reader.ReadInt64();
			this.guildPoint = reader.ReadInt32();
			this.dailyGuildDonationCount = reader.ReadInt32();
			this.UnOwnGold = reader.ReadInt64();
		}

		public GuildDonationUnOwnGoldResponseBody()
		{
		}

		public DateTime date;

		public long guildUnOwnGold;

		public int guildPoint;

		public int dailyGuildDonationCount;

		public long UnOwnGold;
	}
}
