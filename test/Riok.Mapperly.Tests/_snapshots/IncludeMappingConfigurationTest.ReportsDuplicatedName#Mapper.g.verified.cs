﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public static partial global::B MapOther(global::A a)
    {
        var target = new global::B();
        target.DestinationName1 = a.SourceName1;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public static partial global::BDerived MapOther(global::ADerived a)
    {
        var target = new global::BDerived();
        target.DestinationName2 = a.SourceName2;
        target.DestinationName1 = a.SourceName1;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public static partial global::BDerived Map(global::ADerived a)
    {
        var target = new global::BDerived();
        return target;
    }
}