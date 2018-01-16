using System;

namespace ClientCommon.CommandBody
{
	public class WarehouseDepositItemCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.depositInventorySlotNo);
			writer.Write(this.depositCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.depositInventorySlotNo = reader.ReadInt32();
			this.depositCount = reader.ReadInt32();
		}

		public WarehouseDepositItemCommandBody()
		{
		}

		public int depositInventorySlotNo;

		public int depositCount;
	}
}
