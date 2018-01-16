using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildDonationInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildUnOwnGold);
			writer.Write(this.guildWaterOfLife);
			writer.Write(this.level);
			writer.Write(this.masterName);
			writer.Write(this.memberCount);
			writer.Write(this.guildDonationCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildUnOwnGold = reader.ReadInt64();
			this.guildWaterOfLife = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.memberCount = reader.ReadInt32();
			this.guildDonationCounts = reader.ReadPDPacketDatas<PDAccountHeroGuildDonationCount>();
		}

		public GuildDonationInfoResponseBody()
		{
		}

		public DateTime date;

		public long guildUnOwnGold;

		public int guildWaterOfLife;

		public int level;

		public string masterName;

		public int memberCount;

		public PDAccountHeroGuildDonationCount[] guildDonationCounts;
	}
}
