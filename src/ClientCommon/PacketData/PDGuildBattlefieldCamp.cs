using System;

namespace ClientCommon.PacketData
{
	public class PDGuildBattlefieldCamp : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadGuid();
			this.name = reader.ReadString();
		}

		public PDGuildBattlefieldCamp()
		{
		}

		public Guid id;

		public string name;
	}
}
