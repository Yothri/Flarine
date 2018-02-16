using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class StoryDungeonInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.playCount);
			writer.Write(this.lastDifficulty);
			writer.Write(this.myBestRecords);
			writer.Write(this.bestRecords);
			writer.Write(this.abnormalPlayRewarded);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.playCount = reader.ReadInt32();
			this.lastDifficulty = reader.ReadInt32();
			this.myBestRecords = reader.ReadPDPacketDatas<PDStoryDungeonBestRecord>();
			this.bestRecords = reader.ReadPDPacketDatas<PDStoryDungeonBestRecord>();
			this.abnormalPlayRewarded = reader.ReadBoolean();
		}

		public StoryDungeonInfoResponseBody()
		{
		}

		public DateTime date;

		public int playCount;

		public int lastDifficulty;

		public PDStoryDungeonBestRecord[] myBestRecords;

		public PDStoryDungeonBestRecord[] bestRecords;

		public bool abnormalPlayRewarded;
	}
}
