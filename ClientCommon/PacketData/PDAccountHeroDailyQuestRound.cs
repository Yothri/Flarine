using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroDailyQuestRound : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.no);
			writer.Write(this.starGrade);
			writer.Write(this.isStarGradeUp);
			writer.Write(this.monsterId);
			writer.Write(this.monsterKillCount);
			writer.Write(this.monsterCount);
			writer.Write(this.rewardId);
			writer.Write(this.rewardItemGroupId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.no = reader.ReadInt32();
			this.starGrade = reader.ReadInt32();
			this.isStarGradeUp = reader.ReadBoolean();
			this.monsterId = reader.ReadInt32();
			this.monsterKillCount = reader.ReadInt32();
			this.monsterCount = reader.ReadInt32();
			this.rewardId = reader.ReadInt32();
			this.rewardItemGroupId = reader.ReadInt32();
		}

		public PDAccountHeroDailyQuestRound()
		{
		}

		public int no;

		public int starGrade;

		public bool isStarGradeUp;

		public int monsterId;

		public int monsterKillCount;

		public int monsterCount;

		public int rewardId;

		public int rewardItemGroupId;
	}
}
