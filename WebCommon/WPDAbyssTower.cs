using System;

namespace WebCommon
{
	public class WPDAbyssTower : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredMainQuestId);
			writer.Write(this.startDelayTime);
			writer.Write(this.limitTime);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredMainQuestId = reader.ReadInt32();
			this.startDelayTime = reader.ReadInt32();
			this.limitTime = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
		}

		public WPDAbyssTower()
		{
		}

		public int requiredMainQuestId;

		public int startDelayTime;

		public int limitTime;

		public int locationId;
	}
}
