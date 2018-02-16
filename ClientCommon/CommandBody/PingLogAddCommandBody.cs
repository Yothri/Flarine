using System;

namespace ClientCommon.CommandBody
{
	public class PingLogAddCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pingMin);
			writer.Write(this.pingMax);
			writer.Write(this.pingAvg);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pingMin = reader.ReadInt32();
			this.pingMax = reader.ReadInt32();
			this.pingAvg = reader.ReadSingle();
		}

		public PingLogAddCommandBody()
		{
		}

		public int pingMin;

		public int pingMax;

		public float pingAvg;
	}
}
