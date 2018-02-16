using System;

namespace WebCommon
{
	public class WPDLevelUpPackageEvent3 : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.startTime);
			writer.Write(this.endTime);
			writer.Write(this.rewardDay);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.startTime = reader.ReadString();
			this.endTime = reader.ReadString();
			this.rewardDay = reader.ReadInt32();
		}

		public WPDLevelUpPackageEvent3()
		{
		}

		public string startTime;

		public string endTime;

		public int rewardDay;
	}
}
