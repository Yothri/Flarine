﻿using System;

namespace ClientCommon.CommandBody
{
	public class GoldDungeonMonsterRunAwayResponseBody : ResponseBody
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

		public GoldDungeonMonsterRunAwayResponseBody()
		{
		}

		public long monsterInstanceId;
	}
}
