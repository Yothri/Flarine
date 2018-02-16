using System;

namespace ClientCommon.CommandBody
{
	public class UseNormalFPPotionResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.fp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.fp = reader.ReadInt32();
		}

		public UseNormalFPPotionResponseBody()
		{
		}

		public DateTime date;

		public int fp;
	}
}
