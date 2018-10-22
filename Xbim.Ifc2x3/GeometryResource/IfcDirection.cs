// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralAnalysisDomain;
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
    /// Readonly interface for IfcDirection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDirection : IIfcGeometricRepresentationItem, IfcOrientationSelect, IfcVectorOrDirection
	{
		IItemSet<double> @DirectionRatios { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcDirection", 344)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDirection : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcDirection, IEquatable<@IfcDirection>
	{
		#region IIfcDirection explicit implementation
		IItemSet<double> IIfcDirection.DirectionRatios { 
			get { return @DirectionRatios; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDirection(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_directionRatios = new ItemSet<double>( this, 3,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<double> _directionRatios;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { 3 }, 3)]
		public IItemSet<double> @DirectionRatios 
		{ 
			get 
			{
				if(_activated) return _directionRatios;
				Activate();
				return _directionRatios;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return DirectionRatios.Count;
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
					_directionRatios.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDirection other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
        /// <summary>
        /// Do not use this conversion operator unless you are absolutely sure you know what you do.
        /// Resulting object is not a properpart of the model and will throw an exception if you
        /// try to modify it or anything. It is only used in IfcGeometricRepresentationSubContext.TrueNorth where
        /// derived attribute is returned in derived overwriting attribute.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static implicit operator IfcDirection(Common.Geometry.XbimVector3D vector)  // explicit byte to digit conversion operator
        {
            var result = new IfcDirection(null, -1, true);
            result._directionRatios.InternalAdd(vector.X);
            result._directionRatios.InternalAdd(vector.Y);
            result._directionRatios.InternalAdd(vector.Z);
            return result;
        }
		//##
		#endregion
	}
}