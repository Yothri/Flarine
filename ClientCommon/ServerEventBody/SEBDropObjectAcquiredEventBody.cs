using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBDropObjectAcquiredEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
			writer.Write(this.ownGold);
			writer.Write(this.changedInventorySlot);
			writer.Write(this.gear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
			this.ownGold = reader.ReadInt64();
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
			this.gear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public SEBDropObjectAcquiredEventBody()
		{
		}

		public long gold;

		public long ownGold;

		public PDInventorySlot changedInventorySlot;

		public PDAccountHeroGearEx gear;
	}
}
