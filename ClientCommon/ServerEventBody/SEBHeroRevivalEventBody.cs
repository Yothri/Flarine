using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroRevivalEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.revivalInvincibilityRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.revivalInvincibilityRemainingTime = reader.ReadSingle();
		}

		public SEBHeroRevivalEventBody()
		{
		}

		public int accountHeroId;

		public int hp;

		public PDVector3 position;

		public float rotationY;

		public float revivalInvincibilityRemainingTime;
	}
}
