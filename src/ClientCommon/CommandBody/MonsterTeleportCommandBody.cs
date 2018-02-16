using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MonsterTeleportCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public MonsterTeleportCommandBody()
		{
		}

		public long instanceId;

		public PDVector3 position;

		public float rotationY;
	}
}
