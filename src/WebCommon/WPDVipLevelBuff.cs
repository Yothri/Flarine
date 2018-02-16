using System;

namespace WebCommon
{
	public class WPDVipLevelBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDVipLevelBuff()
		{
		}

		public int vipLevel;

		public int attrId;

		public double value;
	}
}
