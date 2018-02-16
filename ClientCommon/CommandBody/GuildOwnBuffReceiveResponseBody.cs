using System;

namespace ClientCommon.CommandBody
{
	public class GuildOwnBuffReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.level);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
		}

		public GuildOwnBuffReceiveResponseBody()
		{
		}

		public int level;

		public float remainingTime;
	}
}
