using System;

namespace WebCommon
{
	public class WPDWarehouseSlotExtendRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotNo);
			writer.Write(this.unOwnDia);
			writer.Write(this.requiredTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.slotNo = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
			this.requiredTime = reader.ReadInt32();
		}

		public WPDWarehouseSlotExtendRecipe()
		{
		}

		public int slotNo;

		public int unOwnDia;

		public int requiredTime;
	}
}
