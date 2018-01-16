using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildDisbandStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.disbandRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.disbandRemainingTime = reader.ReadSingle();
		}

		public SEBGuildDisbandStartEventBody()
		{
		}

		public float disbandRemainingTime;
	}
}
