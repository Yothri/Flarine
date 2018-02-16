using System;

namespace WebCommon
{
	public class WPDJobBattlefieldWinnerBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDJobBattlefieldWinnerBuff()
		{
		}

		public int attrId;

		public double value;
	}
}
