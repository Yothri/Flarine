using System;

namespace WebCommon
{
	public class WPDBossAnnihilationOpenSchedule : WPDPacketData
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

		public WPDBossAnnihilationOpenSchedule()
		{
		}

		public int scheduleId;

		public int openTime;
	}
}
