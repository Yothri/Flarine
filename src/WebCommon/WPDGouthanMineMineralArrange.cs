using System;

namespace WebCommon
{
	public class WPDGouthanMineMineralArrange : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.arrangeId);
			writer.Write(this.mineralId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
			writer.Write(this.xRotation);
			writer.Write(this.yRotation);
			writer.Write(this.zRotation);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.arrangeId = reader.ReadInt32();
			this.mineralId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
			this.xRotation = reader.ReadDouble();
			this.yRotation = reader.ReadDouble();
			this.zRotation = reader.ReadDouble();
		}

		public WPDGouthanMineMineralArrange()
		{
		}

		public int arrangeId;

		public int mineralId;

		public double xPosition;

		public double yPosition;

		public double zPosition;

		public double xRotation;

		public double yRotation;

		public double zRotation;
	}
}
