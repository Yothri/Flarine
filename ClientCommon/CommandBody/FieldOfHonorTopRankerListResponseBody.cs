using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorTopRankerListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myRanking);
			writer.Write(this.abnormalPlayLogRewarded);
			writer.Write(this.rankers);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myRanking = reader.ReadInt32();
			this.abnormalPlayLogRewarded = reader.ReadBoolean();
			this.rankers = reader.ReadPDPacketDatas<PDFieldOfHonorRanker>();
		}

		public FieldOfHonorTopRankerListResponseBody()
		{
		}

		public int myRanking;

		public bool abnormalPlayLogRewarded;

		public PDFieldOfHonorRanker[] rankers;
	}
}
