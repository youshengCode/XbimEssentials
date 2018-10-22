// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceCurveSweptAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceCurveSweptAreaSolid : IIfcSweptAreaSolid
	{
		IIfcCurve @Directrix { get;  set; }
		IfcParameterValue @StartParam { get;  set; }
		IfcParameterValue @EndParam { get;  set; }
		IIfcSurface @ReferenceSurface { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcSurfaceCurveSweptAreaSolid", 480)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, IIfcSurfaceCurveSweptAreaSolid, IContainsEntityReferences, IEquatable<@IfcSurfaceCurveSweptAreaSolid>
	{
		#region IIfcSurfaceCurveSweptAreaSolid explicit implementation
		IIfcCurve IIfcSurfaceCurveSweptAreaSolid.Directrix { 
 
 
			get { return @Directrix; } 
			set { Directrix = value as IfcCurve;}
		}	
		IfcParameterValue IIfcSurfaceCurveSweptAreaSolid.StartParam { 
 
			get { return @StartParam; } 
			set { StartParam = value;}
		}	
		IfcParameterValue IIfcSurfaceCurveSweptAreaSolid.EndParam { 
 
			get { return @EndParam; } 
			set { EndParam = value;}
		}	
		IIfcSurface IIfcSurfaceCurveSweptAreaSolid.ReferenceSurface { 
 
 
			get { return @ReferenceSurface; } 
			set { ReferenceSurface = value as IfcSurface;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceCurveSweptAreaSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcParameterValue _startParam;
		private IfcParameterValue _endParam;
		private IfcSurface _referenceSurface;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(_activated) return _directrix;
				Activate();
				return _directrix;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcParameterValue @StartParam 
		{ 
			get 
			{
				if(_activated) return _startParam;
				Activate();
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcParameterValue @EndParam 
		{ 
			get 
			{
				if(_activated) return _endParam;
				Activate();
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcSurface @ReferenceSurface 
		{ 
			get 
			{
				if(_activated) return _referenceSurface;
				Activate();
				return _referenceSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referenceSurface = v, _referenceSurface, value,  "ReferenceSurface", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				case 5: 
					_referenceSurface = (IfcSurface)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceCurveSweptAreaSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptArea != null)
					yield return @SweptArea;
				if (@Position != null)
					yield return @Position;
				if (@Directrix != null)
					yield return @Directrix;
				if (@ReferenceSurface != null)
					yield return @ReferenceSurface;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}