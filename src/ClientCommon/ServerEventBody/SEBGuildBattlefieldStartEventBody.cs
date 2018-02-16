using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildBattlefieldStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.camps);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.camps = reader.ReadPDPacketDatas<PDGuildBattlefieldCamp>();
			this.members = reader.ReadPDPacketDatas<PDGuildBattlefieldMember>();
		}

		public SEBGuildBattlefieldStartEventBody()
		{
		}

		public DateTime date;

		public PDGuildBattlefieldCamp[] camps;

		public PDGuildBattlefieldMember[] members;
	}
}
