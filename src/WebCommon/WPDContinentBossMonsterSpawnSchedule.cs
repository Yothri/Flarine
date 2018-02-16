using System;

namespace WebCommon
{
	public class WPDContinentBossMonsterSpawnSchedule : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.scheduleId);
			writer.Write(this.spawnTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.scheduleId = reader.ReadInt32();
			this.spawnTime = reader.ReadInt32();
		}

		public WPDContinentBossMonsterSpawnSchedule()
		{
		}

		public int continentId;

		public int scheduleId;

		public int spawnTime;
	}
}
