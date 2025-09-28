
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.4084.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly dop_1
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module dop_1.exe
// MVID: {C9EC3513-C94E-4190-9DA6-91EC97286EDC}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06A20000


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

.class private auto ansi beforefieldinit BisectionMethod.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static float64 
          f(float64 x) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (float64 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.0
    IL_0003:  mul
    IL_0004:  ldarg.0
    IL_0005:  mul
    IL_0006:  ldarg.0
    IL_0007:  sub
    IL_0008:  ldc.r8     2.
    IL_0011:  sub
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method Program::f

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       226 (0xe2)
    .maxstack  2
    .locals init (float64 V_0,
             float64 V_1,
             float64 V_2,
             float64 V_3,
             bool V_4,
             bool V_5,
             bool V_6,
             bool V_7)
    IL_0000:  nop
    IL_0001:  ldc.r8     1.
    IL_000a:  stloc.0
    IL_000b:  ldc.r8     2.
    IL_0014:  stloc.1
    IL_0015:  ldc.r8     0.0
    IL_001e:  stloc.2
    IL_001f:  ldc.r8     9.9999999999999995e-07
    IL_0028:  stloc.3
    IL_0029:  ldloc.0
    IL_002a:  call       float64 BisectionMethod.Program::f(float64)
    IL_002f:  ldloc.1
    IL_0030:  call       float64 BisectionMethod.Program::f(float64)
    IL_0035:  mul
    IL_0036:  ldc.r8     0.0
    IL_003f:  clt.un
    IL_0041:  ldc.i4.0
    IL_0042:  ceq
    IL_0044:  stloc.s    V_4
    IL_0046:  ldloc.s    V_4
    IL_0048:  brfalse.s  IL_005b

    IL_004a:  nop
    IL_004b:  ldstr      "f(a) and f(b) have same signs"
    IL_0050:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0055:  nop
    IL_0056:  br         IL_00e1

    IL_005b:  br.s       IL_00aa

    IL_005d:  nop
    IL_005e:  ldloc.0
    IL_005f:  ldloc.1
    IL_0060:  add
    IL_0061:  ldc.r8     2.
    IL_006a:  div
    IL_006b:  stloc.2
    IL_006c:  ldloc.2
    IL_006d:  call       float64 BisectionMethod.Program::f(float64)
    IL_0072:  ldc.r8     0.0
    IL_007b:  ceq
    IL_007d:  stloc.s    V_5
    IL_007f:  ldloc.s    V_5
    IL_0081:  brfalse.s  IL_0085

    IL_0083:  br.s       IL_00b9

    IL_0085:  ldloc.2
    IL_0086:  call       float64 BisectionMethod.Program::f(float64)
    IL_008b:  ldloc.0
    IL_008c:  call       float64 BisectionMethod.Program::f(float64)
    IL_0091:  mul
    IL_0092:  ldc.r8     0.0
    IL_009b:  clt
    IL_009d:  stloc.s    V_6
    IL_009f:  ldloc.s    V_6
    IL_00a1:  brfalse.s  IL_00a7

    IL_00a3:  ldloc.2
    IL_00a4:  stloc.1
    IL_00a5:  br.s       IL_00a9

    IL_00a7:  ldloc.2
    IL_00a8:  stloc.0
    IL_00a9:  nop
    IL_00aa:  ldloc.1
    IL_00ab:  ldloc.0
    IL_00ac:  sub
    IL_00ad:  ldloc.3
    IL_00ae:  clt.un
    IL_00b0:  ldc.i4.0
    IL_00b1:  ceq
    IL_00b3:  stloc.s    V_7
    IL_00b5:  ldloc.s    V_7
    IL_00b7:  brtrue.s   IL_005d

    IL_00b9:  ldstr      "Root: "
    IL_00be:  ldloca.s   V_2
    IL_00c0:  call       instance string [mscorlib]System.Double::ToString()
    IL_00c5:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_00ca:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00cf:  nop
    IL_00d0:  ldstr      "Press <ENTER>"
    IL_00d5:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00da:  nop
    IL_00db:  call       string [mscorlib]System.Console::ReadLine()
    IL_00e0:  pop
    IL_00e1:  ret
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

} // end of class BisectionMethod.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file dop_1.res
