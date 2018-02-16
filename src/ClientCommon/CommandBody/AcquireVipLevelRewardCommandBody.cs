using System;

namespace ClientCommon.CommandBody
{
	public class AcquireVipLevelRewardCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
		}

		public AcquireVipLevelRewardCommandBody()
		{
		}

		public int vipLevel;
	}
}
