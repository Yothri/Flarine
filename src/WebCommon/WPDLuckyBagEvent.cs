using System;

namespace WebCommon
{
	public class WPDLuckyBagEvent : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.eventId);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.rewardEndTime);
			writer.Write(this.buffDuration);
			writer.Write(this.luckyBagItemId);
			writer.Write(this.imageFileName);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.eventId = reader.ReadInt32();
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
			this.rewardEndTime = reader.ReadString();
			this.buffDuration = reader.ReadInt32();
			this.luckyBagItemId = reader.ReadInt32();
			this.imageFileName = reader.ReadString();
		}

		public WPDLuckyBagEvent()
		{
		}

		public int eventId;

		public string startTime;

		public string endTime;

		public string rewardEndTime;

		public int buffDuration;

		public int luckyBagItemId;

		public string imageFileName;
	}
}
