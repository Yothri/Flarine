using System;

namespace WebCommon
{
	public class WPDConsumeMasterEventRanking : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.minConsumeUnOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.minConsumeUnOwnDia = reader.ReadInt32();
		}

		public WPDConsumeMasterEventRanking()
		{
		}

		public int ranking;

		public int minConsumeUnOwnDia;
	}
}
