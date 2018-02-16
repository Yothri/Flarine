using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMemberMonsterKillEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
			writer.Write(this.monsterid);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
			this.monsterid = reader.ReadInt32();
		}

		public SEBPartyMemberMonsterKillEventBody()
		{
		}

		public int memberId;

		public int monsterid;
	}
}
