using System;

namespace ClientCommon.CommandBody
{
	public class DailyAccessGetRewardCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accessTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accessTime = reader.ReadInt32();
		}

		public DailyAccessGetRewardCommandBody()
		{
		}

		public int accessTime;
	}
}
