using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBActualTrainingDateChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.turn);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.turn = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
		}

		public SEBActualTrainingDateChangeEventBody()
		{
		}

		public DateTime date;

		public int turn;

		public float remainingTime;
	}
}
