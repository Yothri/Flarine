using System;

namespace WebCommon
{
	public class WPDActualTrainingAdditionalEnter : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.turn);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.turn = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDActualTrainingAdditionalEnter()
		{
		}

		public int turn;

		public int unOwnDia;
	}
}
