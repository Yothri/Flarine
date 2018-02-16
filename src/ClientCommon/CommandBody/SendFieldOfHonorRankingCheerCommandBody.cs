using System;

namespace ClientCommon.CommandBody
{
	public class SendFieldOfHonorRankingCheerCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetRanking);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetRanking = reader.ReadInt32();
		}

		public SendFieldOfHonorRankingCheerCommandBody()
		{
		}

		public int targetRanking;
	}
}
