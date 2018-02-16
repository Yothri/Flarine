using System;

namespace ClientCommon.CommandBody
{
	public class UseHPPotionCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.useItemInventorySlotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.useItemInventorySlotNo = reader.ReadInt32();
		}

		public UseHPPotionCommandBody()
		{
		}

		public int useItemInventorySlotNo;
	}
}
