using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GouthanMineEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myAccountHero);
			writer.Write(this.accountHeroes);
			writer.Write(this.mineralInsts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.mineralInsts = reader.ReadPDPacketDatas<PDGouthanMineMineralInstance>();
		}

		public GouthanMineEnterResponseBody()
		{
		}

		public PDAccountHero myAccountHero;

		public PDAccountHero[] accountHeroes;

		public PDGouthanMineMineralInstance[] mineralInsts;
	}
}
