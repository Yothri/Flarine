using System;

namespace ClientCommon.CommandBody
{
	public class EquipGearCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.gearSlotId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadGuid();
			this.gearSlotId = reader.ReadInt32();
		}

		public EquipGearCommandBody()
		{
		}

		public Guid accountHeroGearId;

		public int gearSlotId;
	}
}
