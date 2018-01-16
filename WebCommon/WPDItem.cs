using System;

namespace WebCommon
{
	public class WPDItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.itemType);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.saleable);
			writer.Write(this.sellingPrice);
			writer.Write(this.grade);
			writer.Write(this.cs_requiredHeroLevel);
			writer.Write(this.elemental);
			writer.Write(this.ru_grade);
			writer.Write(this.ru_attrId);
			writer.Write(this.ru_attrValue);
			writer.Write(this.usable);
			writer.Write(this.multipleUsable);
			writer.Write(this.maxQuantity);
			writer.Write(this.value1);
			writer.Write(this.value2);
			writer.Write(this.value3);
			writer.Write(this.autoUseEnabled);
			writer.Write(this.manualUseEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.itemType = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.saleable = reader.ReadBoolean();
			this.sellingPrice = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.cs_requiredHeroLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.ru_grade = reader.ReadInt32();
			this.ru_attrId = reader.ReadInt32();
			this.ru_attrValue = reader.ReadInt32();
			this.usable = reader.ReadBoolean();
			this.multipleUsable = reader.ReadBoolean();
			this.maxQuantity = reader.ReadInt32();
			this.value1 = reader.ReadInt32();
			this.value2 = reader.ReadInt32();
			this.value3 = reader.ReadInt32();
			this.autoUseEnabled = reader.ReadBoolean();
			this.manualUseEnabled = reader.ReadBoolean();
		}

		public WPDItem()
		{
		}

		public int itemId;

		public int itemType;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public bool saleable;

		public int sellingPrice;

		public int grade;

		public int cs_requiredHeroLevel;

		public int elemental;

		public int ru_grade;

		public int ru_attrId;

		public int ru_attrValue;

		public bool usable;

		public bool multipleUsable;

		public int maxQuantity;

		public int value1;

		public int value2;

		public int value3;

		public bool autoUseEnabled;

		public bool manualUseEnabled;
	}
}
