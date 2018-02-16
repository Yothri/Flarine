using System;

namespace ClientCommon.PacketData
{
	public class PDLevelRanking : PDRanking
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadInt32();
		}

		public PDLevelRanking()
		{
		}

		public int level;
	}
}
