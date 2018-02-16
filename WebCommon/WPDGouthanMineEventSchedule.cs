using System;

namespace WebCommon
{
	public class WPDGouthanMineEventSchedule : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.scheduleId);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.rewardFactor);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.scheduleId = reader.ReadInt32();
			this.startTime = reader.ReadInt32();
			this.endTime = reader.ReadInt32();
			this.rewardFactor = reader.ReadDouble();
		}

		public WPDGouthanMineEventSchedule()
		{
		}

		public int scheduleId;

		public int startTime;

		public int endTime;

		public double rewardFactor;
	}
}
