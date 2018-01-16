using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyQuestTotalCompleteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.dia);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.dia = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public DailyQuestTotalCompleteResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public int dia;

		public PDInventorySlot[] changedInventorySlots;
	}
}
