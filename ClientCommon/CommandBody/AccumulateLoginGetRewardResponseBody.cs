using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AccumulateLoginGetRewardResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.totalMagicPowder);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.totalMagicPowder = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
		}

		public AccumulateLoginGetRewardResponseBody()
		{
		}

		public int totalMagicPowder;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx[] accountHeroGears;
	}
}
