﻿using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBSecretChamberPortalExploredEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.portalId);
			writer.Write(this.linkedFloor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.portalId = reader.ReadInt32();
			this.linkedFloor = reader.ReadInt32();
		}

		public SEBSecretChamberPortalExploredEventBody()
		{
		}

		public int floor;

		public int portalId;

		public int linkedFloor;
	}
}
