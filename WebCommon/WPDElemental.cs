using System;

namespace WebCommon
{
	public class WPDElemental : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elemental);
			writer.Write(this.name);
			writer.Write(this.nameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elemental = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
		}

		public WPDElemental()
		{
		}

		public int elemental;

		public string name;

		public string nameKey;
	}
}
