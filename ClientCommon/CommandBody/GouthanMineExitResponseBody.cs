﻿using System;

namespace ClientCommon.CommandBody
{
	public class GouthanMineExitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
		}

		public GouthanMineExitResponseBody()
		{
		}

		public int hp;

		public int continentId;
	}
}
