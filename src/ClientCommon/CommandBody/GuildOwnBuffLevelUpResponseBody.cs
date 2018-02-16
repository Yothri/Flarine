using System;

namespace ClientCommon.CommandBody
{
	public class GuildOwnBuffLevelUpResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildUnOwnGold);
			writer.Write(this.guildWaterOfLife);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildUnOwnGold = reader.ReadInt64();
			this.guildWaterOfLife = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public GuildOwnBuffLevelUpResponseBody()
		{
		}

		public long guildUnOwnGold;

		public int guildWaterOfLife;

		public int level;
	}
}
