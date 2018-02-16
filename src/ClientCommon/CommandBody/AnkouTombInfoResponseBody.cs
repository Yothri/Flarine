using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AnkouTombInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.playCount);
			writer.Write(this.myBestRecord);
			writer.Write(this.bestRecord);
			writer.Write(this.abnormalPlayRewarded);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.playCount = reader.ReadInt32();
			this.myBestRecord = reader.ReadPDPacketData<PDAnkouTombBestRecord>();
			this.bestRecord = reader.ReadPDPacketData<PDAnkouTombBestRecord>();
			this.abnormalPlayRewarded = reader.ReadBoolean();
		}

		public AnkouTombInfoResponseBody()
		{
		}

		public DateTime date;

		public int playCount;

		public PDAnkouTombBestRecord myBestRecord;

		public PDAnkouTombBestRecord bestRecord;

		public bool abnormalPlayRewarded;
	}
}
