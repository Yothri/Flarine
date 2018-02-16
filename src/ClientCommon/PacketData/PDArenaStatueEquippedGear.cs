using System;

namespace ClientCommon.PacketData
{
	public class PDArenaStatueEquippedGear : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.gearId);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.slotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadGuid();
			this.gearId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.slotId = reader.ReadInt32();
		}

		public PDArenaStatueEquippedGear()
		{
		}

		public Guid accountHeroGearId;

		public int gearId;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int slotId;
	}
}
