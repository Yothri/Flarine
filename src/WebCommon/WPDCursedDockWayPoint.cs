using System;

namespace WebCommon
{
	public class WPDCursedDockWayPoint : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.wayPointNo);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.wayPointNo = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
		}

		public WPDCursedDockWayPoint()
		{
		}

		public int wayPointNo;

		public double xPosition;

		public double yPosition;

		public double zPosition;
	}
}
