using System;

namespace WebCommon
{
	public class WPDSuperCashbackEventRanking : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.cashbackRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.cashbackRate = reader.ReadDouble();
		}

		public WPDSuperCashbackEventRanking()
		{
		}

		public int ranking;

		public double cashbackRate;
	}
}
