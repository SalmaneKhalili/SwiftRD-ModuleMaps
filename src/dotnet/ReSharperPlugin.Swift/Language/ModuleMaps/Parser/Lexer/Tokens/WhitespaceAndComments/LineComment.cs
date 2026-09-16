using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.WhitespaceAndComments;

public class LineCommentToken() : CommentToken(ModuleMapsTokens.LineCommentsTokenIndex)
{
    public override string TokenRepresentation => ModuleMapsTokens.LineCommentsTokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
