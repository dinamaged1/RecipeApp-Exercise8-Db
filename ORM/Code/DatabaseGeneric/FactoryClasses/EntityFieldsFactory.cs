﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using Recipes-Databse-Code.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Recipes-Databse-Code.FactoryClasses
{
	/// <summary>Generates IEntityFields2 instances for different kind of Entities. For backwards compatibility.</summary>
	public static partial class EntityFieldsFactory
	{
		/// <summary>General factory entrance method which will return an EntityFields2 object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields2 CreateEntityFieldsObject(Recipes-Databse-Code.EntityType relatedEntityType)
		{
			return ModelInfoProviderSingleton.GetInstance().GetEntityFields(relatedEntityType.ToString());
		}


	}
}
