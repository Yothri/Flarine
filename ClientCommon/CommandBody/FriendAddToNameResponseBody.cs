using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FriendAddToNameResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.friends);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.friends = reader.ReadPDPacketDatas<PDFriend>();
		}

		public FriendAddToNameResponseBody()
		{
		}

		public PDFriend[] friends;
	}
}
