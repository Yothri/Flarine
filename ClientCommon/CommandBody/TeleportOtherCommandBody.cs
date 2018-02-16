using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TeleportOtherCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public TeleportOtherCommandBody()
		{
		}

		public int continentId;

		public PDVector3 position;

		public float rotationY;
	}
}
