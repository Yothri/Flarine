using System;
using System.IO;
using System.Text;

namespace WebCommon
{
	public class WBinReader : BinaryReader
	{
		public WBinReader(Stream output) : base(output)
		{
		}

		public WBinReader(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public virtual T ReadEnumByte<T>()
		{
			return (T)((object)Enum.ToObject(typeof(T), this.ReadByte()));
		}

		public virtual T[] ReadEnumBytes<T>()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadEnumByte<T>();
			}
			return array;
		}

		public virtual T ReadEnumInt<T>()
		{
			return (T)((object)Enum.ToObject(typeof(T), this.ReadInt32()));
		}

		public virtual T[] ReadEnumInts<T>()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadEnumInt<T>();
			}
			return array;
		}

		public override string ReadString()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return base.ReadString();
		}

		public virtual string[] ReadStrings()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadString();
			}
			return array;
		}

		public virtual byte[] ReadBytes()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return this.ReadBytes(this.ReadInt32());
		}

		public virtual short[] ReadShorts()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			short[] array = new short[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt16();
			}
			return array;
		}

		public virtual int[] ReadInts()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt32();
			}
			return array;
		}

		public virtual long[] ReadLongs()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			long[] array = new long[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt64();
			}
			return array;
		}

		public virtual TimeSpan ReadTimeSpan()
		{
			return TimeSpan.FromTicks(this.ReadInt64());
		}

		public virtual TimeSpan? ReadNullableTimeSpan()
		{
			long? num = this.ReadNullableLong();
			if (num != null)
			{
				return new TimeSpan?(TimeSpan.FromTicks(num.Value));
			}
			return null;
		}

		public virtual DateTime ReadDateTime()
		{
			return DateTime.FromBinary(this.ReadInt64());
		}

		public virtual DateTime? ReadNullableDateTime()
		{
			long? num = this.ReadNullableLong();
			if (num != null)
			{
				return new DateTime?(DateTime.FromBinary(num.Value));
			}
			return null;
		}

		public virtual DateTimeOffset ReadDateTimeOffset()
		{
			return new DateTimeOffset(this.ReadDateTime(), this.ReadTimeSpan());
		}

		public virtual DateTimeOffset? ReadNullableDateTimeOffset()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return new DateTimeOffset?(this.ReadDateTimeOffset());
		}

		public virtual Guid ReadGuid()
		{
			return new Guid(this.ReadBytes());
		}

		public virtual Guid? ReadNullableGuid()
		{
			byte[] array = this.ReadBytes();
			if (array != null)
			{
				return new Guid?(new Guid(array));
			}
			return null;
		}

		public virtual Guid[] ReadGuids()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			Guid[] array = new Guid[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadGuid();
			}
			return array;
		}

		public virtual byte? ReadNullableByte()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return new byte?(base.ReadByte());
		}

		public virtual short? ReadNullableShort()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return new short?(base.ReadInt16());
		}

		public virtual int? ReadNullableInt()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return new int?(base.ReadInt32());
		}

		public virtual long? ReadNullableLong()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return new long?(base.ReadInt64());
		}
	}
}
