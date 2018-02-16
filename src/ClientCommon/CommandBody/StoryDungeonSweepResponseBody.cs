using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class StoryDungeonSweepResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.accountHero);
			writer.Write(this.acquiredGears);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.mailSended);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.acquiredGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.mailSended = reader.ReadBoolean();
		}

		public StoryDungeonSweepResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero accountHero;

		public PDAccountHeroGearEx[] acquiredGears;

		public PDInventorySlot[] changedInventorySlots;

		public bool mailSended;
	}
}
