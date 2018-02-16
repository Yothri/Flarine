using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAchieveAccomplishedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entries);
			writer.Write(this.ownDia);
			writer.Write(this.achievePoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entries = reader.ReadInts();
			this.ownDia = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
		}

		public SEBAchieveAccomplishedEventBody()
		{
		}

		public int[] entries;

		public int ownDia;

		public int achievePoint;
	}
}
