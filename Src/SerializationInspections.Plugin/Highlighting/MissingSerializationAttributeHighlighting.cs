using JetBrains.Annotations;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.Tree;
using SerializationInspections.Plugin.Highlighting;

[assembly: RegisterConfigurableSeverity(
    MissingSerializationAttributeHighlighting.SeverityId,
    null,
    HighlightingGroupIds.CodeSmell,
    MissingSerializationAttributeHighlighting.Title,
    MissingSerializationAttributeHighlighting.Description,
    Severity.WARNING
#if RESHARPER20161 || RESHARPER20162
    , /*SolutionAnalysisRequired:*/ false
#endif
)]

namespace SerializationInspections.Plugin.Highlighting
{
    /// <summary>
    /// A highlighting for missing serialization attributes.
    /// </summary>
    [ConfigurableSeverityHighlighting(SeverityId, "CSHARP", OverlapResolve = OverlapResolveKind.WARNING, ToolTipFormatString = Message)]
    public class MissingSerializationAttributeHighlighting : SerializationHighlightingBase
    {
        public const string SeverityId = "MissingSerializationAttribute";
        public const string Title = "Missing [Serializable] attribute";
        private const string Message = "{0} should be marked with the [Serializable] attribute";
        public const string Description = Title;

        public MissingSerializationAttributeHighlighting([NotNull] ITypeDeclaration typeDeclaration, [NotNull] string elementDescription)
            : base(typeDeclaration, string.Format(Message, elementDescription))
        {
        }
    }
}