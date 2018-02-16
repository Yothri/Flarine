using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBLuckyBagAcquiredEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.count);
			writer.Write(this.isMail);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.count = reader.ReadInt32();
			this.isMail = reader.ReadBoolean();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public SEBLuckyBagAcquiredEventBody()
		{
		}

		public int count;

		public bool isMail;

		public PDInventorySlot[] changedInventorySlots;
	}
}
