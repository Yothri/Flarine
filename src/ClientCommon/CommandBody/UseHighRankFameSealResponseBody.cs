using System;

namespace ClientCommon.CommandBody
{
	public class UseHighRankFameSealResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.famePoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.famePoint = reader.ReadInt32();
		}

		public UseHighRankFameSealResponseBody()
		{
		}

		public DateTime date;

		public int famePoint;
	}
}
