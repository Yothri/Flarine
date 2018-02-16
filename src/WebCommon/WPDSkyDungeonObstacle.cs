using System;

namespace WebCommon
{
	public class WPDSkyDungeonObstacle : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
			writer.Write(this.obstacleId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
			this.obstacleId = reader.ReadInt32();
		}

		public WPDSkyDungeonObstacle()
		{
		}

		public int dungeonId;

		public int obstacleId;
	}
}
