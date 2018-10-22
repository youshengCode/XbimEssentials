// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSweptSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSweptSurface : IIfcSurface
	{
		IIfcProfileDef @SweptCurve { get;  set; }
		IIfcAxis2Placement3D @Position { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcSweptSurface", 110)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSweptSurface : IfcSurface, IIfcSweptSurface, IEquatable<@IfcSweptSurface>
	{
		#region IIfcSweptSurface explicit implementation
		IIfcProfileDef IIfcSweptSurface.SweptCurve { 
 
 
			get { return @SweptCurve; } 
			set { SweptCurve = value as IfcProfileDef;}
		}	
		IIfcAxis2Placement3D IIfcSweptSurface.Position { 
 
 
			get { return @Position; } 
			set { Position = value as IfcAxis2Placement3D;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcProfileDef _sweptCurve;
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcProfileDef @SweptCurve 
		{ 
			get 
			{
				if(_activated) return _sweptCurve;
				Activate();
				return _sweptCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _sweptCurve = v, _sweptCurve, value,  "SweptCurve", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(_activated) return _position;
				Activate();
				return _position;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _position = v, _position, value,  "Position", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return Position.Dim;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sweptCurve = (IfcProfileDef)(value.EntityVal);
					return;
				case 1: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptSurface other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}