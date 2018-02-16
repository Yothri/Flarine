using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMountFPAutoRecoveryEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fp);
			writer.Write(this.fpAutoRecovryRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fp = reader.ReadInt32();
			this.fpAutoRecovryRemainingTime = reader.ReadSingle();
		}

		public SEBMountFPAutoRecoveryEventBody()
		{
		}

		public int fp;

		public float fpAutoRecovryRemainingTime;
	}
}
