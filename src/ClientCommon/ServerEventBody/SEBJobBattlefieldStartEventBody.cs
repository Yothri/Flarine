using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBJobBattlefieldStartEventBody : SEBServerEventBody
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
			this.camps = reader.ReadPDPacketDatas<PDJobBattlefieldCamp>();
			this.members = reader.ReadPDPacketDatas<PDJobBattlefieldMember>();
		}

		public SEBJobBattlefieldStartEventBody()
		{
		}

		public DateTime date;

		public PDJobBattlefieldCamp[] camps;

		public PDJobBattlefieldMember[] members;
	}
}
