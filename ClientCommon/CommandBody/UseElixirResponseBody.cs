using System;

namespace ClientCommon.CommandBody
{
	public class UseElixirResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.remainingTime = reader.ReadSingle();
		}

		public UseElixirResponseBody()
		{
		}

		public DateTime date;

		public float remainingTime;
	}
}
