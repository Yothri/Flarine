using System;

namespace ClientCommon.CommandBody
{
	public class CompleteMainQuestCommandBody : CommandBody
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

		public CompleteMainQuestCommandBody()
		{
		}

		public int mainQuestId;
	}
}
