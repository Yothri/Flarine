using System;

namespace ClientCommon.CommandBody
{
	public class BeadEnchantCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.beadId);
			writer.Write(this.materialBeadIds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.beadId = reader.ReadGuid();
			this.materialBeadIds = reader.ReadGuids();
		}

		public BeadEnchantCommandBody()
		{
		}

		public Guid beadId;

		public Guid[] materialBeadIds;
	}
}
