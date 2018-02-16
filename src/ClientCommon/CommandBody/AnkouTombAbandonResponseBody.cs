using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AnkouTombAbandonResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.point);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.myAccountHero);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.point = reader.ReadInt32();
			this.rewardExp = reader.ReadInt64();
			this.rewardOwnGold = reader.ReadInt64();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.continentId = reader.ReadInt32();
		}

		public AnkouTombAbandonResponseBody()
		{
		}

		public int point;

		public long rewardExp;

		public long rewardOwnGold;

		public PDAccountHero myAccountHero;

		public int continentId;
	}
}
