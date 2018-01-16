using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SubmitMonsterEssenceResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.submittedMonsterEssences);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.submittedMonsterEssences = reader.ReadPDPacketDatas<PDMonsterBookEntry>();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public SubmitMonsterEssenceResponseBody()
		{
		}

		public PDMonsterBookEntry[] submittedMonsterEssences;

		public PDInventorySlot[] changedInventorySlots;
	}
}
