using System;

namespace WebCommon
{
	public class WPDDungeonKingEvent : WPDPacketData
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

		public WPDDungeonKingEvent()
		{
		}

		public string startTime;

		public string endTime;
	}
}
