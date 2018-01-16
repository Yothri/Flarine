using System;

namespace ClientCommon.CommandBody
{
	public class BeadArrangeInventoryResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroBeadIds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroBeadIds = reader.ReadGuids();
		}

		public BeadArrangeInventoryResponseBody()
		{
		}

		public Guid[] accountHeroBeadIds;
	}
}
