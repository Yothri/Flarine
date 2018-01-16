using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBDailyActiveEntryEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.totalActivePoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.totalActivePoint = reader.ReadInt32();
		}

		public SEBDailyActiveEntryEventBody()
		{
		}

		public int entryId;

		public int totalActivePoint;
	}
}
