using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FallenCityRewardPickResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.pickedPickEntryId);
			writer.Write(this.rewardGear);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.pickedPickEntryId = reader.ReadInt32();
			this.rewardGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public FallenCityRewardPickResponseBody()
		{
		}

		public int dia;

		public PDAccountHeroGearEx rewardGear;

		public int pickedPickEntryId;

		public PDInventorySlot[] changedInventorySlots;
	}
}
