using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBStoryDungeonClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.clearGradeId);
			writer.Write(this.playTime);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.pickEntries);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.clearGradeId = reader.ReadInt32();
			this.playTime = reader.ReadInt32();
			this.rewardExp = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.pickEntries = reader.ReadPDPacketDatas<PDStoryDungeonClearRewardPickEntry>();
		}

		public SEBStoryDungeonClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int clearGradeId;

		public int playTime;

		public int rewardExp;

		public int rewardOwnGold;

		public PDStoryDungeonClearRewardPickEntry[] pickEntries;
	}
}
