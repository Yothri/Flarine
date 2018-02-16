using System;

namespace ClientCommon.CommandBody
{
	public class DisassemblePetCommandBody : CommandBody
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

		public DisassemblePetCommandBody()
		{
		}

		public Guid[] accountHeroPets;
	}
}
