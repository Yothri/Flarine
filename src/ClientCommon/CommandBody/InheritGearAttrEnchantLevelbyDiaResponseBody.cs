using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearAttrEnchantLevelbyDiaResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extractionGearAttrEnchantLevel);
			writer.Write(this.inheritGearAttrEnchantLevel);
			writer.Write(this.inheritGearOwned);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extractionGearAttrEnchantLevel = reader.ReadInt32();
			this.inheritGearAttrEnchantLevel = reader.ReadInt32();
			this.inheritGearOwned = reader.ReadBoolean();
			this.dia = reader.ReadInt32();
		}

		public InheritGearAttrEnchantLevelbyDiaResponseBody()
		{
		}

		public int extractionGearAttrEnchantLevel;

		public int inheritGearAttrEnchantLevel;

		public bool inheritGearOwned;

		public int dia;
	}
}
