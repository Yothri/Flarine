using System;

namespace ClientCommon.CommandBody
{
	public class ComposeGearCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainGearId);
			writer.Write(this.firstSubGearId);
			writer.Write(this.secondSubGearId);
			writer.Write(this.ownFirstUse);
			writer.Write(this.assistantItemId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mainGearId = reader.ReadGuid();
			this.firstSubGearId = reader.ReadGuid();
			this.secondSubGearId = reader.ReadGuid();
			this.ownFirstUse = reader.ReadBoolean();
			this.assistantItemId = reader.ReadInt32();
		}

		public ComposeGearCommandBody()
		{
		}

		public Guid mainGearId;

		public Guid firstSubGearId;

		public Guid secondSubGearId;

		public bool ownFirstUse;

		public int assistantItemId;
	}
}
