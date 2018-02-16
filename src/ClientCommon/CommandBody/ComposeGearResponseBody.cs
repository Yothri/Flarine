using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ComposeGearResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearOwned);
			writer.Write(this.gearId);
			writer.Write(this.changedGearAttributes);
			writer.Write(this.magicPowder);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.equipRequirementIgnored);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearOwned = reader.ReadBoolean();
			this.gearId = reader.ReadInt32();
			this.changedGearAttributes = reader.ReadPDPacketDatas<PDAccountHeroGearAttribute>();
			this.magicPowder = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.equipRequirementIgnored = reader.ReadBoolean();
		}

		public ComposeGearResponseBody()
		{
		}

		public bool gearOwned;

		public int gearId;

		public PDAccountHeroGearAttribute[] changedGearAttributes;

		public long magicPowder;

		public PDInventorySlot[] changedInventorySlots;

		public bool equipRequirementIgnored;
	}
}
