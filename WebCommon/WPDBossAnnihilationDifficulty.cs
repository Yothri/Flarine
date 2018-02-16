using System;

namespace WebCommon
{
	public class WPDBossAnnihilationDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.recommendPower);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.recommendPower = reader.ReadInt32();
		}

		public WPDBossAnnihilationDifficulty()
		{
		}

		public int tradition;

		public int recommendPower;
	}
}
