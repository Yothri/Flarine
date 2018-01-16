﻿using System;

namespace ClientCommon.CommandBody
{
	public class MailReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mailIds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mailIds = reader.ReadGuids();
		}

		public MailReceiveCommandBody()
		{
		}

		public Guid[] mailIds;
	}
}
