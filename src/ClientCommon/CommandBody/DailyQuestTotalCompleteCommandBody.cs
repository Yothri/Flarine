using System;

namespace ClientCommon.CommandBody
{
	public class DailyQuestTotalCompleteCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
		}

		public DailyQuestTotalCompleteCommandBody()
		{
		}

		public DateTime date;
	}
}
