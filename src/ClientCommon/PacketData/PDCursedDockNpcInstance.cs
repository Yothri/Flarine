using System;

namespace ClientCommon.PacketData
{
	public class PDCursedDockNpcInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public PDCursedDockNpcInstance()
		{
		}

		public int hp;

		public PDVector3 position;

		public float rotationY;
	}
}
