using System;

namespace ClientCommon.PacketData
{
	public class PDGearReward : PDReward
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
			writer.Write(this.accountHeroGearId);
			writer.Write(this.gearId);
			writer.Write(this.grade);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadNullableGuid();
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
		}

		public PDGearReward()
		{
		}

		public Guid? accountHeroGearId;

		public int gearId;

		public int grade;
	}
}
