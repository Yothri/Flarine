using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildActiveJournalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildActiveLogs);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildActiveLogs = reader.ReadPDPacketDatas<PDGuildActiveLog>();
		}

		public GuildActiveJournalResponseBody()
		{
		}

		public PDGuildActiveLog[] guildActiveLogs;
	}
}
