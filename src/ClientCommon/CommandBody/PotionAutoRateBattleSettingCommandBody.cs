using System;

namespace ClientCommon.CommandBody
{
	public class PotionAutoRateBattleSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hpPotionAutoRate);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hpPotionAutoRate = reader.ReadInt32();
		}

		public PotionAutoRateBattleSettingCommandBody()
		{
		}

		public int hpPotionAutoRate;
	}
}
