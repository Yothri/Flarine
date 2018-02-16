using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DailyQuestRoundPayCompleteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.dia);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.nextRound);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.dia = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.nextRound = reader.ReadPDPacketData<PDAccountHeroDailyQuestRound>();
		}

		public DailyQuestRoundPayCompleteResponseBody()
		{
		}

		public PDAccountHero accountHero;

		public int dia;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroDailyQuestRound nextRound;
	}
}
