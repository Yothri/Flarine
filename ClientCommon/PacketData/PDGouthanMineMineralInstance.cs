using System;

namespace ClientCommon.PacketData
{
	public class PDGouthanMineMineralInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.arrangeId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.arrangeId = reader.ReadInt32();
		}

		public PDGouthanMineMineralInstance()
		{
		}

		public long instanceId;

		public int arrangeId;
	}
}
