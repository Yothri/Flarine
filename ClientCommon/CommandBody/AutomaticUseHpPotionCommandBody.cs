using System;

namespace ClientCommon.CommandBody
{
	public class AutomaticUseHpPotionCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isAutomaticUseHpPotion);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isAutomaticUseHpPotion = reader.ReadBoolean();
		}

		public AutomaticUseHpPotionCommandBody()
		{
		}

		public bool isAutomaticUseHpPotion;
	}
}
