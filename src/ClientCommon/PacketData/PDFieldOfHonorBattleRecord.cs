using System;

namespace ClientCommon.PacketData
{
	public class PDFieldOfHonorBattleRecord : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.challengerId);
			writer.Write(this.challengerName);
			writer.Write(this.challengerRanking);
			writer.Write(this.targetId);
			writer.Write(this.targetName);
			writer.Write(this.targetRanking);
			writer.Write(this.isChallengerVictory);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.challengerId = reader.ReadInt32();
			this.challengerName = reader.ReadString();
			this.challengerRanking = reader.ReadInt32();
			this.targetId = reader.ReadInt32();
			this.targetName = reader.ReadString();
			this.targetRanking = reader.ReadInt32();
			this.isChallengerVictory = reader.ReadBoolean();
		}

		public PDFieldOfHonorBattleRecord()
		{
		}

		public int challengerId;

		public string challengerName;

		public int challengerRanking;

		public int targetId;

		public string targetName;

		public int targetRanking;

		public bool isChallengerVictory;
	}
}
