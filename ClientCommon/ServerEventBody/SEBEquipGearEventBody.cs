using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBEquipGearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.gearSlotId);
			writer.Write(this.gearId);
			writer.Write(this.enchantLevel);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.gearSlotId = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.enchantLevel = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
		}

		public SEBEquipGearEventBody()
		{
		}

		public int accountHeroId;

		public int gearSlotId;

		public int gearId;

		public int enchantLevel;

		public float moveSpeed;
	}
}
