using System;

namespace WebCommon
{
	public class WPDTraditionBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDTraditionBuff()
		{
		}

		public int heroId;

		public int tradition;

		public int attrId;

		public double value;
	}
}
