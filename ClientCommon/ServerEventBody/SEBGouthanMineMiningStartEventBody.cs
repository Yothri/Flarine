using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGouthanMineMiningStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.mineralInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.mineralInstanceId = reader.ReadInt64();
		}

		public SEBGouthanMineMiningStartEventBody()
		{
		}

		public int accountHeroId;

		public long mineralInstanceId;
	}
}
