using System;

namespace ClientCommon.CommandBody
{
	public class GearSetGrowthCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.tier);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.tier = reader.ReadInt32();
		}

		public GearSetGrowthCommandBody()
		{
		}

		public int gearId;

		public int tier;
	}
}
