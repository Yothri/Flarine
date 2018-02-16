using System;

namespace ClientCommon.CommandBody
{
	public class TradeShipReceiveAdditionalRewardCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardExpType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardExpType = reader.ReadInt32();
		}

		public TradeShipReceiveAdditionalRewardCommandBody()
		{
		}

		public int rewardExpType;
	}
}
