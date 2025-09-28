
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.4084.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly k_r
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module k_r.exe
// MVID: {241F11E9-0FBD-4247-A04C-84FBF5F310C2}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x05870000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit kv_r.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       228 (0xe4)
    .maxstack  3
    .locals init (float64 V_0,
             float64 V_1,
             float64 V_2,
             float64 V_3,
             float64 V_4,
             float64 V_5,
             bool V_6,
             bool V_7)
    IL_0000:  nop
    IL_0001:  ldc.r8     2.
    IL_000a:  stloc.0
    IL_000b:  ldc.r8     -5.
    IL_0014:  stloc.1
    IL_0015:  ldc.r8     3.
    IL_001e:  stloc.2
    IL_001f:  ldloc.1
    IL_0020:  ldloc.1
    IL_0021:  mul
    IL_0022:  ldc.r8     4.
    IL_002b:  ldloc.0
    IL_002c:  mul
    IL_002d:  ldloc.2
    IL_002e:  mul
    IL_002f:  sub
    IL_0030:  stloc.3
    IL_0031:  ldloc.3
    IL_0032:  ldc.r8     0.0
    IL_003b:  clt
    IL_003d:  stloc.s    V_6
    IL_003f:  ldloc.s    V_6
    IL_0041:  brfalse.s  IL_0055

    IL_0043:  nop
    IL_0044:  ldstr      "No real answers!!!"
    IL_0049:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_004e:  nop
    IL_004f:  nop
    IL_0050:  br         IL_00d8

    IL_0055:  nop
    IL_0056:  ldloc.3
    IL_0057:  ldc.r8     0.0
    IL_0060:  ceq
    IL_0062:  stloc.s    V_7
    IL_0064:  ldloc.s    V_7
    IL_0066:  brfalse.s  IL_008e

    IL_0068:  nop
    IL_0069:  ldloc.1
    IL_006a:  neg
    IL_006b:  ldc.r8     2.
    IL_0074:  ldloc.0
    IL_0075:  mul
    IL_0076:  div
    IL_0077:  stloc.s    V_4
    IL_0079:  ldstr      "\n X1={0} "
    IL_007e:  ldloc.s    V_4
    IL_0080:  box        [mscorlib]System.Double
    IL_0085:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_008a:  nop
    IL_008b:  nop
    IL_008c:  br.s       IL_00d7

    IL_008e:  nop
    IL_008f:  ldloc.1
    IL_0090:  neg
    IL_0091:  ldloc.3
    IL_0092:  call       float64 [mscorlib]System.Math::Sqrt(float64)
    IL_0097:  add
    IL_0098:  ldc.r8     2.
    IL_00a1:  ldloc.0
    IL_00a2:  mul
    IL_00a3:  div
    IL_00a4:  stloc.s    V_4
    IL_00a6:  ldloc.1
    IL_00a7:  neg
    IL_00a8:  ldloc.3
    IL_00a9:  call       float64 [mscorlib]System.Math::Sqrt(float64)
    IL_00ae:  sub
    IL_00af:  ldc.r8     2.
    IL_00b8:  ldloc.0
    IL_00b9:  mul
    IL_00ba:  div
    IL_00bb:  stloc.s    V_5
    IL_00bd:  ldstr      "\n X1={0} X2= {1}"
    IL_00c2:  ldloc.s    V_4
    IL_00c4:  box        [mscorlib]System.Double
    IL_00c9:  ldloc.s    V_5
    IL_00cb:  box        [mscorlib]System.Double
    IL_00d0:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object,
                                                                  object)
    IL_00d5:  nop
    IL_00d6:  nop
    IL_00d7:  nop
    IL_00d8:  ldstr      "\n Press <ENTER> "
    IL_00dd:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00e2:  nop
    IL_00e3:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class kv_r.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file k_r.res
