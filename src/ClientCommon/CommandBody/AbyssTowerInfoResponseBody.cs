using System;

namespace ClientCommon.CommandBody
{
	public class AbyssTowerInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.topRankingFloor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.topRankingFloor = reader.ReadInt32();
		}

		public AbyssTowerInfoResponseBody()
		{
		}

		public int topRankingFloor;
	}
}
