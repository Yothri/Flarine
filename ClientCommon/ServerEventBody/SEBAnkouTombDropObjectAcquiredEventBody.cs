using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBAnkouTombDropObjectAcquiredEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.accountHeroName);
			writer.Write(this.dropObject);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.accountHeroName = reader.ReadString();
			this.dropObject = reader.ReadPDPacketData<PDDropObject>();
		}

		public SEBAnkouTombDropObjectAcquiredEventBody()
		{
		}

		public int accountHeroId;

		public string accountHeroName;

		public PDDropObject dropObject;
	}
}
