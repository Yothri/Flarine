using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class IdentifyGearResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGear = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public IdentifyGearResponseBody()
		{
		}

		public PDAccountHeroGearEx accountHeroGear;
	}
}
