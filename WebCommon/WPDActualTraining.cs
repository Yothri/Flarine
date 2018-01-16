using System;

namespace WebCommon
{
	public class WPDActualTraining : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.availableTime);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.additionalAvailableTime);
			writer.Write(this.locationId);
			writer.Write(this.pkEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.availableTime = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.additionalAvailableTime = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.pkEnabled = reader.ReadBoolean();
		}

		public WPDActualTraining()
		{
		}

		public int requiredMainQuestId;

		public int availableTime;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public int additionalAvailableTime;

		public int locationId;

		public bool pkEnabled;
	}
}
