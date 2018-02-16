using System;

namespace ClientCommon.PacketData
{
	public class PDRankingEquippedGear : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.slotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.slotId = reader.ReadInt32();
		}

		public PDRankingEquippedGear()
		{
		}

		public int accountHeroId;

		public int gearId;

		public int grade;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int slotId;
	}
}
