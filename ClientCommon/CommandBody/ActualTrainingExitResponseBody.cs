using System;

namespace ClientCommon.CommandBody
{
	public class ActualTrainingExitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.continentId);
			writer.Write(this.date);
			writer.Write(this.turn);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
			this.date = reader.ReadDateTime();
			this.turn = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
		}

		public ActualTrainingExitResponseBody()
		{
		}

		public int hp;

		public int continentId;

		public DateTime date;

		public int turn;

		public float remainingTime;
	}
}
