// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcResource : IIfcObject, IfcResourceSelect
	{
		IfcIdentifier? @Identification { get;  set; }
		IfcText? @LongDescription { get;  set; }
		IEnumerable<IIfcRelAssignsToResource> @ResourceOf {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcResource", 158)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcResource : IfcObject, IIfcResource, IEquatable<@IfcResource>
	{
		#region IIfcResource explicit implementation
		IfcIdentifier? IIfcResource.Identification { 
 
			get { return @Identification; } 
			set { Identification = value;}
		}	
		IfcText? IIfcResource.LongDescription { 
 
			get { return @LongDescription; } 
			set { LongDescription = value;}
		}	
		 
		IEnumerable<IIfcRelAssignsToResource> IIfcResource.ResourceOf {  get { return @ResourceOf; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResource(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcText? _longDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 17)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(_activated) return _identification;
				Activate();
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 18)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(_activated) return _longDescription;
				Activate();
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingResource")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 19)]
		public IEnumerable<IfcRelAssignsToResource> @ResourceOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToResource>(e => Equals(e.RelatingResource), "RelatingResource", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_identification = value.StringVal;
					return;
				case 6: 
					_longDescription = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResource other)
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