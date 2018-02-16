using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBChargeMasterEventRankingDeterminedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
		}

		public SEBChargeMasterEventRankingDeterminedEventBody()
		{
		}

		public int ranking;
	}
}
