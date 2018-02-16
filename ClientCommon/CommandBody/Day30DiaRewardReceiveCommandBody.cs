using System;

namespace ClientCommon.CommandBody
{
	public class Day30DiaRewardReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.receiveDays);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.receiveDays = reader.ReadInt32();
		}

		public Day30DiaRewardReceiveCommandBody()
		{
		}

		public int receiveDays;
	}
}
