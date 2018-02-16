using System;

namespace WebCommon
{
	public class WPDTradition : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.statPoint);
			writer.Write(this.requiredGold);
			writer.Write(this.requiredMagicPowder);
			writer.Write(this.trainingRewardExpInterval);
			writer.Write(this.trainingRewardExp);
			writer.Write(this.trainingRewardStarEssenseInterval);
			writer.Write(this.trainingRewardStarEssense);
			writer.Write(this.statPointResetUnOwnDia);
			writer.Write(this.marbleStatLimit);
			writer.Write(this.maxFP);
			writer.Write(this.petEquipSlotCount);
			writer.Write(this.arenaRewardExp);
			writer.Write(this.arenaRewardAchievePoint);
			writer.Write(this.gouthanMineMineralExp);
			writer.Write(this.beadSocketCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.statPoint = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.requiredMagicPowder = reader.ReadInt32();
			this.trainingRewardExpInterval = reader.ReadInt32();
			this.trainingRewardExp = reader.ReadInt32();
			this.trainingRewardStarEssenseInterval = reader.ReadInt32();
			this.trainingRewardStarEssense = reader.ReadInt32();
			this.statPointResetUnOwnDia = reader.ReadInt32();
			this.marbleStatLimit = reader.ReadInt32();
			this.maxFP = reader.ReadInt32();
			this.petEquipSlotCount = reader.ReadInt32();
			this.arenaRewardExp = reader.ReadInt32();
			this.arenaRewardAchievePoint = reader.ReadInt32();
			this.gouthanMineMineralExp = reader.ReadInt32();
			this.beadSocketCount = reader.ReadInt32();
		}

		public WPDTradition()
		{
		}

		public int tradition;

		public int statPoint;

		public int requiredGold;

		public int requiredMagicPowder;

		public int trainingRewardExpInterval;

		public int trainingRewardExp;

		public int trainingRewardStarEssenseInterval;

		public int trainingRewardStarEssense;

		public int statPointResetUnOwnDia;

		public int marbleStatLimit;

		public int maxFP;

		public int petEquipSlotCount;

		public int arenaRewardExp;

		public int arenaRewardAchievePoint;

		public int gouthanMineMineralExp;

		public int beadSocketCount;
	}
}
