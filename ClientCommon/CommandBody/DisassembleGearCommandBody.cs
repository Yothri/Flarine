using System;

namespace ClientCommon.CommandBody
{
	public class DisassembleGearCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGears = reader.ReadGuids();
		}

		public DisassembleGearCommandBody()
		{
		}

		public Guid[] accountHeroGears;
	}
}
