using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildProductListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildUnOwnGold);
			writer.Write(this.guildWaterOfLife);
			writer.Write(this.level);
			writer.Write(this.guildProductCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildUnOwnGold = reader.ReadInt64();
			this.guildWaterOfLife = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.guildProductCounts = reader.ReadPDPacketDatas<PDAccountHeroGuildProductCount>();
		}

		public GuildProductListResponseBody()
		{
		}

		public DateTime date;

		public long guildUnOwnGold;

		public int guildWaterOfLife;

		public int level;

		public PDAccountHeroGuildProductCount[] guildProductCounts;
	}
}
