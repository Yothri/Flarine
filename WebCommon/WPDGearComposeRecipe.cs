using System;

namespace WebCommon
{
	public class WPDGearComposeRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.magicPowder);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
		}

		public WPDGearComposeRecipe()
		{
		}

		public int tier;

		public int magicPowder;
	}
}
