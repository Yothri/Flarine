using System;

namespace WebCommon
{
	public class WPDPetPhase : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.phaseId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.phaseId = reader.ReadInt32();
		}

		public WPDPetPhase()
		{
		}

		public int phaseId;
	}
}
