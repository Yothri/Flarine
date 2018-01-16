using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterBeginCastEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.targetPosition);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.targetPosition = reader.ReadPDVector3();
		}

		public SEBMonsterBeginCastEventBody()
		{
		}

		public long monsterInstanceId;

		public PDVector3 position;

		public float rotationY;

		public PDVector3 targetPosition;
	}
}
