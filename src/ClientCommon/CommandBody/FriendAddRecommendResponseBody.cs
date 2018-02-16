using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FriendAddRecommendResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedFriends);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedFriends = reader.ReadPDPacketDatas<PDFriend>();
		}

		public FriendAddRecommendResponseBody()
		{
		}

		public PDFriend[] addedFriends;
	}
}
