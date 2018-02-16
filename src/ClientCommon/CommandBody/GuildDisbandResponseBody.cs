using System;

namespace ClientCommon.CommandBody
{
	public class GuildDisbandResponseBody : ResponseBody
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

		public GuildDisbandResponseBody()
		{
		}

		public float disbandRemainingTime;
	}
}
