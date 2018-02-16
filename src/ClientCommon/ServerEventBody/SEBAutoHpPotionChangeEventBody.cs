using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAutoHpPotionChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hpPotionId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hpPotionId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public SEBAutoHpPotionChangeEventBody()
		{
		}

		public int hpPotionId;

		public int count;
	}
}
