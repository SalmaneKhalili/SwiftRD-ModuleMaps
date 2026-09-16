using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;


public class ModuleMapsNodeTypeIndexer : NodeTypesRegistry
{
    public static readonly  ModuleMapsNodeTypeIndexer Instance = new();

    private ModuleMapsNodeTypeIndexer()
    {
        
    }
}