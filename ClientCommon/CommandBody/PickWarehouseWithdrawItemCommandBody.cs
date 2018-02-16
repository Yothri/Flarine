using System;

namespace ClientCommon.CommandBody
{
	public class PickWarehouseWithdrawItemCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.withdrawPickWarehouseSlotNo);
			writer.Write(this.withdrawCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.withdrawPickWarehouseSlotNo = reader.ReadInt32();
			this.withdrawCount = reader.ReadInt32();
		}

		public PickWarehouseWithdrawItemCommandBody()
		{
		}

		public int withdrawPickWarehouseSlotNo;

		public int withdrawCount;
	}
}
