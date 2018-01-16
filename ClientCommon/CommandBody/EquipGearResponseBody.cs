using System;

namespace ClientCommon.CommandBody
{
	public class EquipGearResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.placedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.placedInventorySlots = reader.ReadInts();
		}

		public EquipGearResponseBody()
		{
		}

		public int[] placedInventorySlots;
	}
}
