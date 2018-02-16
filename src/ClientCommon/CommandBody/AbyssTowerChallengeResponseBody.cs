using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AbyssTowerChallengeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public AbyssTowerChallengeResponseBody()
		{
		}

		public PDAccountHero myAccountHero;
	}
}
