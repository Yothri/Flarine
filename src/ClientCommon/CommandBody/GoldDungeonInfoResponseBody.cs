using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GoldDungeonInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.playCount);
			writer.Write(this.myBestRecords);
			writer.Write(this.bestRecords);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.playCount = reader.ReadInt32();
			this.myBestRecords = reader.ReadPDPacketDatas<PDGoldDungeonBestRecord>();
			this.bestRecords = reader.ReadPDPacketDatas<PDGoldDungeonBestRecord>();
		}

		public GoldDungeonInfoResponseBody()
		{
		}

		public DateTime date;

		public int playCount;

		public PDGoldDungeonBestRecord[] myBestRecords;

		public PDGoldDungeonBestRecord[] bestRecords;
	}
}
