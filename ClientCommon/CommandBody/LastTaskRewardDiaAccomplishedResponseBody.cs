using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LastTaskRewardDiaAccomplishedResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public LastTaskRewardDiaAccomplishedResponseBody()
		{
		}

		public int dia;

		public PDAccountHero accountHero;
	}
}
