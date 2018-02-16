using System;

namespace ClientCommon.CommandBody
{
	public class DisassemblePetDiaCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroPets);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroPets = reader.ReadGuids();
		}

		public DisassemblePetDiaCommandBody()
		{
		}

		public Guid[] accountHeroPets;
	}
}
