using System;

namespace ClientCommon.PacketData
{
	public class PDMonsterDamage : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.damage);
			writer.Write(this.updateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.damage = reader.ReadInt32();
			this.updateTime = reader.ReadDateTime();
		}

		public PDMonsterDamage()
		{
		}

		public int accountHeroId;

		public string name;

		public int damage;

		public DateTime updateTime;
	}
}
