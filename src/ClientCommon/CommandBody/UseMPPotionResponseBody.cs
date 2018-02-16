using System;

namespace ClientCommon.CommandBody
{
	public class UseMPPotionResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mp = reader.ReadInt32();
		}

		public UseMPPotionResponseBody()
		{
		}

		public int mp;
	}
}
