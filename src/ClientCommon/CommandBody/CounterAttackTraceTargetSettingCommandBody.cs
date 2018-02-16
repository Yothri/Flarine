using System;

namespace ClientCommon.CommandBody
{
	public class CounterAttackTraceTargetSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadInt32();
		}

		public CounterAttackTraceTargetSettingCommandBody()
		{
		}

		public int targetId;
	}
}
