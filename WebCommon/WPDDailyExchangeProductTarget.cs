using System;

namespace WebCommon
{
	public class WPDDailyExchangeProductTarget : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
			writer.Write(this.tradition);
			writer.Write(this.exp);
			writer.Write(this.ownGold);
			writer.Write(this.starEssense);
			writer.Write(this.heart);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.starEssense = reader.ReadInt32();
			this.heart = reader.ReadInt32();
		}

		public WPDDailyExchangeProductTarget()
		{
		}

		public int productId;

		public int tradition;

		public int exp;

		public int ownGold;

		public int starEssense;

		public int heart;
	}
}
