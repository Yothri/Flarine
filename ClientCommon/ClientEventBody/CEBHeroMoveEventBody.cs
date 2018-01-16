using System;
using ClientCommon.PacketData;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroMoveEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public CEBHeroMoveEventBody()
		{
		}

		public int accountHeroId;

		public PDVector3 position;

		public float rotationY;
	}
}
