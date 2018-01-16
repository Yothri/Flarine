using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LevelUpMasterEventInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardLogCounts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardLogCounts = reader.ReadPDPacketDatas<PDLevelUpMasterEventEntryRewardLogCount>();
		}

		public LevelUpMasterEventInfoResponseBody()
		{
		}

		public PDLevelUpMasterEventEntryRewardLogCount[] rewardLogCounts;
	}
}
