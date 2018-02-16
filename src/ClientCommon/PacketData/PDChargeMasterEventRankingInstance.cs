using System;

namespace ClientCommon.PacketData
{
	public class PDChargeMasterEventRankingInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public PDChargeMasterEventRankingInstance()
		{
		}

		public int ranking;

		public int accountHeroId;

		public string name;
	}
}
