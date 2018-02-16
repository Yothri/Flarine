using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAnkouTombPointAcquisitionEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.acquiredPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.acquiredPoint = reader.ReadInt32();
		}

		public SEBAnkouTombPointAcquisitionEventBody()
		{
		}

		public int acquiredPoint;
	}
}
