﻿using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMemberPositionChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
			writer.Write(this.position);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
		}

		public SEBPartyMemberPositionChangedEventBody()
		{
		}

		public int memberId;

		public PDVector3 position;
	}
}
