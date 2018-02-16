using System;

namespace WebCommon
{
	public class WPDStoryDungeonDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.difficulty);
			writer.Write(this.recommandPower);
			writer.Write(this.ownGold);
			writer.Write(this.exp);
			writer.Write(this.monsterId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.difficulty = reader.ReadInt32();
			this.recommandPower = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
		}

		public WPDStoryDungeonDifficulty()
		{
		}

		public int storyDungeonId;

		public int difficulty;

		public int recommandPower;

		public int ownGold;

		public int exp;

		public int monsterId;
	}
}
