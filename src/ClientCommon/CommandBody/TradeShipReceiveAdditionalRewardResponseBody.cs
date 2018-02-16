using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TradeShipReceiveAdditionalRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardExp);
			writer.Write(this.dia);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardExp = reader.ReadInt64();
			this.dia = reader.ReadInt32();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public TradeShipReceiveAdditionalRewardResponseBody()
		{
		}

		public long rewardExp;

		public int dia;

		public PDAccountHero accountHero;
	}
}
