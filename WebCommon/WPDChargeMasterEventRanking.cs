using System;

namespace WebCommon
{
	public class WPDChargeMasterEventRanking : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.minChargeUnOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.minChargeUnOwnDia = reader.ReadInt32();
		}

		public WPDChargeMasterEventRanking()
		{
		}

		public int ranking;

		public int minChargeUnOwnDia;
	}
}
