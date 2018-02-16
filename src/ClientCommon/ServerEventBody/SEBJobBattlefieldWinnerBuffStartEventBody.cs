using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBJobBattlefieldWinnerBuffStartEventBody : SEBServerEventBody
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

		public SEBJobBattlefieldWinnerBuffStartEventBody()
		{
		}

		public float remainingTime;
	}
}
