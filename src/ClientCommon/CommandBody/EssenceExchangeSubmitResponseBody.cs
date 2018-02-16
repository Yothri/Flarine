using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EssenceExchangeSubmitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedEntries);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedEntries = reader.ReadPDPacketDatas<PDAccountHeroEssenceExchangeRoundEntry>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public EssenceExchangeSubmitResponseBody()
		{
		}

		public PDAccountHeroEssenceExchangeRoundEntry[] changedEntries;

		public PDInventorySlot[] changedInventorySlots;
	}
}
