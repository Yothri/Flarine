using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBUnRidePetEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
		}

		public SEBUnRidePetEventBody()
		{
		}

		public int accountHeroId;

		public float moveSpeed;
	}
}
