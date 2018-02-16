using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBStoryDungeonFailEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.rewardExp = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
		}

		public SEBStoryDungeonFailEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int rewardExp;

		public int rewardOwnGold;
	}
}
