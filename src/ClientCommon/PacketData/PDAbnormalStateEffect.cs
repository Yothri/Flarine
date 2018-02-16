using System;

namespace ClientCommon.PacketData
{
	public class PDAbnormalStateEffect : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.abnormalStateId);
			writer.Write(this.skillId);
			writer.Write(this.skillLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.abnormalStateId = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
			this.skillLevel = reader.ReadInt32();
		}

		public PDAbnormalStateEffect()
		{
		}

		public long instanceId;

		public int abnormalStateId;

		public int skillId;

		public int skillLevel;
	}
}
