using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBBossAnnihilationClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.damage);
			writer.Write(this.rank);
			writer.Write(this.rewardFamePoint);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.rewardGear);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.rewards);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.damage = reader.ReadInt32();
			this.rank = reader.ReadInt32();
			this.rewardFamePoint = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.rewardGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.rewards = reader.ReadPDRewards<PDReward>();
		}

		public SEBBossAnnihilationClearEventBody()
		{
		}

		public int damage;

		public int rank;

		public int rewardFamePoint;

		public int rewardOwnGold;

		public PDAccountHeroGearEx rewardGear;

		public PDInventorySlot[] changedInventorySlots;

		public PDReward[] rewards;
	}
}
