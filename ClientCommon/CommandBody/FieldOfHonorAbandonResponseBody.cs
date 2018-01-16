using System;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorAbandonResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardFamePoint);
			writer.Write(this.waitingRemainingTime);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.statStamina);
			writer.Write(this.famePoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardExp = reader.ReadInt32();
			this.rewardFamePoint = reader.ReadInt32();
			this.waitingRemainingTime = reader.ReadSingle();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt64();
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.famePoint = reader.ReadInt32();
		}

		public FieldOfHonorAbandonResponseBody()
		{
		}

		public int rewardExp;

		public int rewardFamePoint;

		public float waitingRemainingTime;

		public int level;

		public long exp;

		public int statPoint;

		public int statStrength;

		public int statAgility;

		public int statIntelligence;

		public int statStamina;

		public int famePoint;
	}
}
