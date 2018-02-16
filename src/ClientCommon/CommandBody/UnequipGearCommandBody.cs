using System;

namespace ClientCommon.CommandBody
{
	public class UnequipGearCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearSlotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearSlotId = reader.ReadInt32();
		}

		public UnequipGearCommandBody()
		{
		}

		public int gearSlotId;
	}
}
