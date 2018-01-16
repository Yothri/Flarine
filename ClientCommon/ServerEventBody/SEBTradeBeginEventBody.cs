using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBTradeBeginEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public SEBTradeBeginEventBody()
		{
		}

		public int accountHeroId;

		public string name;
	}
}
