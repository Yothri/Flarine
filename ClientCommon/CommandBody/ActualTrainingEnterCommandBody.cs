using System;

namespace ClientCommon.CommandBody
{
	public class ActualTrainingEnterCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.turn);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.turn = reader.ReadInt32();
		}

		public ActualTrainingEnterCommandBody()
		{
		}

		public int turn;
	}
}
