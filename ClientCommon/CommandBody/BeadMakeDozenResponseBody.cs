using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BeadMakeDozenResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroBeads);
			writer.Write(this.beadPowder);
			writer.Write(this.NextBeadMakeStepId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroBeads = reader.ReadPDPacketDatas<PDAccountHeroBead>();
			this.beadPowder = reader.ReadInt64();
			this.NextBeadMakeStepId = reader.ReadInt32();
		}

		public BeadMakeDozenResponseBody()
		{
		}

		public PDAccountHeroBead[] accountHeroBeads;

		public long beadPowder;

		public int NextBeadMakeStepId;
	}
}
