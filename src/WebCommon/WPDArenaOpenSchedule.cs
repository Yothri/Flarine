using System;

namespace WebCommon
{
	public class WPDArenaOpenSchedule : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.scheduleId);
			writer.Write(this.openTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.scheduleId = reader.ReadInt32();
			this.openTime = reader.ReadInt32();
		}

		public WPDArenaOpenSchedule()
		{
		}

		public int scheduleId;

		public int openTime;
	}
}
