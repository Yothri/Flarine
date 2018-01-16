using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FriendRecommendListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.recommendFriends);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.recommendFriends = reader.ReadPDPacketDatas<PDFriendRecommendAccountHero>();
		}

		public FriendRecommendListResponseBody()
		{
		}

		public PDFriendRecommendAccountHero[] recommendFriends;
	}
}
