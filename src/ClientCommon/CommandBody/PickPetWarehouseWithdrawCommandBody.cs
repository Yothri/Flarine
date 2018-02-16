using System;

namespace ClientCommon.CommandBody
{
	public class PickPetWarehouseWithdrawCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.withdrawPickWarehouseSlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.withdrawPickWarehouseSlotNo = reader.ReadInt32();
		}

		public PickPetWarehouseWithdrawCommandBody()
		{
		}

		public int withdrawPickWarehouseSlotNo;
	}
}
