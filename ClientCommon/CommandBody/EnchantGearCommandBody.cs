using System;

namespace ClientCommon.CommandBody
{
	public class EnchantGearCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.ownFirstUse);
			writer.Write(this.isProtection);
			writer.Write(this.assistantItemId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadGuid();
			this.ownFirstUse = reader.ReadBoolean();
			this.isProtection = reader.ReadBoolean();
			this.assistantItemId = reader.ReadInt32();
		}

		public EnchantGearCommandBody()
		{
		}

		public Guid accountHeroGearId;

		public bool ownFirstUse;

		public bool isProtection;

		public int assistantItemId;
	}
}
