using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SkyDungeonEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredBattlePower);
			writer.Write(this.autoStart);
			writer.Write(this.myAccountHero);
			writer.Write(this.masterId);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredBattlePower = reader.ReadInt32();
			this.autoStart = reader.ReadBoolean();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.masterId = reader.ReadInt32();
			this.members = reader.ReadPDPacketDatas<PDAccountHero>();
		}

		public SkyDungeonEnterResponseBody()
		{
		}

		public int requiredBattlePower;

		public bool autoStart;

		public PDAccountHero myAccountHero;

		public int masterId;

		public PDAccountHero[] members;
	}
}
