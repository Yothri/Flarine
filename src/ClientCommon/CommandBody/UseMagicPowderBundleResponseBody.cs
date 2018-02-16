using System;

namespace ClientCommon.CommandBody
{
	public class UseMagicPowderBundleResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.magicPowder);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.magicPowder = reader.ReadInt64();
		}

		public UseMagicPowderBundleResponseBody()
		{
		}

		public DateTime date;

		public long magicPowder;
	}
}
