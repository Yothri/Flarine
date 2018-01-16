using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeShipFailEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.point);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.point = reader.ReadInt32();
			this.rewardExp = reader.ReadInt64();
			this.rewardOwnGold = reader.ReadInt64();
		}

		public SEBTradeShipFailEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int point;

		public long rewardExp;

		public long rewardOwnGold;
	}
}
