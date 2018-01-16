using System;

namespace WebCommon
{
	public class WPDAccountHeroMenuActivation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.activationNo);
			writer.Write(this.openTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.activationNo = reader.ReadInt32();
			this.openTime = reader.ReadString();
		}

		public WPDAccountHeroMenuActivation()
		{
		}

		public int activationNo;

		public string openTime;
	}
}
