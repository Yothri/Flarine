using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBSoldMarketProductEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
		}

		public SEBSoldMarketProductEventBody()
		{
		}
	}
}
