﻿using System;

namespace WebCommon
{
	public class WPDArenaWinnerBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDArenaWinnerBuff()
		{
		}

		public int attrId;

		public double value;
	}
}
