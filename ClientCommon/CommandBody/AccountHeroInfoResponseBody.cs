using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AccountHeroInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
			writer.Write(this.accountHeroInfo);
			writer.Write(this.friendType);
			writer.Write(this.friendCount);
			writer.Write(this.blockCount);
			writer.Write(this.enemyCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
			this.accountHeroInfo = reader.ReadPDPacketData<PDAccountHero>();
			this.friendType = reader.ReadInt32();
			this.friendCount = reader.ReadInt32();
			this.blockCount = reader.ReadInt32();
			this.enemyCount = reader.ReadInt32();
		}

		public AccountHeroInfoResponseBody()
		{
		}

		public int vipLevel;

		public PDAccountHero accountHeroInfo;

		public int friendType;

		public int friendCount;

		public int blockCount;

		public int enemyCount;
	}
}
