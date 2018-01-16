using System;
using System.IO;
using System.Text;

namespace ClientCommon
{
	public class BinReader : BinaryReader
	{
		public BinReader(Stream output) : base(output)
		{
		}

		public BinReader(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public virtual T ReadEnumByte<T>()
		{
			return (T)((object)Enum.ToObject(typeof(T), this.ReadByte()));
		}

		public virtual T[] ReadEnumBytes<T>(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadEnumByte<T>();
			}
			return array;
		}

		public virtual T[] ReadEnumBytes<T>()
		{
			return this.ReadEnumBytes<T>(32767);
		}

		public virtual T ReadEnumInt<T>()
		{
			return (T)((object)Enum.ToObject(typeof(T), this.ReadInt32()));
		}

		public virtual T[] ReadEnumInts<T>(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadEnumInt<T>();
			}
			return array;
		}

		public virtual T[] ReadEnumInts<T>()
		{
			return this.ReadEnumInts<T>(32767);
		}

		public override string ReadString()
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			return base.ReadString();
		}

		public virtual string[] ReadStrings(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadString();
			}
			return array;
		}

		public virtual string[] ReadStrings()
		{
			return this.ReadStrings(32767);
		}

		public override byte[] ReadBytes(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			return base.ReadBytes(num);
		}

		public virtual byte[] ReadBytes()
		{
			return this.ReadBytes(32767);
		}

		public virtual short[] ReadShorts(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			short[] array = new short[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt16();
			}
			return array;
		}

		public virtual short[] ReadShorts()
		{
			return this.ReadShorts(32767);
		}

		public virtual int[] ReadInts(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt32();
			}
			return array;
		}

		public virtual int[] ReadInts()
		{
			return this.ReadInts(32767);
		}

		public virtual long[] ReadLongs(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			long[] array = new long[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadInt64();
			}
			return array;
		}

		public virtual long[] ReadLongs()
		{
			return this.ReadLongs(32767);
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

		public virtual Guid[] ReadGuids(int nMaxLength)
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			Guid[] array = new Guid[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadGuid();
			}
			return array;
		}

		public virtual Guid[] ReadGuids()
		{
			return this.ReadGuids(32767);
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
