// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.CostResource;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;
using Xbim.Ifc2x3.ConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMeasureWithUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMeasureWithUnit : IPersistEntity, IfcAppliedValueSelect, IfcConditionCriterionSelect, IfcMetricValueSelect
	{
		IIfcValue @ValueComponent { get;  set; }
		IIfcUnit @UnitComponent { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IfcMeasureWithUnit", 7)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMeasureWithUnit : PersistEntity, IInstantiableEntity, IIfcMeasureWithUnit, IContainsEntityReferences, IEquatable<@IfcMeasureWithUnit>
	{
		#region IIfcMeasureWithUnit explicit implementation
		IIfcValue IIfcMeasureWithUnit.ValueComponent { 
 
 
			get { return @ValueComponent; } 
			set { ValueComponent = value as IfcValue;}
		}	
		IIfcUnit IIfcMeasureWithUnit.UnitComponent { 
 
 
			get { return @UnitComponent; } 
			set { UnitComponent = value as IfcUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMeasureWithUnit(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcValue _valueComponent;
		private IfcUnit _unitComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcValue @ValueComponent 
		{ 
			get 
			{
				if(_activated) return _valueComponent;
				Activate();
				return _valueComponent;
			} 
			set
			{
				SetValue( v =>  _valueComponent = v, _valueComponent, value,  "ValueComponent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcUnit @UnitComponent 
		{ 
			get 
			{
				if(_activated) return _unitComponent;
				Activate();
				return _unitComponent;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unitComponent = v, _unitComponent, value,  "UnitComponent", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_valueComponent = (IfcValue)(value.EntityVal);
					return;
				case 1: 
					_unitComponent = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMeasureWithUnit other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@UnitComponent != null)
					yield return @UnitComponent;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}