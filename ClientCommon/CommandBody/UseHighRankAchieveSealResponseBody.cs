using System;

namespace ClientCommon.CommandBody
{
	public class UseHighRankAchieveSealResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.achievePoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.achievePoint = reader.ReadInt32();
		}

		public UseHighRankAchieveSealResponseBody()
		{
		}

		public DateTime date;

		public int achievePoint;
	}
}
