using System;

namespace WebCommon
{
	public class WPDChaoticStep : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chaoticStepId);
			writer.Write(this.requiredPkPoint);
			writer.Write(this.factor);
			writer.Write(this.pkPoint);
			writer.Write(this.punishable);
			writer.Write(this.colorCode);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.chaoticStepId = reader.ReadInt32();
			this.requiredPkPoint = reader.ReadInt32();
			this.factor = reader.ReadDouble();
			this.pkPoint = reader.ReadInt32();
			this.punishable = reader.ReadBoolean();
			this.colorCode = reader.ReadString();
		}

		public WPDChaoticStep()
		{
		}

		public int chaoticStepId;

		public int requiredPkPoint;

		public double factor;

		public int pkPoint;

		public bool punishable;

		public string colorCode;
	}
}
