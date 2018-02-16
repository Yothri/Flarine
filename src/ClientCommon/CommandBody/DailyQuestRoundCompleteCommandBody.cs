﻿using System;

namespace ClientCommon.CommandBody
{
	public class DailyQuestRoundCompleteCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.roundNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.roundNo = reader.ReadInt32();
		}

		public DailyQuestRoundCompleteCommandBody()
		{
		}

		public DateTime date;

		public int roundNo;
	}
}
