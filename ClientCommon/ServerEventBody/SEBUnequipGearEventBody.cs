using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBUnequipGearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.gearSlotId);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.gearSlotId = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
		}

		public SEBUnequipGearEventBody()
		{
		}

		public int accountHeroId;

		public int gearSlotId;

		public float moveSpeed;
	}
}
