using System;

namespace WebCommon
{
	public class WPDConstellationCycle : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
		}

		public WPDConstellationCycle()
		{
		}

		public int constellationId;

		public int step;

		public int cycle;
	}
}
