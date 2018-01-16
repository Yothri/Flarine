using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroMountTierChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.tier);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.tier = reader.ReadInt32();
		}

		public SEBHeroMountTierChangeEventBody()
		{
		}

		public int accountHeroId;

		public int tier;
	}
}
