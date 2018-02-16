﻿using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBConsumeMountFPEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fp = reader.ReadInt32();
		}

		public SEBConsumeMountFPEventBody()
		{
		}

		public int fp;
	}
}
