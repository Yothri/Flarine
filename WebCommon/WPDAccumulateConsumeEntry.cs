using System;

namespace WebCommon
{
	public class WPDAccumulateConsumeEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.consumeDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.consumeDia = reader.ReadInt32();
		}

		public WPDAccumulateConsumeEntry()
		{
		}

		public int entryId;

		public int consumeDia;
	}
}
