using System;
using System.IO;
using System.Text;

namespace ClientCommon
{
	public class BinWriter : BinaryWriter
	{
		public BinWriter()
		{
		}

		public BinWriter(Stream output) : base(output)
		{
		}

		public BinWriter(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public virtual void WriteEnumByte<T>(T value)
		{
			Type type = value.GetType();
			if (!type.IsEnum)
			{
				throw new ArgumentException("형식파라미터 T가 열거형이 아닙니다.");
			}
			this.Write((byte)Convert.ChangeType(value, Enum.GetUnderlyingType(type)));
		}

		public virtual void WriteEnumBytes<T>(T[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (T value in values)
			{
				this.WriteEnumByte<T>(value);
			}
		}

		public virtual void WriteEnumInt<T>(T value)
		{
			Type type = value.GetType();
			if (!type.IsEnum)
			{
				throw new ArgumentException("형식파라미터 T가 열거형이 아닙니다.");
			}
			this.Write((int)Convert.ChangeType(value, Enum.GetUnderlyingType(type)));
		}

		public virtual void WriteEnumInts<T>(T[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (T value in values)
			{
				this.WriteEnumInt<T>(value);
			}
		}

		public override void Write(string value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			base.Write(value);
		}

		public virtual void Write(string[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (string value in values)
			{
				this.Write(value);
			}
		}

		public override void Write(byte[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (byte value in values)
			{
				this.Write(value);
			}
		}

		public virtual void Write(short[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (short value in values)
			{
				this.Write(value);
			}
		}

		public virtual void Write(int[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (int value in values)
			{
				this.Write(value);
			}
		}

		public virtual void Write(long[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (long value in values)
			{
				this.Write(value);
			}
		}

		public virtual void Write(TimeSpan value)
		{
			this.Write(value.Ticks);
		}

		public virtual void Write(TimeSpan? value)
		{
			this.WriteNullableLong((value == null) ? null : new long?(value.Value.Ticks));
		}

		public virtual void Write(DateTime value)
		{
			this.Write(value.ToBinary());
		}

		public virtual void Write(DateTime? value)
		{
			this.WriteNullableLong((value == null) ? null : new long?(value.Value.ToBinary()));
		}

		public virtual void Write(DateTimeOffset value)
		{
			this.Write(value.DateTime);
			this.Write(value.Offset);
		}

		public virtual void Write(DateTimeOffset? value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(value.Value);
		}

		public virtual void Write(Guid value)
		{
			this.Write(value.ToByteArray());
		}

		public virtual void Write(Guid? value)
		{
			this.Write((value == null) ? null : value.Value.ToByteArray());
		}

		public virtual void Write(Guid[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (Guid value in values)
			{
				this.Write(value);
			}
		}

		public virtual void WriteNullableByte(byte? value)
		{
			byte? b = value;
			int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			if (num == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			base.Write(value.Value);
		}

		public virtual void WriteNullableShort(short? value)
		{
			short? num = value;
			int? num2 = (num != null) ? new int?((int)num.GetValueOrDefault()) : null;
			if (num2 == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			base.Write(value.Value);
		}

		public virtual void WriteNullableInt(int? value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			base.Write(value.Value);
		}

		public virtual void WriteNullableLong(long? value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			base.Write(value.Value);
		}
	}
}
