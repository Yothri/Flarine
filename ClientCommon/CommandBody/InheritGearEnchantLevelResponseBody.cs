using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearEnchantLevelResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.success);
			writer.Write(this.extractionGearEnchantLevel);
			writer.Write(this.inheritGearEnchantLevel);
			writer.Write(this.intheritGearOwned);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.success = reader.ReadBoolean();
			this.extractionGearEnchantLevel = reader.ReadInt32();
			this.inheritGearEnchantLevel = reader.ReadInt32();
			this.intheritGearOwned = reader.ReadBoolean();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
		}

		public InheritGearEnchantLevelResponseBody()
		{
		}

		public bool success;

		public int extractionGearEnchantLevel;

		public int inheritGearEnchantLevel;

		public bool intheritGearOwned;

		public long ownGold;

		public long gold;
	}
}
