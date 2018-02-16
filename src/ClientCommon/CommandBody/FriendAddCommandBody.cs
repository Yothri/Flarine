using System;

namespace ClientCommon.CommandBody
{
	public class FriendAddCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
		}

		public FriendAddCommandBody()
		{
		}

		public int type;

		public int accountHeroId;
	}
}
