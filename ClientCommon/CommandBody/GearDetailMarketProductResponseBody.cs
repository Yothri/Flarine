using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GearDetailMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearEx);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearEx = reader.ReadPDPacketData<PDAccountHeroGearEx>();
		}

		public GearDetailMarketProductResponseBody()
		{
		}

		public PDAccountHeroGearEx accountHeroGearEx;
	}
}
