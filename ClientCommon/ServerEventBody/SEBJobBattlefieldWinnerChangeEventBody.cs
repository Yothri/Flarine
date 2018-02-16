using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBJobBattlefieldWinnerChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
		}

		public SEBJobBattlefieldWinnerChangeEventBody()
		{
		}

		public int heroId;
	}
}
