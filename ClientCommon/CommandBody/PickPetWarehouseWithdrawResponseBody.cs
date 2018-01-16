using System;

namespace ClientCommon.CommandBody
{
	public class PickPetWarehouseWithdrawResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petInventorySlotsNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.petInventorySlotsNo = reader.ReadInt32();
		}

		public PickPetWarehouseWithdrawResponseBody()
		{
		}

		public int petInventorySlotsNo;
	}
}
