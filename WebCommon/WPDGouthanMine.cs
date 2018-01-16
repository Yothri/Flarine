using System;

namespace WebCommon
{
	public class WPDGouthanMine : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.miningCount);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.safezoneXPosition);
			writer.Write(this.safezoneYPosition);
			writer.Write(this.safezoneZPosition);
			writer.Write(this.safezoneRadius);
			writer.Write(this.locationId);
			writer.Write(this.pkEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.miningCount = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.safezoneXPosition = reader.ReadDouble();
			this.safezoneYPosition = reader.ReadDouble();
			this.safezoneZPosition = reader.ReadDouble();
			this.safezoneRadius = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
			this.pkEnabled = reader.ReadBoolean();
		}

		public WPDGouthanMine()
		{
		}

		public int requiredMainQuestId;

		public int miningCount;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public double safezoneXPosition;

		public double safezoneYPosition;

		public double safezoneZPosition;

		public double safezoneRadius;

		public int locationId;

		public bool pkEnabled;
	}
}
