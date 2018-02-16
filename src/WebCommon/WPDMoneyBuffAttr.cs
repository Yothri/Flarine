using System;

namespace WebCommon
{
	public class WPDMoneyBuffAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDMoneyBuffAttr()
		{
		}

		public int buffId;

		public int attrId;

		public double value;
	}
}
