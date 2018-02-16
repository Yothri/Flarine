using System;

namespace ClientCommon.CommandBody
{
	public class DivideInventoryItemResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.newInventorySlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.newInventorySlotNo = reader.ReadInt32();
		}

		public DivideInventoryItemResponseBody()
		{
		}

		public int newInventorySlotNo;
	}
}
