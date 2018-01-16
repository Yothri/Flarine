using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TeleportSameCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public TeleportSameCommandBody()
		{
		}

		public PDVector3 position;

		public float rotationY;
	}
}
