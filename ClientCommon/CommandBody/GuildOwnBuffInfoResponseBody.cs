using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildOwnBuffInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildUnOwnGold);
			writer.Write(this.guildWaterOfLife);
			writer.Write(this.guildOwnBuffs);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildUnOwnGold = reader.ReadInt64();
			this.guildWaterOfLife = reader.ReadInt32();
			this.guildOwnBuffs = reader.ReadPDPacketDatas<PDGuildOwnBuff>();
		}

		public GuildOwnBuffInfoResponseBody()
		{
		}

		public long guildUnOwnGold;

		public int guildWaterOfLife;

		public PDGuildOwnBuff[] guildOwnBuffs;
	}
}
