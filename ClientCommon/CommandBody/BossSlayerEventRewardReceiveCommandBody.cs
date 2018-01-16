using System;

namespace ClientCommon.CommandBody
{
	public class BossSlayerEventRewardReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
		}

		public BossSlayerEventRewardReceiveCommandBody()
		{
		}

		public int ranking;
	}
}
