using System;

namespace ClientCommon.CommandBody
{
	public class AnkouTombReceiveAdditionalRewardCommandBody : CommandBody
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

		public AnkouTombReceiveAdditionalRewardCommandBody()
		{
		}

		public int rewardExpType;
	}
}
