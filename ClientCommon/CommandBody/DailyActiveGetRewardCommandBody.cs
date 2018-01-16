using System;

namespace ClientCommon.CommandBody
{
	public class DailyActiveGetRewardCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
		}

		public DailyActiveGetRewardCommandBody()
		{
		}

		public int rewardNo;
	}
}
