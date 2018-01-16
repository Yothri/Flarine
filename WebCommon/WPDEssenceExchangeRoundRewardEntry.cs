using System;

namespace WebCommon
{
	public class WPDEssenceExchangeRoundRewardEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.round);
			writer.Write(this.entryNo);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.owned);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.round = reader.ReadInt32();
			this.entryNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
		}

		public WPDEssenceExchangeRoundRewardEntry()
		{
		}

		public int continentId;

		public int round;

		public int entryNo;

		public int itemId;

		public int count;

		public bool owned;
	}
}
