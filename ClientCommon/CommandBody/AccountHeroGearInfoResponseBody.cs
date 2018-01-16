using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AccountHeroGearInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetAccountHeroGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetAccountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public AccountHeroGearInfoResponseBody()
		{
		}

		public PDAccountHeroGearEx targetAccountHeroGear;
	}
}
