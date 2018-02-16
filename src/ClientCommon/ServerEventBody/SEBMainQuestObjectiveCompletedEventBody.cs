using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMainQuestObjectiveCompletedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
		}

		public SEBMainQuestObjectiveCompletedEventBody()
		{
		}

		public int mainQuestId;
	}
}
