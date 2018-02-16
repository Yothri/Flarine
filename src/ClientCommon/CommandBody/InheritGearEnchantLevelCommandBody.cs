using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearEnchantLevelCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extractionGearId);
			writer.Write(this.inheritGearId);
			writer.Write(this.ownFirstUse);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extractionGearId = reader.ReadGuid();
			this.inheritGearId = reader.ReadGuid();
			this.ownFirstUse = reader.ReadBoolean();
		}

		public InheritGearEnchantLevelCommandBody()
		{
		}

		public Guid extractionGearId;

		public Guid inheritGearId;

		public bool ownFirstUse;
	}
}
