using System;

namespace ClientCommon.CommandBody
{
	public class HpPotionSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.manualHpPotionId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.manualHpPotionId = reader.ReadInt32();
		}

		public HpPotionSettingCommandBody()
		{
		}

		public int manualHpPotionId;
	}
}
