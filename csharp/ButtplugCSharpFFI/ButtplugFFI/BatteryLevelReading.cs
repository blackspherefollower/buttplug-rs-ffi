// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BatteryLevelReading : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BatteryLevelReading GetRootAsBatteryLevelReading(ByteBuffer _bb) { return GetRootAsBatteryLevelReading(_bb, new BatteryLevelReading()); }
  public static BatteryLevelReading GetRootAsBatteryLevelReading(ByteBuffer _bb, BatteryLevelReading obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BatteryLevelReading __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartBatteryLevelReading(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<ButtplugFFI.BatteryLevelReading> EndBatteryLevelReading(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.BatteryLevelReading>(o);
  }
};


}
