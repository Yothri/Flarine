using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroSuppressionQuest : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chapterId);
			writer.Write(this.completed);
			writer.Write(this.currentRound);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.chapterId = reader.ReadInt32();
			this.completed = reader.ReadBoolean();
			this.currentRound = reader.ReadPDPacketData<PDAccountHeroSuppressionQuestRound>();
		}

		public PDAccountHeroSuppressionQuest()
		{
		}

		public int chapterId;

		public bool completed;

		public PDAccountHeroSuppressionQuestRound currentRound;
	}
}
