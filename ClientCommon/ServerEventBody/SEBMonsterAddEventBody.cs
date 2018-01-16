﻿using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterAddEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monster);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monster = reader.ReadPDMonsterInstance<PDMonsterInstance>();
		}

		public SEBMonsterAddEventBody()
		{
		}

		public PDMonsterInstance monster;
	}
}
