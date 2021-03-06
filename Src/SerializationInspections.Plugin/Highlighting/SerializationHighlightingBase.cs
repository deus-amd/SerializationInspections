using JetBrains.Annotations;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Psi.Tree;
using ReSharperExtensionsShared.Highlighting;

namespace SerializationInspections.Plugin.Highlighting
{
    /// <summary>
    /// A base class for the serialization highlighting types.
    /// </summary>
    public abstract class SerializationHighlightingBase : SimpleTreeNodeHighlightingBase<ITypeDeclaration>
    {
        protected SerializationHighlightingBase([NotNull] ITypeDeclaration treeNode, [NotNull] string toolTipText)
            : base(treeNode, toolTipText)
        {
        }

        public override DocumentRange CalculateRange()
        {
            return TreeNode.GetNameDocumentRange();
        }
    }
}