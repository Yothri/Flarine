using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FallenCityRewardPickAllResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.rewardGears);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.rewardGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public FallenCityRewardPickAllResponseBody()
		{
		}

		public int dia;

		public PDAccountHeroGearEx[] rewardGears;

		public PDInventorySlot[] changedInventorySlots;
	}
}
