using System;

namespace WebCommon
{
	public class WPDAccountHeroVipLevelReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
		}

		public WPDAccountHeroVipLevelReward()
		{
		}

		public int vipLevel;
	}
}
