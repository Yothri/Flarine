using System;

namespace ClientCommon.CommandBody
{
	public class FriendAddToNameCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public FriendAddToNameCommandBody()
		{
		}

		public int type;

		public string name;
	}
}
