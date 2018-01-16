using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBTeamBattlefieldStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.members = reader.ReadPDPacketDatas<PDTeamBattlefieldMember>();
		}

		public SEBTeamBattlefieldStartEventBody()
		{
		}

		public DateTime date;

		public PDTeamBattlefieldMember[] members;
	}
}
