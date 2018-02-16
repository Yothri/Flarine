using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAnkouTombStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
		}

		public SEBAnkouTombStartEventBody()
		{
		}

		public DateTime date;
	}
}
