using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class InheritGearRuneResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.success);
			writer.Write(this.extractionGearRunes);
			writer.Write(this.inheritGearRunes);
			writer.Write(this.inheritGearOwned);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.success = reader.ReadBoolean();
			this.extractionGearRunes = reader.ReadPDPacketDatas<PDAccountHeroGearRune>();
			this.inheritGearRunes = reader.ReadPDPacketDatas<PDAccountHeroGearRune>();
			this.inheritGearOwned = reader.ReadBoolean();
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
		}

		public InheritGearRuneResponseBody()
		{
		}

		public bool success;

		public PDAccountHeroGearRune[] extractionGearRunes;

		public PDAccountHeroGearRune[] inheritGearRunes;

		public bool inheritGearOwned;

		public long ownGold;

		public long gold;
	}
}
