using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyDungeonAdvertisementEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
			writer.Write(this.dungeonType);
			writer.Write(this.dungoenId);
			writer.Write(this.instanceId);
			writer.Write(this.time);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.dungeonType = reader.ReadInt32();
			this.dungoenId = reader.ReadInt32();
			this.instanceId = reader.ReadInt64();
			this.time = reader.ReadDateTimeOffset();
		}

		public SEBPartyDungeonAdvertisementEventBody()
		{
		}

		public int masterId;

		public string masterName;

		public int dungeonType;

		public int dungoenId;

		public long instanceId;

		public DateTimeOffset time;
	}
}
