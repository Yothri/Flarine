using System;

namespace WebCommon
{
	public class WPDGearRune : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.runeId);
			writer.Write(this.attrId);
			writer.Write(this.materialItemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.runeId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.materialItemId = reader.ReadInt32();
		}

		public WPDGearRune()
		{
		}

		public int runeId;

		public int attrId;

		public int materialItemId;
	}
}
