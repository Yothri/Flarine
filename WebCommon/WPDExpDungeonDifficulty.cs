using System;

namespace WebCommon
{
	public class WPDExpDungeonDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.expDungeonId);
			writer.Write(this.tradition);
			writer.Write(this.exp);
			writer.Write(this.recommandPower);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.expDungeonId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.recommandPower = reader.ReadInt32();
		}

		public WPDExpDungeonDifficulty()
		{
		}

		public int expDungeonId;

		public int tradition;

		public int exp;

		public int recommandPower;
	}
}
