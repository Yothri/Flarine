using System;

namespace ClientCommon.PacketData
{
	public class PDGoldRanking : PDRanking
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
		}

		public PDGoldRanking()
		{
		}

		public long gold;
	}
}
