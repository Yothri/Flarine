using System;

namespace WebCommon
{
	public class WPDAccumulateLoginReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.loginCount);
			writer.Write(this.magicPowder);
			writer.Write(this.receivedLoginCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.loginCount = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.receivedLoginCount = reader.ReadInt32();
		}

		public WPDAccumulateLoginReward()
		{
		}

		public int loginCount;

		public int magicPowder;

		public int receivedLoginCount;
	}
}
