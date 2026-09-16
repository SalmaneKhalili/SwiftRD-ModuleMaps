using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Punctuators;

public abstract class PunctuatorToken(string punctuator, string tokenId, int index)
    : ModuleMapsTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation => punctuator;


    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        // TODO supposed to return an AST Node.
        throw new System.NotImplementedException();
    }
}