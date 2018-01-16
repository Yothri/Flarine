using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBDungeonKingEventClearCountChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.clearCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.clearCount = reader.ReadInt32();
		}

		public SEBDungeonKingEventClearCountChangedEventBody()
		{
		}

		public int clearCount;
	}
}
