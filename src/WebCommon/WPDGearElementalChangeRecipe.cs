using System;

namespace WebCommon
{
	public class WPDGearElementalChangeRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elementalLevel);
			writer.Write(this.dia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elementalLevel = reader.ReadInt32();
			this.dia = reader.ReadInt32();
		}

		public WPDGearElementalChangeRecipe()
		{
		}

		public int elementalLevel;

		public int dia;
	}
}
