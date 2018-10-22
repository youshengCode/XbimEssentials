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
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefines
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefines : IIfcRelationship
	{
		IItemSet<IIfcObject> @RelatedObjects { get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcRelDefines", 207)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelDefines : IfcRelationship, IIfcRelDefines, IEquatable<@IfcRelDefines>
	{
		#region IIfcRelDefines explicit implementation
		IItemSet<IIfcObject> IIfcRelDefines.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObject, IIfcObject>( @RelatedObjects); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefines(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedObjects = new ItemSet<IfcObject>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcObject> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<IfcObject> @RelatedObjects 
		{ 
			get 
			{
				if(_activated) return _relatedObjects;
				Activate();
				return _relatedObjects;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedObjects.InternalAdd((IfcObject)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDefines other)
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