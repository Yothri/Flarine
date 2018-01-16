using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LevelUpMasterEventEntryRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardLogCount);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardLogCount = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public LevelUpMasterEventEntryRewardReceiveResponseBody()
		{
		}

		public int rewardLogCount;

		public PDInventorySlot[] changedInventorySlots;
	}
}
