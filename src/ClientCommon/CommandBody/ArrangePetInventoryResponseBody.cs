using System;

namespace ClientCommon.CommandBody
{
	public class ArrangePetInventoryResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.petInventorySlots = reader.ReadGuids();
		}

		public ArrangePetInventoryResponseBody()
		{
		}

		public Guid[] petInventorySlots;
	}
}
