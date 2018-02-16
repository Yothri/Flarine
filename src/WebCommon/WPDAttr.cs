using System;

namespace WebCommon
{
	public class WPDAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.weightingFactor);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.attrId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.weightingFactor = reader.ReadInt32();
		}

		public WPDAttr()
		{
		}

		public int attrId;

		public string name;

		public string nameKey;

		public int weightingFactor;
	}
}
