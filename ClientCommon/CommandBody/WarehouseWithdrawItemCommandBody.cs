using System;

namespace ClientCommon.CommandBody
{
	public class WarehouseWithdrawItemCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.withdrawWarehouseSlotNo);
			writer.Write(this.withdrawCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.withdrawWarehouseSlotNo = reader.ReadInt32();
			this.withdrawCount = reader.ReadInt32();
		}

		public WarehouseWithdrawItemCommandBody()
		{
		}

		public int withdrawWarehouseSlotNo;

		public int withdrawCount;
	}
}
