using System;

namespace ClientCommon.CommandBody
{
	public class AccountHeroCheerCountResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.receivedCheerCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.receivedCheerCount = reader.ReadInt32();
		}

		public AccountHeroCheerCountResponseBody()
		{
		}

		public int receivedCheerCount;
	}
}
