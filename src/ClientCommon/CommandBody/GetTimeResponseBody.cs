using System;

namespace ClientCommon.CommandBody
{
	public class GetTimeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.time);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.time = reader.ReadDateTime();
		}

		public GetTimeResponseBody()
		{
		}

		public DateTime time;
	}
}
