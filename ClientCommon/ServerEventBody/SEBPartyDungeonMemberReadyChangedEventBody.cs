using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyDungeonMemberReadyChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
			writer.Write(this.ready);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
			this.ready = reader.ReadBoolean();
		}

		public SEBPartyDungeonMemberReadyChangedEventBody()
		{
		}

		public int memberId;

		public bool ready;
	}
}
