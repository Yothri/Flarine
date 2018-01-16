using System;

namespace WebCommon
{
	public class WPDFirstChargeEvent : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
		}

		public WPDFirstChargeEvent()
		{
		}

		public string startTime;

		public string endTime;
	}
}
