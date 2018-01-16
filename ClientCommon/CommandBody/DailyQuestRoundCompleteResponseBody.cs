using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyQuestRoundCompleteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.nextRound);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.nextRound = reader.ReadPDPacketData<PDAccountHeroDailyQuestRound>();
		}

		public DailyQuestRoundCompleteResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroDailyQuestRound nextRound;
	}
}
