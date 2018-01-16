using System;

namespace WebCommon
{
	public class WPDTradeShipObstacle : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.obstacleId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.obstacleId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
		}

		public WPDTradeShipObstacle()
		{
		}

		public int obstacleId;

		public double xPosition;

		public double yPosition;

		public double zPosition;
	}
}
