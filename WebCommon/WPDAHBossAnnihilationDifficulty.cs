using System;

namespace WebCommon
{
	public class WPDAHBossAnnihilationDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.damage);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.damage = reader.ReadInt32();
		}

		public WPDAHBossAnnihilationDifficulty()
		{
		}

		public int tradition;

		public int damage;
	}
}
