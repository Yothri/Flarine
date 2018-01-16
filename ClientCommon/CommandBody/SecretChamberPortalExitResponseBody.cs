using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SecretChamberPortalExitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.portals);
			writer.Write(this.members);
			writer.Write(this.monster);
			writer.Write(this.dropObjects);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.portals = reader.ReadPDPacketDatas<PDSecretChamberPortalInstance>();
			this.members = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monster = reader.ReadPDMonsterInstance<PDSecretChamberMonsterInstance>();
			this.dropObjects = reader.ReadPDPacketDatas<PDDropObject>();
		}

		public SecretChamberPortalExitResponseBody()
		{
		}

		public PDVector3 position;

		public float rotationY;

		public PDSecretChamberPortalInstance[] portals;

		public PDAccountHero[] members;

		public PDSecretChamberMonsterInstance monster;

		public PDDropObject[] dropObjects;
	}
}
