using System;

namespace ClientCommon.CommandBody
{
	public class GoldDungeonMonsterRunAwayCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
		}

		public GoldDungeonMonsterRunAwayCommandBody()
		{
		}

		public long monsterInstanceId;
	}
}
