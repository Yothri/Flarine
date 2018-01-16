using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class CostumeEnchantResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.level);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public CostumeEnchantResponseBody()
		{
		}

		public int level;

		public PDInventorySlot[] changedInventorySlots;
	}
}
