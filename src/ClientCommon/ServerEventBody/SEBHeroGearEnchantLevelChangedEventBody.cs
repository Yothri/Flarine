using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroGearEnchantLevelChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.gearSlotId);
			writer.Write(this.enchantLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.gearSlotId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
		}

		public SEBHeroGearEnchantLevelChangedEventBody()
		{
		}

		public int accountHeroId;

		public int gearSlotId;

		public int enchantLevel;
	}
}
