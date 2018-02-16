using System;

namespace ClientCommon.CommandBody
{
	public class PartyDungeonAdvertiseResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.time);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.time = reader.ReadDateTimeOffset();
		}

		public PartyDungeonAdvertiseResponseBody()
		{
		}

		public DateTimeOffset time;
	}
}
