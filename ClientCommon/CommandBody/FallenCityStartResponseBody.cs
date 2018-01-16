using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FallenCityStartResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsters = reader.ReadPDMonsterInstances<PDFallenCityMonsterInstance>();
		}

		public FallenCityStartResponseBody()
		{
		}

		public PDFallenCityMonsterInstance[] monsters;
	}
}
