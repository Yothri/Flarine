using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeShipStartEventBody : SEBServerEventBody
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

		public SEBTradeShipStartEventBody()
		{
		}

		public DateTime date;
	}
}
