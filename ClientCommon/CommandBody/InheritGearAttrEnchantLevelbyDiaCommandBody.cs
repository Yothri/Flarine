﻿using System;

namespace ClientCommon.CommandBody
{
	public class InheritGearAttrEnchantLevelbyDiaCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.extractionGearId);
			writer.Write(this.inheritGearId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.extractionGearId = reader.ReadGuid();
			this.inheritGearId = reader.ReadGuid();
		}

		public InheritGearAttrEnchantLevelbyDiaCommandBody()
		{
		}

		public Guid extractionGearId;

		public Guid inheritGearId;
	}
}
