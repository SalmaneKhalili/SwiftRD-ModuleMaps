using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.WhitespaceAndComments;

public abstract class CommentToken(int index) : ModuleMapsTokenNodeType(string.Empty, index)
{
    public override bool IsComment => true;
    
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
