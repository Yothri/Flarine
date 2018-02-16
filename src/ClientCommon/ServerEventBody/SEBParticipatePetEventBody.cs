using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBParticipatePetEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.petId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.petId = reader.ReadInt32();
		}

		public SEBParticipatePetEventBody()
		{
		}

		public int accountHeroId;

		public int petId;
	}
}
