using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroEssenceExchangeRoundEntry : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.useEssenceCount);
			writer.Write(this.received);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterCharacterId = reader.ReadInt32();
			this.useEssenceCount = reader.ReadInt32();
			this.received = reader.ReadBoolean();
		}

		public PDAccountHeroEssenceExchangeRoundEntry()
		{
		}

		public int monsterCharacterId;

		public int useEssenceCount;

		public bool received;
	}
}
