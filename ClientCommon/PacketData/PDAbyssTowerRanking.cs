using System;

namespace ClientCommon.PacketData
{
	public class PDAbyssTowerRanking : PDRanking
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
		}

		public PDAbyssTowerRanking()
		{
		}

		public int floor;
	}
}
