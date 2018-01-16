using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGoldDungeonClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.playTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.playTime = reader.ReadInt32();
		}

		public SEBGoldDungeonClearEventBody()
		{
		}

		public int playTime;
	}
}
