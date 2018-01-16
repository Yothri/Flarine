using System;

namespace ClientCommon.CommandBody
{
	public class SkyDungeonListCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
		}

		public SkyDungeonListCommandBody()
		{
		}

		public int dungeonId;
	}
}
