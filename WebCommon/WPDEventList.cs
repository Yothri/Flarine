using System;

namespace WebCommon
{
	public class WPDEventList : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.eventId);
			writer.Write(this.sortNo);
			writer.Write(this.eventNameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.eventId = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
			this.eventNameKey = reader.ReadString();
		}

		public WPDEventList()
		{
		}

		public int eventId;

		public int sortNo;

		public string eventNameKey;
	}
}
