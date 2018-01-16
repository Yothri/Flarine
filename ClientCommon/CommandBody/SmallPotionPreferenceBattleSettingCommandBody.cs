using System;

namespace ClientCommon.CommandBody
{
	public class SmallPotionPreferenceBattleSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.smallPotionPrefered);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.smallPotionPrefered = reader.ReadBoolean();
		}

		public SmallPotionPreferenceBattleSettingCommandBody()
		{
		}

		public bool smallPotionPrefered;
	}
}
