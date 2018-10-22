// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TimeSeriesResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIrregularTimeSeries
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIrregularTimeSeries : IIfcTimeSeries
	{
		IItemSet<IIfcIrregularTimeSeriesValue> @Values { get; }
	
	}
}

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IfcIrregularTimeSeries", 570)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIrregularTimeSeries : IfcTimeSeries, IInstantiableEntity, IIfcIrregularTimeSeries, IContainsEntityReferences, IEquatable<@IfcIrregularTimeSeries>
	{
		#region IIfcIrregularTimeSeries explicit implementation
		IItemSet<IIfcIrregularTimeSeriesValue> IIfcIrregularTimeSeries.Values { 
			get { return new Common.Collections.ProxyItemSet<IfcIrregularTimeSeriesValue, IIfcIrregularTimeSeriesValue>( @Values); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIrregularTimeSeries(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_values = new ItemSet<IfcIrregularTimeSeriesValue>( this, 0,  9);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcIrregularTimeSeriesValue> _values;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 10)]
		public IItemSet<IfcIrregularTimeSeriesValue> @Values 
		{ 
			get 
			{
				if(_activated) return _values;
				Activate();
				return _values;
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_values.InternalAdd((IfcIrregularTimeSeriesValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIrregularTimeSeries other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@StartTime != null)
					yield return @StartTime;
				if (@EndTime != null)
					yield return @EndTime;
				if (@Unit != null)
					yield return @Unit;
				foreach(var entity in @Values)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}