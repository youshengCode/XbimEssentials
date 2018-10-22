// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcVertexPoint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcVertexPoint : IIfcVertex, IfcPointOrVertexPoint
	{
		IIfcPoint @VertexGeometry { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IfcVertexPoint", 521)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexPoint : IfcVertex, IInstantiableEntity, IIfcVertexPoint, IContainsEntityReferences, IEquatable<@IfcVertexPoint>
	{
		#region IIfcVertexPoint explicit implementation
		IIfcPoint IIfcVertexPoint.VertexGeometry { 
 
 
			get { return @VertexGeometry; } 
			set { VertexGeometry = value as IfcPoint;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexPoint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPoint _vertexGeometry;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcPoint @VertexGeometry 
		{ 
			get 
			{
				if(_activated) return _vertexGeometry;
				Activate();
				return _vertexGeometry;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _vertexGeometry = v, _vertexGeometry, value,  "VertexGeometry", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_vertexGeometry = (IfcPoint)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVertexPoint other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@VertexGeometry != null)
					yield return @VertexGeometry;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}