using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentsToken() : CommentToken(ModuleMapsTokens.BlockCommentsTokenIndex)
{
    public override string TokenRepresentation => ModuleMapsTokens.BlockCommentsTokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        // TODO AST
        throw new NotImplementedException();
    }
}