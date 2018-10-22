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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieProject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieProject : IPersistEntity
	{
		string @Name { get;  set; }
		string @Description { get;  set; }
		ICobieExternalObject @ExternalObject { get;  set; }
		string @ExternalId { get;  set; }
		string @AltExternalId { get;  set; }
		IEnumerable<ICobiePhase> @Phases {  get; }
		IEnumerable<ICobieFacility> @Facilities {  get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Project", 15)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieProject : PersistEntity, IInstantiableEntity, ICobieProject, IContainsEntityReferences, IEquatable<@CobieProject>
	{
		#region ICobieProject explicit implementation
		string ICobieProject.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		string ICobieProject.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		ICobieExternalObject ICobieProject.ExternalObject { 
 
 
			get { return @ExternalObject; } 
			set { ExternalObject = value as CobieExternalObject;}
		}	
		string ICobieProject.ExternalId { 
 
			get { return @ExternalId; } 
			set { ExternalId = value;}
		}	
		string ICobieProject.AltExternalId { 
 
			get { return @AltExternalId; } 
			set { AltExternalId = value;}
		}	
		 
		IEnumerable<ICobiePhase> ICobieProject.Phases {  get { return @Phases; } }
		IEnumerable<ICobieFacility> ICobieProject.Facilities {  get { return @Facilities; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieProject(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieExternalObject _externalObject;
		private string _externalId;
		private string _altExternalId;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public string @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public string @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public CobieExternalObject @ExternalObject 
		{ 
			get 
			{
				if(_activated) return _externalObject;
				Activate();
				return _externalObject;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _externalObject = v, _externalObject, value,  "ExternalObject", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public string @ExternalId 
		{ 
			get 
			{
				if(_activated) return _externalId;
				Activate();
				return _externalId;
			} 
			set
			{
				SetValue( v =>  _externalId = v, _externalId, value,  "ExternalId", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public string @AltExternalId 
		{ 
			get 
			{
				if(_activated) return _altExternalId;
				Activate();
				return _altExternalId;
			} 
			set
			{
				SetValue( v =>  _altExternalId = v, _altExternalId, value,  "AltExternalId", 5);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Project")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { -1 }, new int [] { -1 }, 6)]
		public IEnumerable<CobiePhase> @Phases 
		{ 
			get 
			{
				return Model.Instances.Where<CobiePhase>(e => Equals(e.Project), "Project", this);
			} 
		}
		[InverseProperty("Project")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { -1 }, new int [] { -1 }, 7)]
		public IEnumerable<CobieFacility> @Facilities 
		{ 
			get 
			{
				return Model.Instances.Where<CobieFacility>(e => Equals(e.Project), "Project", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_externalObject = (CobieExternalObject)(value.EntityVal);
					return;
				case 3: 
					_externalId = value.StringVal;
					return;
				case 4: 
					_altExternalId = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieProject other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ExternalObject != null)
					yield return @ExternalObject;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}