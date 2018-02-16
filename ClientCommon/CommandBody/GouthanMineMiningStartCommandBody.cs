using System;

namespace ClientCommon.CommandBody
{
	public class GouthanMineMiningStartCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mineralInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mineralInstanceId = reader.ReadInt64();
		}

		public GouthanMineMiningStartCommandBody()
		{
		}

		public long mineralInstanceId;
	}
}
