using System;

namespace ClientCommon.CommandBody
{
	public class UsePatternScrollResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.patternId);
			writer.Write(this.patternRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.patternId = reader.ReadInt32();
			this.patternRemainingTime = reader.ReadSingle();
		}

		public UsePatternScrollResponseBody()
		{
		}

		public DateTime date;

		public int patternId;

		public float patternRemainingTime;
	}
}
