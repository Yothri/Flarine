using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AcquireVipLevelRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.magicPowder);
			writer.Write(this.starEssence);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.changedPetInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.magicPowder = reader.ReadInt64();
			this.starEssence = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.changedPetInventorySlots = reader.ReadPDPacketDatas<PDAccountHeroPetEx>();
		}

		public AcquireVipLevelRewardResponseBody()
		{
		}

		public long magicPowder;

		public long starEssence;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroPetEx[] changedPetInventorySlots;
	}
}
