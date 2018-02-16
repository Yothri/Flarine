using System;

namespace WebCommon
{
	public class WPDWarehouseSlotItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.slotNo);
			writer.Write(this.slotType);
			writer.Write(this.eq_AccountHeroGearId);
			writer.Write(this.cm_ItemId);
			writer.Write(this.cm_Owned);
			writer.Write(this.cm_Count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.slotNo = reader.ReadInt32();
			this.slotType = reader.ReadInt32();
			this.eq_AccountHeroGearId = reader.ReadString();
			this.cm_ItemId = reader.ReadInt32();
			this.cm_Owned = reader.ReadBoolean();
			this.cm_Count = reader.ReadInt32();
		}

		public WPDWarehouseSlotItem()
		{
		}

		public int accountHeroId;

		public int slotNo;

		public int slotType;

		public string eq_AccountHeroGearId;

		public int cm_ItemId;

		public bool cm_Owned;

		public int cm_Count;
	}
}
