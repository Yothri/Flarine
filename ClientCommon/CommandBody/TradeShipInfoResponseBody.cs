using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TradeShipInfoResponseBody : ResponseBody
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
			this.myBestRecord = reader.ReadPDPacketData<PDTradeShipBestRecord>();
			this.bestRecord = reader.ReadPDPacketData<PDTradeShipBestRecord>();
			this.abnormalPlayRewarded = reader.ReadBoolean();
		}

		public TradeShipInfoResponseBody()
		{
		}

		public DateTime date;

		public int playCount;

		public PDTradeShipBestRecord myBestRecord;

		public PDTradeShipBestRecord bestRecord;

		public bool abnormalPlayRewarded;
	}
}
