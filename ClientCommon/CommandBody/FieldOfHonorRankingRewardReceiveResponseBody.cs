using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorRankingRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rankingRewardRemainingTime);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rankingRewardRemainingTime = reader.ReadSingle();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public FieldOfHonorRankingRewardReceiveResponseBody()
		{
		}

		public float rankingRewardRemainingTime;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;

		public PDInventorySlot[] changedInventorySlots;
	}
}
