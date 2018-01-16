using System;

namespace WebCommon
{
	public class WPDSuperCashbackEventEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.eventDate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.eventDate = reader.ReadString();
		}

		public WPDSuperCashbackEventEntry()
		{
		}

		public int entryId;

		public string eventDate;
	}
}
