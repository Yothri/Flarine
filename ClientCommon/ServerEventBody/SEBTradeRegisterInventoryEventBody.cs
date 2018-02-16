using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeRegisterInventoryEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradeSlotNo);
			writer.Write(this.type);
			writer.Write(this.accountHeroGear);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.tradeSlotNo = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public SEBTradeRegisterInventoryEventBody()
		{
		}

		public int tradeSlotNo;

		public int type;

		public PDAccountHeroGearEx accountHeroGear;

		public int itemId;

		public int count;
	}
}
