using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBArenaWinnerChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.winnerId);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.winnerId = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public SEBArenaWinnerChangeEventBody()
		{
		}

		public int winnerId;

		public string name;
	}
}
