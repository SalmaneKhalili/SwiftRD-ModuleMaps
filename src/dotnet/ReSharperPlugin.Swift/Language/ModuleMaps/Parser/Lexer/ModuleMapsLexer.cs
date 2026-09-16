using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer;

public class ModuleMapsLexer : IIncrementalLexer
{
    
    public ModuleMapsLexer(IBuffer buffer) : this(buffer, buffer.Length)
    {
        
    }

    public ModuleMapsLexer(IBuffer buffer, int eofPos)
    {
        
    }
    
    
    
}