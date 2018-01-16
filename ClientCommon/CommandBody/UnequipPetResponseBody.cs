using System;

namespace ClientCommon.CommandBody
{
	public class UnequipPetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.placedPetInventorySlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.placedPetInventorySlotNo = reader.ReadInt32();
		}

		public UnequipPetResponseBody()
		{
		}

		public int placedPetInventorySlotNo;
	}
}
