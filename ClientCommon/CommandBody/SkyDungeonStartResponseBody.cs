using System;

namespace ClientCommon.CommandBody
{
	public class SkyDungeonStartResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fp = reader.ReadInt32();
		}

		public SkyDungeonStartResponseBody()
		{
		}

		public int fp;
	}
}
