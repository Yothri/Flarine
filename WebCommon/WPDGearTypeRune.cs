using System;

namespace WebCommon
{
	public class WPDGearTypeRune : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearType);
			writer.Write(this.runeId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearType = reader.ReadInt32();
			this.runeId = reader.ReadInt32();
		}

		public WPDGearTypeRune()
		{
		}

		public int gearType;

		public int runeId;
	}
}
