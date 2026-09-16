using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Literals;

public class StringLiteralToken : LiteralToken
{
    public override string TokenRepresentation => ModuleMapsTokens.FloatingPointLiteralTokenId;
    internal StringLiteralToken()
        : base(ModuleMapsTokens.StringLiteralTokenId, ModuleMapsTokens.StringLiteralTokenIndex)
    {
    }

    public override bool IsStringLiteral => true;

    public override bool IsConstantLiteral => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }
}

public class StringBackingLiteralToken(
    string valueOfContents,
    string value
) : TokenLiteralBacker<string>(valueOfContents, value, ModuleMapsTokens.StringLiteralTokenIndex)
{}

