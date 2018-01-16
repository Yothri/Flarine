using System;

namespace ClientCommon.PacketData
{
	public class PDPartyInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
			writer.Write(this.masterFaceId);
			writer.Write(this.masterHeroId);
			writer.Write(this.masterTradition);
			writer.Write(this.masterLevel);
			writer.Write(this.masterLocationId);
			writer.Write(this.memberCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.masterFaceId = reader.ReadInt32();
			this.masterHeroId = reader.ReadInt32();
			this.masterTradition = reader.ReadInt32();
			this.masterLevel = reader.ReadInt32();
			this.masterLocationId = reader.ReadInt32();
			this.memberCount = reader.ReadInt32();
		}

		public PDPartyInstance()
		{
		}

		public long instanceId;

		public int masterId;

		public string masterName;

		public int masterFaceId;

		public int masterHeroId;

		public int masterTradition;

		public int masterLevel;

		public int masterLocationId;

		public int memberCount;
	}
}
