// This is a generated file. Do not modify it directly.
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Tes.Buffers.Converters
{
  /// <summary>
  /// Interface for converting from <c>IList</c> wrapped in a <c><see cref="DataBuffer"/></c>.
  /// </summary>
  /// <remarks>
  /// The interface consists of a series of <c>Get&lt;Type&gt;()</c> and <c>GetRange()</c> functions.
  /// As this the converter operates with the internals of a <c><see cref="DataBuffer"/></c>, the supported source
  /// list arguments will generally be simple types, or of known types with data channels. See
  /// <see cref="DataBuffer"/> for details on how index and count arguments are treated.
  /// </remarks>
  internal interface BufferConverter
  {
    /// <summary>
    /// Query the supported buffer type. This is the type contained in the <c>IList</c>.
    /// </summary>
    Type Type { get; }

    /// <summary>
    /// Query the default packing data type.
    /// </summary>
    Tes.Net.DataStreamType DefaultPackingType { get; }

    /// <summary>
    /// Query the number of addressable elements in the array. This includes addressing individual data components.
    /// </summary>
    int AddressableCount(IList list);

    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>sbyte</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<sbyte> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>sbyte</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(sbyte[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>sbyte</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    sbyte GetSByte(IList src, int srcOffset);
    /// <summary>
    /// Read a range of SByte values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of SByte items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of SByte items to read for each <paramref name="count"/></param>
    int ReadSByte(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>byte</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<byte> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>byte</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(byte[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>byte</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    byte GetByte(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Byte values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Byte items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Byte items to read for each <paramref name="count"/></param>
    int ReadByte(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>short</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<short> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>short</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(short[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>short</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    short GetInt16(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Int16 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Int16 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Int16 items to read for each <paramref name="count"/></param>
    int ReadInt16(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>ushort</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<ushort> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>ushort</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(ushort[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>ushort</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    ushort GetUInt16(IList src, int srcOffset);
    /// <summary>
    /// Read a range of UInt16 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of UInt16 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of UInt16 items to read for each <paramref name="count"/></param>
    int ReadUInt16(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>int</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<int> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>int</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(int[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>int</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    int GetInt32(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Int32 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Int32 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Int32 items to read for each <paramref name="count"/></param>
    int ReadInt32(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>uint</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<uint> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>uint</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(uint[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>uint</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    uint GetUInt32(IList src, int srcOffset);
    /// <summary>
    /// Read a range of UInt32 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of UInt32 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of UInt32 items to read for each <paramref name="count"/></param>
    int ReadUInt32(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>long</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<long> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>long</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(long[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>long</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    long GetInt64(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Int64 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Int64 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Int64 items to read for each <paramref name="count"/></param>
    int ReadInt64(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>ulong</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<ulong> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>ulong</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(ulong[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>ulong</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    ulong GetUInt64(IList src, int srcOffset);
    /// <summary>
    /// Read a range of UInt64 values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of UInt64 items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of UInt64 items to read for each <paramref name="count"/></param>
    int ReadUInt64(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>float</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<float> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>float</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(float[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>float</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    float GetSingle(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Single values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Single items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Single items to read for each <paramref name="count"/></param>
    int ReadSingle(IList dst, BinaryReader reader, int offset, int count, int componentCount);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>double</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(List<double> dst, IList src, int srcOffset, int count);
    /// <summary>
    /// Extract <paramref name="count"/> values of type <c>double</c> from <paramref name="src"/>.
    /// </summary>
    /// <param name="dst">The list to add values to using <c>IList.Add()</c>.</param>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to start reading at.</param>
    /// <param name="count">The number of items to read into <paramref name="dst"/>.</param>
    void GetRange(double[] dst, IList src, int srcOffset, int count);

    /// <summary>
    /// Read a single <c>double</c> value from <paramref name="src"/>.
    /// </summary>
    /// <param name="src">The source container to read from.</param>
    /// <param name="srcOffset">The index offset into <paramref name="source"/> to read from.</param>
    /// <return>The value at the requested offset.</return>
    double GetDouble(IList src, int srcOffset);
    /// <summary>
    /// Read a range of Double values from a <c>System.IO.BinaryReader</c>.
    /// </summary>
    /// <param name="dst">The list to read into. The stored type must match the implementation type.</param>
    /// <param name="reader">The binary reader from which to read data.</param>
    /// <param name="offset">The offset into dst at which to start writing. This offset is element based, so must be
    /// multiplied by the <paramref name="componentCount"/>.</param>
    /// <param name="count">The number of elements to read. Must be multiplied by the <paramref name="componentCount"/>
    ///   to calculate the total number of Double items to read from <paramref name="reader"/>.</param>
    /// <param name="componentCount">The number of Double items to read for each <paramref name="count"/></param>
    int ReadDouble(IList dst, BinaryReader reader, int offset, int count, int componentCount);
  }
}
