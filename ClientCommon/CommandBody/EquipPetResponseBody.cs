using System;

namespace ClientCommon.CommandBody
{
	public class EquipPetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.placedPetSlotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.placedPetSlotId = reader.ReadInt32();
		}

		public EquipPetResponseBody()
		{
		}

		public int placedPetSlotId;
	}
}
