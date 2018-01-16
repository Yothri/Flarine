using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBSecretChamberClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.date);
			writer.Write(this.isBonusReward);
			writer.Write(this.playTime);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.rewardBeadPowder);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.date = reader.ReadDateTime();
			this.isBonusReward = reader.ReadBoolean();
			this.playTime = reader.ReadInt32();
			this.rewardExp = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.rewardBeadPowder = reader.ReadInt32();
		}

		public SEBSecretChamberClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public DateTime date;

		public bool isBonusReward;

		public int playTime;

		public int rewardExp;

		public int rewardOwnGold;

		public int rewardBeadPowder;
	}
}
