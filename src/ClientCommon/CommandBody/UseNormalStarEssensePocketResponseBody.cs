using System;

namespace ClientCommon.CommandBody
{
	public class UseNormalStarEssensePocketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.starEssense);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.starEssense = reader.ReadInt64();
		}

		public UseNormalStarEssensePocketResponseBody()
		{
		}

		public DateTime date;

		public long starEssense;
	}
}
