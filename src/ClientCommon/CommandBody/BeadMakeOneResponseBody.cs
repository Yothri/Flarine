using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BeadMakeOneResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroBead);
			writer.Write(this.beadPowder);
			writer.Write(this.NextBeadMakeStepId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroBead = reader.ReadPDPacketData<PDAccountHeroBead>();
			this.beadPowder = reader.ReadInt64();
			this.NextBeadMakeStepId = reader.ReadInt32();
		}

		public BeadMakeOneResponseBody()
		{
		}

		public PDAccountHeroBead accountHeroBead;

		public long beadPowder;

		public int NextBeadMakeStepId;
	}
}
