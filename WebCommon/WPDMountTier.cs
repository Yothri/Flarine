using System;

namespace WebCommon
{
	public class WPDMountTier : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.enchantLevelUpRequiredExp);
			writer.Write(this.enchantMaterialItemId);
			writer.Write(this.enchantMaterialItemCount);
			writer.Write(this.enchantExp);
			writer.Write(this.enchantJackpotExp);
			writer.Write(this.evolutionTierUpRequiredExp);
			writer.Write(this.evolutionMaterialItemId);
			writer.Write(this.evolutionMaterialItemCount);
			writer.Write(this.evolutionExp);
			writer.Write(this.freeFlyEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.enchantLevelUpRequiredExp = reader.ReadInt32();
			this.enchantMaterialItemId = reader.ReadInt32();
			this.enchantMaterialItemCount = reader.ReadInt32();
			this.enchantExp = reader.ReadInt32();
			this.enchantJackpotExp = reader.ReadInt32();
			this.evolutionTierUpRequiredExp = reader.ReadInt32();
			this.evolutionMaterialItemId = reader.ReadInt32();
			this.evolutionMaterialItemCount = reader.ReadInt32();
			this.evolutionExp = reader.ReadInt32();
			this.freeFlyEnabled = reader.ReadBoolean();
		}

		public WPDMountTier()
		{
		}

		public int tier;

		public string name;

		public string nameKey;

		public int enchantLevelUpRequiredExp;

		public int enchantMaterialItemId;

		public int enchantMaterialItemCount;

		public int enchantExp;

		public int enchantJackpotExp;

		public int evolutionTierUpRequiredExp;

		public int evolutionMaterialItemId;

		public int evolutionMaterialItemCount;

		public int evolutionExp;

		public bool freeFlyEnabled;
	}
}
