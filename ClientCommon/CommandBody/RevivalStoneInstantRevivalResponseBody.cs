using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class RevivalStoneInstantRevivalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.revivalInvincibilityRemainingTime);
			writer.Write(this.changedInventorySlot);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.revivalInvincibilityRemainingTime = reader.ReadSingle();
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
		}

		public RevivalStoneInstantRevivalResponseBody()
		{
		}

		public int hp;

		public PDVector3 position;

		public float rotationY;

		public float revivalInvincibilityRemainingTime;

		public PDInventorySlot changedInventorySlot;
	}
}
