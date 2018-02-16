using System;

namespace ClientCommon.CommandBody
{
	public class GearRuneEnchantCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.runeId);
			writer.Write(this.ownFirstUse);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadGuid();
			this.runeId = reader.ReadInt32();
			this.ownFirstUse = reader.ReadBoolean();
		}

		public GearRuneEnchantCommandBody()
		{
		}

		public Guid accountHeroGearId;

		public int runeId;

		public bool ownFirstUse;
	}
}
