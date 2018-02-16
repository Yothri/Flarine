using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBBuyMarketProductEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.message);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.message = reader.ReadString();
		}

		public SEBBuyMarketProductEventBody()
		{
		}

		public string message;
	}
}
