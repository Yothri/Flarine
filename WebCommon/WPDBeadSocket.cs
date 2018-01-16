using System;

namespace WebCommon
{
	public class WPDBeadSocket : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroBeadId);
			writer.Write(this.exp);
			writer.Write(this.level);
			writer.Write(this.beadId);
			writer.Write(this.beadRankId);
			writer.Write(this.socketId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroBeadId = reader.ReadString();
			this.exp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.beadId = reader.ReadInt32();
			this.beadRankId = reader.ReadInt32();
			this.socketId = reader.ReadInt32();
		}

		public WPDBeadSocket()
		{
		}

		public string accountHeroBeadId;

		public int exp;

		public int level;

		public int beadId;

		public int beadRankId;

		public int socketId;
	}
}
