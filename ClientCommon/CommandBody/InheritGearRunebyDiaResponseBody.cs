using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class InheritGearRunebyDiaResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extractionGearRunes);
			writer.Write(this.inheritGearRunes);
			writer.Write(this.inheritGearOwned);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extractionGearRunes = reader.ReadPDPacketDatas<PDAccountHeroGearRune>();
			this.inheritGearRunes = reader.ReadPDPacketDatas<PDAccountHeroGearRune>();
			this.inheritGearOwned = reader.ReadBoolean();
			this.dia = reader.ReadInt32();
		}

		public InheritGearRunebyDiaResponseBody()
		{
		}

		public PDAccountHeroGearRune[] extractionGearRunes;

		public PDAccountHeroGearRune[] inheritGearRunes;

		public bool inheritGearOwned;

		public int dia;
	}
}
