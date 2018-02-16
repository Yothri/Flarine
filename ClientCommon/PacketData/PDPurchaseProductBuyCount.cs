using System;

namespace ClientCommon.PacketData
{
	public class PDPurchaseProductBuyCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.count);
			writer.Write(this.eventCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.eventCount = reader.ReadInt32();
		}

		public PDPurchaseProductBuyCount()
		{
		}

		public int productId;

		public int count;

		public int eventCount;
	}
}
