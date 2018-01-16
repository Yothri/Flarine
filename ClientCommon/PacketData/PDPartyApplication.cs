using System;

namespace ClientCommon.PacketData
{
	public class PDPartyApplication : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.accountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt64();
			this.accountHero = reader.ReadPDPacketData<PDAccountHeroSimple>();
		}

		public PDPartyApplication()
		{
		}

		public long id;

		public PDAccountHeroSimple accountHero;
	}
}
