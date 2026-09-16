using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.WhitespaceAndComments;

public class WhitespaceToken() : ModuleMapsTokenNodeType(string.Empty, ModuleMapsTokens.WhitespaceTokenIndex)
{
    public override string TokenRepresentation => ModuleMapsTokens.WhitespaceTokenId;

    public override bool IsWhitespace => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
