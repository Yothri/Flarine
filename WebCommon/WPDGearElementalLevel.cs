using System;

namespace WebCommon
{
	public class WPDGearElementalLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elementalLevel);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elementalLevel = reader.ReadInt32();
			this.value = reader.ReadInt32();
		}

		public WPDGearElementalLevel()
		{
		}

		public int elementalLevel;

		public int value;
	}
}
