using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBDropObjectLifeEndEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt64();
		}

		public SEBDropObjectLifeEndEventBody()
		{
		}

		public long id;
	}
}
