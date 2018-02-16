using System;

namespace ClientCommon.PacketData
{
	public class PDJobBattlefieldCamp : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
		}

		public PDJobBattlefieldCamp()
		{
		}

		public int id;
	}
}
