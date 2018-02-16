using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTraditionAcquisitionEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public SEBTraditionAcquisitionEventBody()
		{
		}

		public int accountHeroId;

		public int tradition;

		public int level;
	}
}
