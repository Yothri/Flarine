using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearEnchantLevelbyDiaResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extractionGearEnchantLevel);
			writer.Write(this.inheritGearEnchantLevel);
			writer.Write(this.intheritGearOwned);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extractionGearEnchantLevel = reader.ReadInt32();
			this.inheritGearEnchantLevel = reader.ReadInt32();
			this.intheritGearOwned = reader.ReadBoolean();
			this.dia = reader.ReadInt32();
		}

		public InheritGearEnchantLevelbyDiaResponseBody()
		{
		}

		public int extractionGearEnchantLevel;

		public int inheritGearEnchantLevel;

		public bool intheritGearOwned;

		public int dia;
	}
}
