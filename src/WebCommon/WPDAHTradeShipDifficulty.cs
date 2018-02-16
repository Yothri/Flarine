using System;

namespace WebCommon
{
	public class WPDAHTradeShipDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.point);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.point = reader.ReadInt32();
		}

		public WPDAHTradeShipDifficulty()
		{
		}

		public int tradition;

		public int point;
	}
}
