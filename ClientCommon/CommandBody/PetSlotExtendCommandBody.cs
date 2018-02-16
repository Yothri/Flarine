using System;

namespace ClientCommon.CommandBody
{
	public class PetSlotExtendCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.slotId = reader.ReadInt32();
		}

		public PetSlotExtendCommandBody()
		{
		}

		public int slotId;
	}
}
