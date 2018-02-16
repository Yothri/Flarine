using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBRidePetEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.petId);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
		}

		public SEBRidePetEventBody()
		{
		}

		public int accountHeroId;

		public int petId;

		public float moveSpeed;
	}
}
