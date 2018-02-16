using System;
using ClientCommon.PacketData;

namespace ClientCommon.ClientEventBody
{
	public class CEBMonsterMoveEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public CEBMonsterMoveEventBody()
		{
		}

		public long monsterInstanceId;

		public PDVector3 position;

		public float rotationY;
	}
}
