using System;

namespace ClientCommon.CommandBody
{
	public class UseHPPotionResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.restoredHP);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.restoredHP = reader.ReadInt32();
		}

		public UseHPPotionResponseBody()
		{
		}

		public int hp;

		public int restoredHP;
	}
}
