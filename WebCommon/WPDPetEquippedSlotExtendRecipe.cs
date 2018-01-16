using System;

namespace WebCommon
{
	public class WPDPetEquippedSlotExtendRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotId);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.slotId = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDPetEquippedSlotExtendRecipe()
		{
		}

		public int slotId;

		public int unOwnDia;
	}
}
