using System;

namespace ClientCommon.CommandBody
{
	public class AcquireConstellationCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
			writer.Write(this.entryId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
		}

		public AcquireConstellationCommandBody()
		{
		}

		public int constellationId;

		public int step;

		public int cycle;

		public int entryId;
	}
}
