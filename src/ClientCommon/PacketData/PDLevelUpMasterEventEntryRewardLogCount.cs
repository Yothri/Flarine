using System;

namespace ClientCommon.PacketData
{
	public class PDLevelUpMasterEventEntryRewardLogCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.rewardLogCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.rewardLogCount = reader.ReadInt32();
		}

		public PDLevelUpMasterEventEntryRewardLogCount()
		{
		}

		public int entryId;

		public int rewardLogCount;
	}
}
