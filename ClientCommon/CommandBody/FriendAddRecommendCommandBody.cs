using System;

namespace ClientCommon.CommandBody
{
	public class FriendAddRecommendCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.friendAccountHeroIds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.friendAccountHeroIds = reader.ReadInts();
		}

		public FriendAddRecommendCommandBody()
		{
		}

		public int[] friendAccountHeroIds;
	}
}
