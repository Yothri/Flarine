using System;

namespace ClientCommon.CommandBody
{
	public class GamePreferencesSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInviteRefused);
			writer.Write(this.whisperRefused);
			writer.Write(this.tradeRequestRefused);
			writer.Write(this.dualRequestRefused);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInviteRefused = reader.ReadBoolean();
			this.whisperRefused = reader.ReadBoolean();
			this.tradeRequestRefused = reader.ReadBoolean();
			this.dualRequestRefused = reader.ReadBoolean();
		}

		public GamePreferencesSettingCommandBody()
		{
		}

		public bool partyInviteRefused;

		public bool whisperRefused;

		public bool tradeRequestRefused;

		public bool dualRequestRefused;
	}
}
