using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBBossAnnihilationFailEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.damage);
			writer.Write(this.rank);
			writer.Write(this.rewardFamePoint);
			writer.Write(this.rewardOwnGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.damage = reader.ReadInt32();
			this.rank = reader.ReadInt32();
			this.rewardFamePoint = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
		}

		public SEBBossAnnihilationFailEventBody()
		{
		}

		public int damage;

		public int rank;

		public int rewardFamePoint;

		public int rewardOwnGold;
	}
}
