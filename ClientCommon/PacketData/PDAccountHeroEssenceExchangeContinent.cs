using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroEssenceExchangeContinent : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.turn);
			writer.Write(this.turnRemainingTime);
			writer.Write(this.round);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.turn = reader.ReadInt32();
			this.turnRemainingTime = reader.ReadSingle();
			this.round = reader.ReadPDPacketData<PDAccountHeroEssenceExchangeRound>();
		}

		public PDAccountHeroEssenceExchangeContinent()
		{
		}

		public int continentId;

		public int turn;

		public float turnRemainingTime;

		public PDAccountHeroEssenceExchangeRound round;
	}
}
