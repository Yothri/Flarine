using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AbyssTowerSweepResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.ownGold);
			writer.Write(this.starEssense);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.ownGold = reader.ReadInt64();
			this.starEssense = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public AbyssTowerSweepResponseBody()
		{
		}

		public DateTime date;

		public long ownGold;

		public long starEssense;

		public PDInventorySlot[] changedInventorySlots;
	}
}
