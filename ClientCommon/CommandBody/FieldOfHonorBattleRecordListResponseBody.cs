using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorBattleRecordListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.records);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.records = reader.ReadPDPacketDatas<PDFieldOfHonorBattleRecord>();
		}

		public FieldOfHonorBattleRecordListResponseBody()
		{
		}

		public PDFieldOfHonorBattleRecord[] records;
	}
}
