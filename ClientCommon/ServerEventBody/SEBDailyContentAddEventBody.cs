using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBDailyContentAddEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.dailyQuest);
			writer.Write(this.suppressionQuest);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.dailyQuest = reader.ReadPDPacketData<PDAccountHeroDailyQuest>();
			this.suppressionQuest = reader.ReadPDPacketData<PDAccountHeroSuppressionQuest>();
		}

		public SEBDailyContentAddEventBody()
		{
		}

		public DateTime date;

		public PDAccountHeroDailyQuest dailyQuest;

		public PDAccountHeroSuppressionQuest suppressionQuest;
	}
}
