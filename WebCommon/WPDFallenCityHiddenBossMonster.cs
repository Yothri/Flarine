using System;

namespace WebCommon
{
	public class WPDFallenCityHiddenBossMonster : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.arrangeId);
			writer.Write(this.monsterId);
			writer.Write(this.requiredMonsterId);
			writer.Write(this.requiredMonsterCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.arrangeId = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.requiredMonsterId = reader.ReadInt32();
			this.requiredMonsterCount = reader.ReadInt32();
		}

		public WPDFallenCityHiddenBossMonster()
		{
		}

		public int arrangeId;

		public int monsterId;

		public int requiredMonsterId;

		public int requiredMonsterCount;
	}
}
