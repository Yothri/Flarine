using System;

namespace ClientCommon.CommandBody
{
	public class DailyQuestRoundStarGradeUpgradeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownGold = reader.ReadInt64();
		}

		public DailyQuestRoundStarGradeUpgradeResponseBody()
		{
		}

		public long ownGold;
	}
}
