using System;

namespace ClientCommon.PacketData
{
	public class PDHeroKiller : PDKiller
	{
		public PDHeroKiller() : this(0, null)
		{
		}

		public PDHeroKiller(int nAccountHeroId, string sName)
		{
			this.accountHeroId = nAccountHeroId;
			this.name = sName;
		}

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

		public int accountHeroId;

		public string name;
	}
}
