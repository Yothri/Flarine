using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DisassembleGearResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.resultMagicPowder);
			writer.Write(this.resultItems);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.resultMagicPowder = reader.ReadInt32();
			this.resultItems = reader.ReadPDPacketDatas<PDGearDisassembleResultItem>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public DisassembleGearResponseBody()
		{
		}

		public int resultMagicPowder;

		public PDGearDisassembleResultItem[] resultItems;

		public PDInventorySlot[] changedInventorySlots;
	}
}
