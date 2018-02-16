using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DiaInstantRevivalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.usedDia);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.revivalInvincibilityRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.usedDia = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.revivalInvincibilityRemainingTime = reader.ReadSingle();
		}

		public DiaInstantRevivalResponseBody()
		{
		}

		public int usedDia;

		public int hp;

		public PDVector3 position;

		public float rotationY;

		public float revivalInvincibilityRemainingTime;
	}
}
