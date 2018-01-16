using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBCursedDockClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.date);
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
			this.date = reader.ReadDateTime();
			this.clearGradeId = reader.ReadInt32();
			this.playTime = reader.ReadInt32();
			this.rewardExp = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.pickEntries = reader.ReadPDPacketDatas<PDCursedDockRewardPickEntry>();
		}

		public SEBCursedDockClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public DateTime date;

		public int clearGradeId;

		public int playTime;

		public int rewardExp;

		public int rewardOwnGold;

		public PDCursedDockRewardPickEntry[] pickEntries;
	}
}
