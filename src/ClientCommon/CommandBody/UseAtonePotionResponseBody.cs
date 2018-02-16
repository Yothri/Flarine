using System;

namespace ClientCommon.CommandBody
{
	public class UseAtonePotionResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.pkPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.pkPoint = reader.ReadInt32();
		}

		public UseAtonePotionResponseBody()
		{
		}

		public DateTime date;

		public int pkPoint;
	}
}
