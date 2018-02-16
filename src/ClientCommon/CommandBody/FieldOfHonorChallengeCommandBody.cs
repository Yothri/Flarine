using System;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorChallengeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetRanking);
			writer.Write(this.targetAccountHeroId);
			writer.Write(this.isFree);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetRanking = reader.ReadInt32();
			this.targetAccountHeroId = reader.ReadInt32();
			this.isFree = reader.ReadBoolean();
		}

		public FieldOfHonorChallengeCommandBody()
		{
		}

		public int targetRanking;

		public int targetAccountHeroId;

		public bool isFree;
	}
}
