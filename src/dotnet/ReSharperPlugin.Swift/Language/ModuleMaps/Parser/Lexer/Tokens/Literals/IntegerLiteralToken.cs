using System;
using System.Numerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Literals;

public class IntegerLiteralToken : LiteralToken
{
    internal IntegerLiteralToken()
        : base(ModuleMapsTokens.IntegerLiteralTokenId, ModuleMapsTokens.IntegerLiteralTokenIndex)
    {
    }

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => ModuleMapsTokens.IntegerLiteralTokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }
}

public class IntegerBackingLiteralToken(
    BigInteger valueOfContents,
    string value,
    IntegerRepresentation representation = IntegerRepresentation.Decimal)
    : TokenLiteralBacker<BigInteger>(valueOfContents, value, ModuleMapsTokens.IntegerLiteralTokenIndex)
{
    public IntegerRepresentation Representation { get; internal set; } = representation;
}

public enum IntegerRepresentation
{
    Decimal,
    Hexadecimal,
    Binary,
    Octal
}
