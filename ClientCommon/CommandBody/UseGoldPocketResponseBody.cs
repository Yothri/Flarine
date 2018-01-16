using System;

namespace ClientCommon.CommandBody
{
	public class UseGoldPocketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.ownGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.ownGold = reader.ReadInt64();
		}

		public UseGoldPocketResponseBody()
		{
		}

		public DateTime date;

		public long ownGold;
	}
}
