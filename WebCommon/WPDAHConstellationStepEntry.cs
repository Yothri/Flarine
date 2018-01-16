using System;

namespace WebCommon
{
	public class WPDAHConstellationStepEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
			writer.Write(this.entryId);
			writer.Write(this.failPoint);
			writer.Write(this.activated);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.failPoint = reader.ReadInt32();
			this.activated = reader.ReadBoolean();
		}

		public WPDAHConstellationStepEntry()
		{
		}

		public int constellationId;

		public int step;

		public int cycle;

		public int entryId;

		public int failPoint;

		public bool activated;
	}
}
