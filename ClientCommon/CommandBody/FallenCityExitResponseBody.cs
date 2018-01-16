using System;

namespace ClientCommon.CommandBody
{
	public class FallenCityExitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
		}

		public FallenCityExitResponseBody()
		{
		}

		public int continentId;
	}
}
