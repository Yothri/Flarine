using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ExpDungeonInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.playCount);
			writer.Write(this.myBestRecords);
			writer.Write(this.bestRecords);
			writer.Write(this.abnormalPlayRewarded);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.playCount = reader.ReadInt32();
			this.myBestRecords = reader.ReadPDPacketDatas<PDExpDungeonBestRecord>();
			this.bestRecords = reader.ReadPDPacketDatas<PDExpDungeonBestRecord>();
			this.abnormalPlayRewarded = reader.ReadBoolean();
		}

		public ExpDungeonInfoResponseBody()
		{
		}

		public DateTime date;

		public int playCount;

		public PDExpDungeonBestRecord[] myBestRecords;

		public PDExpDungeonBestRecord[] bestRecords;

		public bool abnormalPlayRewarded;
	}
}
