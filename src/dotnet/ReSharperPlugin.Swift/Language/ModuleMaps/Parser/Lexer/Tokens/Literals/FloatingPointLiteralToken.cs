using ExtendedNumerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Literals;

public class FloatingPointLiteralToken
    : LiteralToken
{
    internal FloatingPointLiteralToken()
        : base(ModuleMapsTokens.FloatingPointLiteralTokenId, ModuleMapsTokens.FloatingPointLiteralTokenIndex)
    {
    }

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => ModuleMapsTokens.FloatingPointLiteralTokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class FloatingPointLiteralTokenBaker(
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal) :
    TokenLiteralBacker<BigDecimal>(valueOfContents, value, ModuleMapsTokens.FloatingPointLiteralTokenIndex)
{
    public FloatingPointRepresentation Representation { get; internal set; } = representation;
}

public enum FloatingPointRepresentation
{
    Decimal,
    Hexadecimal
}
