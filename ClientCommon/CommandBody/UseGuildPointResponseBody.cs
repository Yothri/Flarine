using System;

namespace ClientCommon.CommandBody
{
	public class UseGuildPointResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.guildPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.guildPoint = reader.ReadInt32();
		}

		public UseGuildPointResponseBody()
		{
		}

		public DateTime date;

		public int guildPoint;
	}
}
