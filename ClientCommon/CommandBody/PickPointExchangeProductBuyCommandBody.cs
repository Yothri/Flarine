using System;

namespace ClientCommon.CommandBody
{
	public class PickPointExchangeProductBuyCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
		}

		public PickPointExchangeProductBuyCommandBody()
		{
		}

		public int productId;
	}
}
