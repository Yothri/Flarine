using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildDungeonInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.monsterHp);
			writer.Write(this.rankings);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.monsterHp = reader.ReadInt32();
			this.rankings = reader.ReadPDPacketDatas<PDGuildDungeonRanking>();
		}

		public GuildDungeonInfoResponseBody()
		{
		}

		public long instanceId;

		public int monsterHp;

		public PDGuildDungeonRanking[] rankings;
	}
}
