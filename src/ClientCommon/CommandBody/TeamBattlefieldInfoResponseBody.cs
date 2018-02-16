using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TeamBattlefieldInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isEnterableTime);
			writer.Write(this.isOpened);
			writer.Write(this.isFinished);
			writer.Write(this.memberCount);
			writer.Write(this.myBestRecord);
			writer.Write(this.bestRecord);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isEnterableTime = reader.ReadBoolean();
			this.isOpened = reader.ReadBoolean();
			this.isFinished = reader.ReadBoolean();
			this.memberCount = reader.ReadInt32();
			this.myBestRecord = reader.ReadPDPacketData<PDTeamBattlefieldBestRecord>();
			this.bestRecord = reader.ReadPDPacketData<PDTeamBattlefieldBestRecord>();
		}

		public TeamBattlefieldInfoResponseBody()
		{
		}

		public bool isEnterableTime;

		public bool isOpened;

		public bool isFinished;

		public int memberCount;

		public PDTeamBattlefieldBestRecord myBestRecord;

		public PDTeamBattlefieldBestRecord bestRecord;
	}
}
