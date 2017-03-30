//
// BaseMetadataVisitor.cs
//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Generated by /CodeGen/cecil-gen.rb do not edit
// Thu Feb 22 14:39:38 CET 2007
//
// (C) 2005 Jb Evain
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace Mono.Cecil.Metadata {

	public abstract class BaseMetadataVisitor : IMetadataVisitor {

		public virtual void VisitMetadataRoot (MetadataRoot root)
		{
		}

		public virtual void VisitMetadataRootHeader (MetadataRoot.MetadataRootHeader header)
		{
		}

		public virtual void VisitMetadataStreamCollection (MetadataStreamCollection streams)
		{
		}

		public virtual void VisitMetadataStream (MetadataStream stream)
		{
		}

		public virtual void VisitMetadataStreamHeader (MetadataStream.MetadataStreamHeader header)
		{
		}

		public virtual void VisitGuidHeap (GuidHeap heap)
		{
		}

		public virtual void VisitStringsHeap (StringsHeap heap)
		{
		}

		public virtual void VisitTablesHeap (TablesHeap heap)
		{
		}

		public virtual void VisitBlobHeap (BlobHeap heap)
		{
		}

		public virtual void VisitUserStringsHeap (UserStringsHeap heap)
		{
		}

		public virtual void TerminateMetadataRoot (MetadataRoot root)
		{
		}
	}

	public abstract class BaseMetadataTableVisitor : IMetadataTableVisitor {

		public virtual void VisitTableCollection (TableCollection coll)
		{
		}

		public virtual void VisitAssemblyTable (AssemblyTable table)
		{
		}

		public virtual void VisitAssemblyOSTable (AssemblyOSTable table)
		{
		}

		public virtual void VisitAssemblyProcessorTable (AssemblyProcessorTable table)
		{
		}

		public virtual void VisitAssemblyRefTable (AssemblyRefTable table)
		{
		}

		public virtual void VisitAssemblyRefOSTable (AssemblyRefOSTable table)
		{
		}

		public virtual void VisitAssemblyRefProcessorTable (AssemblyRefProcessorTable table)
		{
		}

		public virtual void VisitClassLayoutTable (ClassLayoutTable table)
		{
		}

		public virtual void VisitConstantTable (ConstantTable table)
		{
		}

		public virtual void VisitCustomAttributeTable (CustomAttributeTable table)
		{
		}

		public virtual void VisitDeclSecurityTable (DeclSecurityTable table)
		{
		}

		public virtual void VisitEventTable (EventTable table)
		{
		}

		public virtual void VisitEventMapTable (EventMapTable table)
		{
		}

		public virtual void VisitEventPtrTable (EventPtrTable table)
		{
		}

		public virtual void VisitExportedTypeTable (ExportedTypeTable table)
		{
		}

		public virtual void VisitFieldTable (FieldTable table)
		{
		}

		public virtual void VisitFieldLayoutTable (FieldLayoutTable table)
		{
		}

		public virtual void VisitFieldMarshalTable (FieldMarshalTable table)
		{
		}

		public virtual void VisitFieldPtrTable (FieldPtrTable table)
		{
		}

		public virtual void VisitFieldRVATable (FieldRVATable table)
		{
		}

		public virtual void VisitFileTable (FileTable table)
		{
		}

		public virtual void VisitGenericParamTable (GenericParamTable table)
		{
		}

		public virtual void VisitGenericParamConstraintTable (GenericParamConstraintTable table)
		{
		}

		public virtual void VisitImplMapTable (ImplMapTable table)
		{
		}

		public virtual void VisitInterfaceImplTable (InterfaceImplTable table)
		{
		}

		public virtual void VisitManifestResourceTable (ManifestResourceTable table)
		{
		}

		public virtual void VisitMemberRefTable (MemberRefTable table)
		{
		}

		public virtual void VisitMethodTable (MethodTable table)
		{
		}

		public virtual void VisitMethodImplTable (MethodImplTable table)
		{
		}

		public virtual void VisitMethodPtrTable (MethodPtrTable table)
		{
		}

		public virtual void VisitMethodSemanticsTable (MethodSemanticsTable table)
		{
		}

		public virtual void VisitMethodSpecTable (MethodSpecTable table)
		{
		}

		public virtual void VisitModuleTable (ModuleTable table)
		{
		}

		public virtual void VisitModuleRefTable (ModuleRefTable table)
		{
		}

		public virtual void VisitNestedClassTable (NestedClassTable table)
		{
		}

		public virtual void VisitParamTable (ParamTable table)
		{
		}

		public virtual void VisitParamPtrTable (ParamPtrTable table)
		{
		}

		public virtual void VisitPropertyTable (PropertyTable table)
		{
		}

		public virtual void VisitPropertyMapTable (PropertyMapTable table)
		{
		}

		public virtual void VisitPropertyPtrTable (PropertyPtrTable table)
		{
		}

		public virtual void VisitStandAloneSigTable (StandAloneSigTable table)
		{
		}

		public virtual void VisitTypeDefTable (TypeDefTable table)
		{
		}

		public virtual void VisitTypeRefTable (TypeRefTable table)
		{
		}

		public virtual void VisitTypeSpecTable (TypeSpecTable table)
		{
		}

		public virtual void TerminateTableCollection (TableCollection coll)
		{
		}

		public abstract IMetadataRowVisitor GetRowVisitor();
	}

	public abstract class BaseMetadataRowVisitor : IMetadataRowVisitor {

		public virtual void VisitRowCollection (RowCollection coll)
		{
		}

		public virtual void VisitAssemblyRow (AssemblyRow row)
		{
		}

		public virtual void VisitAssemblyOSRow (AssemblyOSRow row)
		{
		}

		public virtual void VisitAssemblyProcessorRow (AssemblyProcessorRow row)
		{
		}

		public virtual void VisitAssemblyRefRow (AssemblyRefRow row)
		{
		}

		public virtual void VisitAssemblyRefOSRow (AssemblyRefOSRow row)
		{
		}

		public virtual void VisitAssemblyRefProcessorRow (AssemblyRefProcessorRow row)
		{
		}

		public virtual void VisitClassLayoutRow (ClassLayoutRow row)
		{
		}

		public virtual void VisitConstantRow (ConstantRow row)
		{
		}

		public virtual void VisitCustomAttributeRow (CustomAttributeRow row)
		{
		}

		public virtual void VisitDeclSecurityRow (DeclSecurityRow row)
		{
		}

		public virtual void VisitEventRow (EventRow row)
		{
		}

		public virtual void VisitEventMapRow (EventMapRow row)
		{
		}

		public virtual void VisitEventPtrRow (EventPtrRow row)
		{
		}

		public virtual void VisitExportedTypeRow (ExportedTypeRow row)
		{
		}

		public virtual void VisitFieldRow (FieldRow row)
		{
		}

		public virtual void VisitFieldLayoutRow (FieldLayoutRow row)
		{
		}

		public virtual void VisitFieldMarshalRow (FieldMarshalRow row)
		{
		}

		public virtual void VisitFieldPtrRow (FieldPtrRow row)
		{
		}

		public virtual void VisitFieldRVARow (FieldRVARow row)
		{
		}

		public virtual void VisitFileRow (FileRow row)
		{
		}

		public virtual void VisitGenericParamRow (GenericParamRow row)
		{
		}

		public virtual void VisitGenericParamConstraintRow (GenericParamConstraintRow row)
		{
		}

		public virtual void VisitImplMapRow (ImplMapRow row)
		{
		}

		public virtual void VisitInterfaceImplRow (InterfaceImplRow row)
		{
		}

		public virtual void VisitManifestResourceRow (ManifestResourceRow row)
		{
		}

		public virtual void VisitMemberRefRow (MemberRefRow row)
		{
		}

		public virtual void VisitMethodRow (MethodRow row)
		{
		}

		public virtual void VisitMethodImplRow (MethodImplRow row)
		{
		}

		public virtual void VisitMethodPtrRow (MethodPtrRow row)
		{
		}

		public virtual void VisitMethodSemanticsRow (MethodSemanticsRow row)
		{
		}

		public virtual void VisitMethodSpecRow (MethodSpecRow row)
		{
		}

		public virtual void VisitModuleRow (ModuleRow row)
		{
		}

		public virtual void VisitModuleRefRow (ModuleRefRow row)
		{
		}

		public virtual void VisitNestedClassRow (NestedClassRow row)
		{
		}

		public virtual void VisitParamRow (ParamRow row)
		{
		}

		public virtual void VisitParamPtrRow (ParamPtrRow row)
		{
		}

		public virtual void VisitPropertyRow (PropertyRow row)
		{
		}

		public virtual void VisitPropertyMapRow (PropertyMapRow row)
		{
		}

		public virtual void VisitPropertyPtrRow (PropertyPtrRow row)
		{
		}

		public virtual void VisitStandAloneSigRow (StandAloneSigRow row)
		{
		}

		public virtual void VisitTypeDefRow (TypeDefRow row)
		{
		}

		public virtual void VisitTypeRefRow (TypeRefRow row)
		{
		}

		public virtual void VisitTypeSpecRow (TypeSpecRow row)
		{
		}

		public virtual void TerminateRowCollection (RowCollection coll)
		{
		}
	}
}
