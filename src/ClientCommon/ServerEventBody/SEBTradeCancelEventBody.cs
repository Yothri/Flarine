using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeCancelEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
		}

		public SEBTradeCancelEventBody()
		{
		}

		public long gold;
	}
}
