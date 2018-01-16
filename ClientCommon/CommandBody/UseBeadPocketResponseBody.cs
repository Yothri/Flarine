using System;

namespace ClientCommon.CommandBody
{
	public class UseBeadPocketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.beadPowder);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.beadPowder = reader.ReadInt64();
		}

		public UseBeadPocketResponseBody()
		{
		}

		public DateTime date;

		public long beadPowder;
	}
}
