using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroSuppressionQuestRound : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.no);
			writer.Write(this.monsterId);
			writer.Write(this.monsterKillCount);
			writer.Write(this.monsterCount);
			writer.Write(this.rewardId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.no = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.monsterKillCount = reader.ReadInt32();
			this.monsterCount = reader.ReadInt32();
			this.rewardId = reader.ReadInt32();
		}

		public PDAccountHeroSuppressionQuestRound()
		{
		}

		public int no;

		public int monsterId;

		public int monsterKillCount;

		public int monsterCount;

		public int rewardId;
	}
}
