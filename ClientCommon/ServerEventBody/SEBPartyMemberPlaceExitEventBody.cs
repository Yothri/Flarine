using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMemberPlaceExitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
		}

		public SEBPartyMemberPlaceExitEventBody()
		{
		}

		public int memberId;
	}
}
