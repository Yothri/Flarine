using System;

namespace WebCommon
{
	public class WPDStoryDungeonObstacle : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.obstacleId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.obstacleId = reader.ReadInt32();
		}

		public WPDStoryDungeonObstacle()
		{
		}

		public int storyDungeonId;

		public int obstacleId;
	}
}
