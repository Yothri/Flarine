using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyDropObjectAcquiredEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.memberId);
			writer.Write(this.diceNumber);
			writer.Write(this.dropObject);
			writer.Write(this.myDiceNumber);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadInt32();
			this.diceNumber = reader.ReadInt32();
			this.dropObject = reader.ReadPDPacketData<PDPartyAcquiredDropObject>();
			this.myDiceNumber = reader.ReadInt32();
		}

		public SEBPartyDropObjectAcquiredEventBody()
		{
		}

		public int memberId;

		public int diceNumber;

		public PDPartyAcquiredDropObject dropObject;

		public int myDiceNumber;
	}
}
