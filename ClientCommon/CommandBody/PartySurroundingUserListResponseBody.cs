using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PartySurroundingUserListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.users);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.users = reader.ReadPDPacketDatas<PDAccountHeroSimple>();
		}

		public PartySurroundingUserListResponseBody()
		{
		}

		public PDAccountHeroSimple[] users;
	}
}
