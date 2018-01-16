using System;

namespace ClientCommon.CommandBody
{
	public class ParticipatePetCommandBody : CommandBody
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

		public ParticipatePetCommandBody()
		{
		}

		public int placedPetSlotId;
	}
}
