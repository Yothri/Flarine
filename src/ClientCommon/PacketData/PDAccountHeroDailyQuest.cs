using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroDailyQuest : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chapterId);
			writer.Write(this.rewardId);
			writer.Write(this.rewardItemGroupId);
			writer.Write(this.completed);
			writer.Write(this.currentRound);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.chapterId = reader.ReadInt32();
			this.rewardId = reader.ReadInt32();
			this.rewardItemGroupId = reader.ReadInt32();
			this.completed = reader.ReadBoolean();
			this.currentRound = reader.ReadPDPacketData<PDAccountHeroDailyQuestRound>();
		}

		public PDAccountHeroDailyQuest()
		{
		}

		public int chapterId;

		public int rewardId;

		public int rewardItemGroupId;

		public bool completed;

		public PDAccountHeroDailyQuestRound currentRound;
	}
}
