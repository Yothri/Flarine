using System;

namespace WebCommon
{
	public class WPDGearType : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearType);
			writer.Write(this.category);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.attrEnchantMaterialItemId);
			writer.Write(this.attrEnchantEnabled);
			writer.Write(this.runeEnchantEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearType = reader.ReadInt32();
			this.category = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.attrEnchantMaterialItemId = reader.ReadInt32();
			this.attrEnchantEnabled = reader.ReadBoolean();
			this.runeEnchantEnabled = reader.ReadBoolean();
		}

		public WPDGearType()
		{
		}

		public int gearType;

		public int category;

		public string name;

		public string nameKey;

		public int attrEnchantMaterialItemId;

		public bool attrEnchantEnabled;

		public bool runeEnchantEnabled;
	}
}
