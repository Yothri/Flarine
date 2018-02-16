using System;

namespace ClientCommon.PacketData
{
	public class PDHeroAttacker : PDAttacker
	{
		public override int type
		{
			get
			{
				return 1;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
		}

		public PDHeroAttacker()
		{
		}

		public int accountHeroId;

		public string name;
	}
}
