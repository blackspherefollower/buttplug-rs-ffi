// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CreateDevice : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CreateDevice GetRootAsCreateDevice(ByteBuffer _bb) { return GetRootAsCreateDevice(_bb, new CreateDevice()); }
  public static CreateDevice GetRootAsCreateDevice(ByteBuffer _bb, CreateDevice obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CreateDevice __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<ButtplugFFI.CreateDevice> CreateCreateDevice(FlatBufferBuilder builder,
      uint index = 0) {
    builder.StartTable(1);
    CreateDevice.AddIndex(builder, index);
    return CreateDevice.EndCreateDevice(builder);
  }

  public static void StartCreateDevice(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddIndex(FlatBufferBuilder builder, uint index) { builder.AddUint(0, index, 0); }
  public static Offset<ButtplugFFI.CreateDevice> EndCreateDevice(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.CreateDevice>(o);
  }
  public static void FinishCreateDeviceBuffer(FlatBufferBuilder builder, Offset<ButtplugFFI.CreateDevice> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCreateDeviceBuffer(FlatBufferBuilder builder, Offset<ButtplugFFI.CreateDevice> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}