using System;

namespace ClientCommon.CommandBody
{
	public class BeadEnchantResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.exp);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.exp = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public BeadEnchantResponseBody()
		{
		}

		public int exp;

		public int level;
	}
}
