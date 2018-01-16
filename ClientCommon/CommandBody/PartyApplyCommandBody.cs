using System;

namespace ClientCommon.CommandBody
{
	public class PartyApplyCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
		}

		public PartyApplyCommandBody()
		{
		}

		public long instanceId;
	}
}
