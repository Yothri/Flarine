using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeCompleteEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
			writer.Write(this.changeInventorySlots);
			writer.Write(this.gears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
			this.changeInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.gears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
		}

		public SEBTradeCompleteEventBody()
		{
		}

		public long gold;

		public PDInventorySlot[] changeInventorySlots;

		public PDAccountHeroGearEx[] gears;
	}
}
