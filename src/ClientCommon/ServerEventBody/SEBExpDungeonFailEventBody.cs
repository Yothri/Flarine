using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBExpDungeonFailEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.rewardExp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.rewardExp = reader.ReadInt32();
		}

		public SEBExpDungeonFailEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int rewardExp;
	}
}
