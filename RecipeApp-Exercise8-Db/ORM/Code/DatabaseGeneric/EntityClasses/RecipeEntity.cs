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
using RecipeDB.HelperClasses;
using RecipeDB.FactoryClasses;
using RecipeDB.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RecipeDB.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Recipe'.<br/><br/></summary>
	[Serializable]
	public partial class RecipeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<RecipeCategoryEntity> _recipeCategories;
		private EntityCollection<RecipeIngredientEntity> _recipeIngredients;
		private EntityCollection<RecipeInstructionEntity> _recipeInstructions;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static RecipeEntityStaticMetaData _staticMetaData = new RecipeEntityStaticMetaData();
		private static RecipeRelations _relationsFactory = new RecipeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name RecipeCategories</summary>
			public static readonly string RecipeCategories = "RecipeCategories";
			/// <summary>Member name RecipeIngredients</summary>
			public static readonly string RecipeIngredients = "RecipeIngredients";
			/// <summary>Member name RecipeInstructions</summary>
			public static readonly string RecipeInstructions = "RecipeInstructions";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RecipeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RecipeEntityStaticMetaData()
			{
				SetEntityCoreInfo("RecipeEntity", InheritanceHierarchyType.None, false, (int)RecipeDB.EntityType.RecipeEntity, typeof(RecipeEntity), typeof(RecipeEntityFactory), false);
				AddNavigatorMetaData<RecipeEntity, EntityCollection<RecipeCategoryEntity>>("RecipeCategories", a => a._recipeCategories, (a, b) => a._recipeCategories = b, a => a.RecipeCategories, () => new RecipeRelations().RecipeCategoryEntityUsingRecipeId, typeof(RecipeCategoryEntity), (int)RecipeDB.EntityType.RecipeCategoryEntity);
				AddNavigatorMetaData<RecipeEntity, EntityCollection<RecipeIngredientEntity>>("RecipeIngredients", a => a._recipeIngredients, (a, b) => a._recipeIngredients = b, a => a.RecipeIngredients, () => new RecipeRelations().RecipeIngredientEntityUsingRecipeId, typeof(RecipeIngredientEntity), (int)RecipeDB.EntityType.RecipeIngredientEntity);
				AddNavigatorMetaData<RecipeEntity, EntityCollection<RecipeInstructionEntity>>("RecipeInstructions", a => a._recipeInstructions, (a, b) => a._recipeInstructions = b, a => a.RecipeInstructions, () => new RecipeRelations().RecipeInstructionEntityUsingRecipeId, typeof(RecipeInstructionEntity), (int)RecipeDB.EntityType.RecipeInstructionEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RecipeEntity()
		{
		}

		/// <summary> CTor</summary>
		public RecipeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecipeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecipeEntity</param>
		public RecipeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Recipe which data should be fetched into this Recipe object</param>
		public RecipeEntity(System.String id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Recipe which data should be fetched into this Recipe object</param>
		/// <param name="validator">The custom validator object for this RecipeEntity</param>
		public RecipeEntity(System.String id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecipeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RecipeCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipeCategories() { return CreateRelationInfoForNavigator("RecipeCategories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RecipeIngredient' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipeIngredients() { return CreateRelationInfoForNavigator("RecipeIngredients"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RecipeInstruction' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipeInstructions() { return CreateRelationInfoForNavigator("RecipeInstructions"); }
		
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
		/// <param name="validator">The validator object for this RecipeEntity</param>
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
		public static RecipeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecipeCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipeCategories { get { return _staticMetaData.GetPrefetchPathElement("RecipeCategories", CommonEntityBase.CreateEntityCollection<RecipeCategoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecipeIngredient' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipeIngredients { get { return _staticMetaData.GetPrefetchPathElement("RecipeIngredients", CommonEntityBase.CreateEntityCollection<RecipeIngredientEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecipeInstruction' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipeInstructions { get { return _staticMetaData.GetPrefetchPathElement("RecipeInstructions", CommonEntityBase.CreateEntityCollection<RecipeInstructionEntity>()); } }

		/// <summary>The Id property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."id".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Id
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.Id, true); }
			set	{ SetValue((int)RecipeFieldIndex.Id, value); }
		}

		/// <summary>The ImagePath property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."image_path".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ImagePath
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.ImagePath, true); }
			set	{ SetValue((int)RecipeFieldIndex.ImagePath, value); }
		}

		/// <summary>The IsActive property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecipeFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecipeFieldIndex.IsActive, value); }
		}

		/// <summary>The Title property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."title".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.Title, true); }
			set	{ SetValue((int)RecipeFieldIndex.Title, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'RecipeCategoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RecipeCategoryEntity))]
		public virtual EntityCollection<RecipeCategoryEntity> RecipeCategories { get { return GetOrCreateEntityCollection<RecipeCategoryEntity, RecipeCategoryEntityFactory>("Recipe", true, false, ref _recipeCategories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RecipeIngredientEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RecipeIngredientEntity))]
		public virtual EntityCollection<RecipeIngredientEntity> RecipeIngredients { get { return GetOrCreateEntityCollection<RecipeIngredientEntity, RecipeIngredientEntityFactory>("Recipe", true, false, ref _recipeIngredients); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RecipeInstructionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RecipeInstructionEntity))]
		public virtual EntityCollection<RecipeInstructionEntity> RecipeInstructions { get { return GetOrCreateEntityCollection<RecipeInstructionEntity, RecipeInstructionEntityFactory>("Recipe", true, false, ref _recipeInstructions); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace RecipeDB
{
	public enum RecipeFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ImagePath. </summary>
		ImagePath,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace RecipeDB.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Recipe. </summary>
	public partial class RecipeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between RecipeEntity and RecipeCategoryEntity over the 1:n relation they have, using the relation between the fields: Recipe.Id - RecipeCategory.RecipeId</summary>
		public virtual IEntityRelation RecipeCategoryEntityUsingRecipeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "RecipeCategories", true, new[] { RecipeFields.Id, RecipeCategoryFields.RecipeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between RecipeEntity and RecipeIngredientEntity over the 1:n relation they have, using the relation between the fields: Recipe.Id - RecipeIngredient.RecipeId</summary>
		public virtual IEntityRelation RecipeIngredientEntityUsingRecipeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "RecipeIngredients", true, new[] { RecipeFields.Id, RecipeIngredientFields.RecipeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between RecipeEntity and RecipeInstructionEntity over the 1:n relation they have, using the relation between the fields: Recipe.Id - RecipeInstruction.RecipeId</summary>
		public virtual IEntityRelation RecipeInstructionEntityUsingRecipeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "RecipeInstructions", true, new[] { RecipeFields.Id, RecipeInstructionFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRecipeRelations
	{
		internal static readonly IEntityRelation RecipeCategoryEntityUsingRecipeIdStatic = new RecipeRelations().RecipeCategoryEntityUsingRecipeId;
		internal static readonly IEntityRelation RecipeIngredientEntityUsingRecipeIdStatic = new RecipeRelations().RecipeIngredientEntityUsingRecipeId;
		internal static readonly IEntityRelation RecipeInstructionEntityUsingRecipeIdStatic = new RecipeRelations().RecipeInstructionEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticRecipeRelations() { }
	}
}
