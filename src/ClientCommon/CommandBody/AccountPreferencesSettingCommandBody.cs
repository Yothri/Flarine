using System;

namespace ClientCommon.CommandBody
{
	public class AccountPreferencesSettingCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pushEnabled);
			writer.Write(this.trainingTimePushEnabled);
			writer.Write(this.arenaRankingChangePushEnabled);
			writer.Write(this.receiveMailPushEnabled);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pushEnabled = reader.ReadBoolean();
			this.trainingTimePushEnabled = reader.ReadBoolean();
			this.arenaRankingChangePushEnabled = reader.ReadBoolean();
			this.receiveMailPushEnabled = reader.ReadBoolean();
		}

		public AccountPreferencesSettingCommandBody()
		{
		}

		public bool pushEnabled;

		public bool trainingTimePushEnabled;

		public bool arenaRankingChangePushEnabled;

		public bool receiveMailPushEnabled;
	}
}
