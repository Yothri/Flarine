using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroGear : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.enchantLevel);
			writer.Write(this.equippedGearSlotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.equippedGearSlotId = reader.ReadInt32();
		}

		public PDAccountHeroGear()
		{
		}

		public int gearId;

		public int enchantLevel;

		public int equippedGearSlotId;
	}
}
