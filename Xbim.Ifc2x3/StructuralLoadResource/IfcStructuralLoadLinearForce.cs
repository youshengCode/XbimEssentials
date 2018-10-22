// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralLoadResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadLinearForce
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadLinearForce : IIfcStructuralLoadStatic
	{
		IfcLinearForceMeasure? @LinearForceX { get;  set; }
		IfcLinearForceMeasure? @LinearForceY { get;  set; }
		IfcLinearForceMeasure? @LinearForceZ { get;  set; }
		IfcLinearMomentMeasure? @LinearMomentX { get;  set; }
		IfcLinearMomentMeasure? @LinearMomentY { get;  set; }
		IfcLinearMomentMeasure? @LinearMomentZ { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IfcStructuralLoadLinearForce", 419)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadLinearForce : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadLinearForce, IEquatable<@IfcStructuralLoadLinearForce>
	{
		#region IIfcStructuralLoadLinearForce explicit implementation
		IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceX { 
 
			get { return @LinearForceX; } 
			set { LinearForceX = value;}
		}	
		IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceY { 
 
			get { return @LinearForceY; } 
			set { LinearForceY = value;}
		}	
		IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceZ { 
 
			get { return @LinearForceZ; } 
			set { LinearForceZ = value;}
		}	
		IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentX { 
 
			get { return @LinearMomentX; } 
			set { LinearMomentX = value;}
		}	
		IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentY { 
 
			get { return @LinearMomentY; } 
			set { LinearMomentY = value;}
		}	
		IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentZ { 
 
			get { return @LinearMomentZ; } 
			set { LinearMomentZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadLinearForce(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLinearForceMeasure? _linearForceX;
		private IfcLinearForceMeasure? _linearForceY;
		private IfcLinearForceMeasure? _linearForceZ;
		private IfcLinearMomentMeasure? _linearMomentX;
		private IfcLinearMomentMeasure? _linearMomentY;
		private IfcLinearMomentMeasure? _linearMomentZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLinearForceMeasure? @LinearForceX 
		{ 
			get 
			{
				if(_activated) return _linearForceX;
				Activate();
				return _linearForceX;
			} 
			set
			{
				SetValue( v =>  _linearForceX = v, _linearForceX, value,  "LinearForceX", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLinearForceMeasure? @LinearForceY 
		{ 
			get 
			{
				if(_activated) return _linearForceY;
				Activate();
				return _linearForceY;
			} 
			set
			{
				SetValue( v =>  _linearForceY = v, _linearForceY, value,  "LinearForceY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLinearForceMeasure? @LinearForceZ 
		{ 
			get 
			{
				if(_activated) return _linearForceZ;
				Activate();
				return _linearForceZ;
			} 
			set
			{
				SetValue( v =>  _linearForceZ = v, _linearForceZ, value,  "LinearForceZ", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLinearMomentMeasure? @LinearMomentX 
		{ 
			get 
			{
				if(_activated) return _linearMomentX;
				Activate();
				return _linearMomentX;
			} 
			set
			{
				SetValue( v =>  _linearMomentX = v, _linearMomentX, value,  "LinearMomentX", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLinearMomentMeasure? @LinearMomentY 
		{ 
			get 
			{
				if(_activated) return _linearMomentY;
				Activate();
				return _linearMomentY;
			} 
			set
			{
				SetValue( v =>  _linearMomentY = v, _linearMomentY, value,  "LinearMomentY", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLinearMomentMeasure? @LinearMomentZ 
		{ 
			get 
			{
				if(_activated) return _linearMomentZ;
				Activate();
				return _linearMomentZ;
			} 
			set
			{
				SetValue( v =>  _linearMomentZ = v, _linearMomentZ, value,  "LinearMomentZ", 7);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_linearForceX = value.RealVal;
					return;
				case 2: 
					_linearForceY = value.RealVal;
					return;
				case 3: 
					_linearForceZ = value.RealVal;
					return;
				case 4: 
					_linearMomentX = value.RealVal;
					return;
				case 5: 
					_linearMomentY = value.RealVal;
					return;
				case 6: 
					_linearMomentZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadLinearForce other)
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