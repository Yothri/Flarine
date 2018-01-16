using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroEssenceExchangeRound : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.no);
			writer.Write(this.received);
			writer.Write(this.entries);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.no = reader.ReadInt32();
			this.received = reader.ReadBoolean();
			this.entries = reader.ReadPDPacketDatas<PDAccountHeroEssenceExchangeRoundEntry>();
		}

		public PDAccountHeroEssenceExchangeRound()
		{
		}

		public int no;

		public bool received;

		public PDAccountHeroEssenceExchangeRoundEntry[] entries;
	}
}
