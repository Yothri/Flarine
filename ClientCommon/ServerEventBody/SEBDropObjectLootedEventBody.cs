using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBDropObjectLootedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dropObjectId);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dropObjectId = reader.ReadInt64();
			this.accountHeroId = reader.ReadInt32();
		}

		public SEBDropObjectLootedEventBody()
		{
		}

		public long dropObjectId;

		public int accountHeroId;
	}
}
