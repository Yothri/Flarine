using System;

namespace ClientCommon.CommandBody
{
	public class UseOwnDiaPocketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.ownDia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.ownDia = reader.ReadInt32();
		}

		public UseOwnDiaPocketResponseBody()
		{
		}

		public DateTime date;

		public int ownDia;
	}
}
