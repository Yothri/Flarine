using System;

namespace ClientCommon.CommandBody
{
	public class AcquireConstellationStepCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
		}

		public AcquireConstellationStepCommandBody()
		{
		}

		public int constellationId;

		public int step;
	}
}
