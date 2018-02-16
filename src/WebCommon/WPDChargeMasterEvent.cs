using System;

namespace WebCommon
{
	public class WPDChargeMasterEvent : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.rewardStartTime);
			writer.Write(this.rewardEndTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
			this.rewardStartTime = reader.ReadString();
			this.rewardEndTime = reader.ReadString();
		}

		public WPDChargeMasterEvent()
		{
		}

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public string startTime;

		public string endTime;

		public string rewardStartTime;

		public string rewardEndTime;
	}
}
