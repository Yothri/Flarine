using System;

namespace WebCommon
{
	public class WPDEssenceExchangeRound : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.round);
			writer.Write(this.requiredGold);
			writer.Write(this.exp);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.round = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.exp = reader.ReadInt32();
		}

		public WPDEssenceExchangeRound()
		{
		}

		public int continentId;

		public int round;

		public int requiredGold;

		public int exp;
	}
}
