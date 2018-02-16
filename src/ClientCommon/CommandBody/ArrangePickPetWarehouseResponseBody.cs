using System;

namespace ClientCommon.CommandBody
{
	public class ArrangePickPetWarehouseResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pickPetWarehouseSlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pickPetWarehouseSlots = reader.ReadGuids();
		}

		public ArrangePickPetWarehouseResponseBody()
		{
		}

		public Guid[] pickPetWarehouseSlots;
	}
}
