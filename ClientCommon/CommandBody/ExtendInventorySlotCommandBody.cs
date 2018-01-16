using System;

namespace ClientCommon.CommandBody
{
	public class ExtendInventorySlotCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extendInventorySlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extendInventorySlotNo = reader.ReadInt32();
		}

		public ExtendInventorySlotCommandBody()
		{
		}

		public int extendInventorySlotNo;
	}
}
