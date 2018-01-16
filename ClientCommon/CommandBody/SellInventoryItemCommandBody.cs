using System;

namespace ClientCommon.CommandBody
{
	public class SellInventoryItemCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetItemSlotNo);
			writer.Write(this.sellCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetItemSlotNo = reader.ReadInt32();
			this.sellCount = reader.ReadInt32();
		}

		public SellInventoryItemCommandBody()
		{
		}

		public int targetItemSlotNo;

		public int sellCount;
	}
}
