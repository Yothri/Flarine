using System;

namespace ClientCommon.PacketData
{
	public class PDPickPointExchangeProductBuyCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDPickPointExchangeProductBuyCount()
		{
		}

		public int productId;

		public int count;
	}
}
