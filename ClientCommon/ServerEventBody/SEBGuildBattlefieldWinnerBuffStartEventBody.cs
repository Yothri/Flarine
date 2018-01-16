using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildBattlefieldWinnerBuffStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.remainingTime = reader.ReadSingle();
		}

		public SEBGuildBattlefieldWinnerBuffStartEventBody()
		{
		}

		public float remainingTime;
	}
}
