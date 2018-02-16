using System;

namespace WebCommon
{
	public class WPDEquippedGearRune : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.runeId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadString();
			this.runeId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDEquippedGearRune()
		{
		}

		public string accountHeroGearId;

		public int runeId;

		public double value;
	}
}
