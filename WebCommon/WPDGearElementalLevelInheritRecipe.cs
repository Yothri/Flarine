using System;

namespace WebCommon
{
	public class WPDGearElementalLevelInheritRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elementalLevel);
			writer.Write(this.gold);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elementalLevel = reader.ReadInt32();
			this.gold = reader.ReadInt32();
		}

		public WPDGearElementalLevelInheritRecipe()
		{
		}

		public int elementalLevel;

		public int gold;
	}
}
