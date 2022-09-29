﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Recipes-Databse-Code.HelperClasses;
using Recipes-Databse-Code.FactoryClasses;
using Recipes-Databse-Code.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Recipes-Databse-Code.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'RecipeInstruction'.<br/><br/></summary>
	[Serializable]
	public partial class RecipeInstructionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private RecipeEntity _recipe;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static RecipeInstructionEntityStaticMetaData _staticMetaData = new RecipeInstructionEntityStaticMetaData();
		private static RecipeInstructionRelations _relationsFactory = new RecipeInstructionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Recipe</summary>
			public static readonly string Recipe = "Recipe";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RecipeInstructionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RecipeInstructionEntityStaticMetaData()
			{
				SetEntityCoreInfo("RecipeInstructionEntity", InheritanceHierarchyType.None, false, (int)Recipes-Databse-Code.EntityType.RecipeInstructionEntity, typeof(RecipeInstructionEntity), typeof(RecipeInstructionEntityFactory), false);
				AddNavigatorMetaData<RecipeInstructionEntity, RecipeEntity>("Recipe", "RecipeInstructions", (a, b) => a._recipe = b, a => a._recipe, (a, b) => a.Recipe = b, Recipes-Databse-Code.RelationClasses.StaticRecipeInstructionRelations.RecipeEntityUsingRecipeIdStatic, ()=>new RecipeInstructionRelations().RecipeEntityUsingRecipeId, null, new int[] { (int)RecipeInstructionFieldIndex.RecipeId }, null, true, (int)Recipes-Databse-Code.EntityType.RecipeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RecipeInstructionEntity()
		{
		}

		/// <summary> CTor</summary>
		public RecipeInstructionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecipeInstructionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecipeInstructionEntity</param>
		public RecipeInstructionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeInstruction which data should be fetched into this RecipeInstruction object</param>
		public RecipeInstructionEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeInstruction which data should be fetched into this RecipeInstruction object</param>
		/// <param name="validator">The custom validator object for this RecipeInstructionEntity</param>
		public RecipeInstructionEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecipeInstructionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Recipe' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipe() { return CreateRelationInfoForNavigator("Recipe"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RecipeInstructionEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static RecipeInstructionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Recipe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipe { get { return _staticMetaData.GetPrefetchPathElement("Recipe", CommonEntityBase.CreateEntityCollection<RecipeEntity>()); } }

		/// <summary>The Id property of the Entity RecipeInstruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeInstructions"."id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)RecipeInstructionFieldIndex.Id, true); }
			set	{ SetValue((int)RecipeInstructionFieldIndex.Id, value); }
		}

		/// <summary>The Instruction property of the Entity RecipeInstruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeInstructions"."instruction".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 1000.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Instruction
		{
			get { return (System.String)GetValue((int)RecipeInstructionFieldIndex.Instruction, true); }
			set	{ SetValue((int)RecipeInstructionFieldIndex.Instruction, value); }
		}

		/// <summary>The IsActive property of the Entity RecipeInstruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeInstructions"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecipeInstructionFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecipeInstructionFieldIndex.IsActive, value); }
		}

		/// <summary>The RecipeId property of the Entity RecipeInstruction<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeInstructions"."recipe_id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid RecipeId
		{
			get { return (System.Guid)GetValue((int)RecipeInstructionFieldIndex.RecipeId, true); }
			set	{ SetValue((int)RecipeInstructionFieldIndex.RecipeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'RecipeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RecipeEntity Recipe
		{
			get { return _recipe; }
			set { SetSingleRelatedEntityNavigator(value, "Recipe"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace Recipes-Databse-Code
{
	public enum RecipeInstructionFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Instruction. </summary>
		Instruction,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>RecipeId. </summary>
		RecipeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Recipes-Databse-Code.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: RecipeInstruction. </summary>
	public partial class RecipeInstructionRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between RecipeInstructionEntity and RecipeEntity over the m:1 relation they have, using the relation between the fields: RecipeInstruction.RecipeId - Recipe.Id</summary>
		public virtual IEntityRelation RecipeEntityUsingRecipeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Recipe", false, new[] { RecipeFields.Id, RecipeInstructionFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRecipeInstructionRelations
	{
		internal static readonly IEntityRelation RecipeEntityUsingRecipeIdStatic = new RecipeInstructionRelations().RecipeEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticRecipeInstructionRelations() { }
	}
}