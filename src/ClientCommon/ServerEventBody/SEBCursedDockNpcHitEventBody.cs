using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBCursedDockNpcHitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.hitResult);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.hitResult = reader.ReadPDPacketData<PDHitResult>();
		}

		public SEBCursedDockNpcHitEventBody()
		{
		}

		public int hp;

		public PDHitResult hitResult;
	}
}
