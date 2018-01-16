using System;

namespace ClientCommon.CommandBody
{
	public class GearAttributeEnchantCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.ownFirstUse);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadGuid();
			this.ownFirstUse = reader.ReadBoolean();
		}

		public GearAttributeEnchantCommandBody()
		{
		}

		public Guid accountHeroGearId;

		public bool ownFirstUse;
	}
}
