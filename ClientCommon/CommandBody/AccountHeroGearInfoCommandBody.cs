using System;

namespace ClientCommon.CommandBody
{
	public class AccountHeroGearInfoCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.accountHeroGearId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.accountHeroGearId = reader.ReadGuid();
		}

		public AccountHeroGearInfoCommandBody()
		{
		}

		public int accountHeroId;

		public Guid accountHeroGearId;
	}
}
