using System;

namespace WebCommon
{
	public class WPDBeadMakeStep : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.stepId);
			writer.Write(this.make1xBeadPowder);
			writer.Write(this.make10xBeadPowder);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.stepId = reader.ReadInt32();
			this.make1xBeadPowder = reader.ReadInt32();
			this.make10xBeadPowder = reader.ReadInt32();
		}

		public WPDBeadMakeStep()
		{
		}

		public int stepId;

		public int make1xBeadPowder;

		public int make10xBeadPowder;
	}
}
