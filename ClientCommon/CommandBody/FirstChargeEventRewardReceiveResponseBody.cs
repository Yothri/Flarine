using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FirstChargeEventRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.pets);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.pets = reader.ReadPDPacketDatas<PDAccountHeroPetEx>();
		}

		public FirstChargeEventRewardReceiveResponseBody()
		{
		}

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroPetEx[] pets;
	}
}
