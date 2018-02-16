﻿using System;

namespace ClientCommon.CommandBody
{
	public class PartyDungeonBanishMemberCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetMemberId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetMemberId = reader.ReadInt32();
		}

		public PartyDungeonBanishMemberCommandBody()
		{
		}

		public int targetMemberId;
	}
}
