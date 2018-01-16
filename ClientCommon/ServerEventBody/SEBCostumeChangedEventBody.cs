using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBCostumeChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
		}

		public SEBCostumeChangedEventBody()
		{
		}

		public int accountHeroId;

		public int costumeId;

		public bool costumeVisible;
	}
}
