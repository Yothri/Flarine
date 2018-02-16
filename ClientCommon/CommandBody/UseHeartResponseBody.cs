using System;

namespace ClientCommon.CommandBody
{
	public class UseHeartResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.heart);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.heart = reader.ReadInt64();
		}

		public UseHeartResponseBody()
		{
		}

		public DateTime date;

		public long heart;
	}
}
