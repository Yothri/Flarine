using System;

namespace WebCommon
{
	public class WPDConstellationStep : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.requiredDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.requiredDia = reader.ReadInt32();
		}

		public WPDConstellationStep()
		{
		}

		public int constellationId;

		public int step;

		public int requiredDia;
	}
}
