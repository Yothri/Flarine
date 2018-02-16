using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildBattlefieldInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isEnterableTime);
			writer.Write(this.isOpened);
			writer.Write(this.isFinished);
			writer.Write(this.memberCount);
			writer.Write(this.campMemberCount);
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
			this.campMemberCount = reader.ReadInt32();
			this.myBestRecord = reader.ReadPDPacketData<PDGuildBattlefieldBestRecord>();
			this.bestRecord = reader.ReadPDPacketData<PDGuildBattlefieldBestRecord>();
		}

		public GuildBattlefieldInfoResponseBody()
		{
		}

		public bool isEnterableTime;

		public bool isOpened;

		public bool isFinished;

		public int memberCount;

		public int campMemberCount;

		public PDGuildBattlefieldBestRecord myBestRecord;

		public PDGuildBattlefieldBestRecord bestRecord;
	}
}
