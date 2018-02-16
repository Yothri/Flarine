using System;

namespace ClientCommon.PacketData
{
	public class PDInventorySlot : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotNo);
			writer.Write(this.inventoryItemType);
			writer.Write(this.eq_accountHeroGearId);
			writer.Write(this.cm_itemId);
			writer.Write(this.cm_owned);
			writer.Write(this.cm_count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.slotNo = reader.ReadInt32();
			this.inventoryItemType = reader.ReadInt32();
			this.eq_accountHeroGearId = reader.ReadGuid();
			this.cm_itemId = reader.ReadInt32();
			this.cm_owned = reader.ReadBoolean();
			this.cm_count = reader.ReadInt32();
		}

		public PDInventorySlot()
		{
		}

		public const int kInventoryItemType_None = 0;

		public const int kInventoryItemType_Gear = 1;

		public const int kInventoryItemType_Item = 2;

		public int slotNo;

		public int inventoryItemType;

		public Guid eq_accountHeroGearId;

		public int cm_itemId;

		public bool cm_owned;

		public int cm_count;
	}
}
