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
	/// <summary>Entity class which represents the entity 'RecipeCategory'.<br/><br/></summary>
	[Serializable]
	public partial class RecipeCategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CategoryEntity _category;
		private RecipeEntity _recipe;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static RecipeCategoryEntityStaticMetaData _staticMetaData = new RecipeCategoryEntityStaticMetaData();
		private static RecipeCategoryRelations _relationsFactory = new RecipeCategoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Category</summary>
			public static readonly string Category = "Category";
			/// <summary>Member name Recipe</summary>
			public static readonly string Recipe = "Recipe";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RecipeCategoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RecipeCategoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("RecipeCategoryEntity", InheritanceHierarchyType.None, false, (int)RecipeDB.EntityType.RecipeCategoryEntity, typeof(RecipeCategoryEntity), typeof(RecipeCategoryEntityFactory), false);
				AddNavigatorMetaData<RecipeCategoryEntity, CategoryEntity>("Category", "RecipeCategories", (a, b) => a._category = b, a => a._category, (a, b) => a.Category = b, RecipeDB.RelationClasses.StaticRecipeCategoryRelations.CategoryEntityUsingCategoryIdStatic, ()=>new RecipeCategoryRelations().CategoryEntityUsingCategoryId, null, new int[] { (int)RecipeCategoryFieldIndex.CategoryId }, null, true, (int)RecipeDB.EntityType.CategoryEntity);
				AddNavigatorMetaData<RecipeCategoryEntity, RecipeEntity>("Recipe", "RecipeCategories", (a, b) => a._recipe = b, a => a._recipe, (a, b) => a.Recipe = b, RecipeDB.RelationClasses.StaticRecipeCategoryRelations.RecipeEntityUsingRecipeIdStatic, ()=>new RecipeCategoryRelations().RecipeEntityUsingRecipeId, null, new int[] { (int)RecipeCategoryFieldIndex.RecipeId }, null, true, (int)RecipeDB.EntityType.RecipeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RecipeCategoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public RecipeCategoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecipeCategoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecipeCategoryEntity</param>
		public RecipeCategoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeCategory which data should be fetched into this RecipeCategory object</param>
		public RecipeCategoryEntity(System.String id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeCategory which data should be fetched into this RecipeCategory object</param>
		/// <param name="validator">The custom validator object for this RecipeCategoryEntity</param>
		public RecipeCategoryEntity(System.String id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecipeCategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Category' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory() { return CreateRelationInfoForNavigator("Category"); }

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
		/// <param name="validator">The validator object for this RecipeCategoryEntity</param>
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
		public static RecipeCategoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory { get { return _staticMetaData.GetPrefetchPathElement("Category", CommonEntityBase.CreateEntityCollection<CategoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Recipe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipe { get { return _staticMetaData.GetPrefetchPathElement("Recipe", CommonEntityBase.CreateEntityCollection<RecipeEntity>()); } }

		/// <summary>The CategoryId property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategories"."category_id".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CategoryId
		{
			get { return (System.String)GetValue((int)RecipeCategoryFieldIndex.CategoryId, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.CategoryId, value); }
		}

		/// <summary>The Id property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategories"."id".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Id
		{
			get { return (System.String)GetValue((int)RecipeCategoryFieldIndex.Id, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.Id, value); }
		}

		/// <summary>The IsActive property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategories"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecipeCategoryFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.IsActive, value); }
		}

		/// <summary>The RecipeId property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategories"."recipe_id".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String RecipeId
		{
			get { return (System.String)GetValue((int)RecipeCategoryFieldIndex.RecipeId, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.RecipeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'CategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CategoryEntity Category
		{
			get { return _category; }
			set { SetSingleRelatedEntityNavigator(value, "Category"); }
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

namespace RecipeDB
{
	public enum RecipeCategoryFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>RecipeId. </summary>
		RecipeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace RecipeDB.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: RecipeCategory. </summary>
	public partial class RecipeCategoryRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between RecipeCategoryEntity and CategoryEntity over the m:1 relation they have, using the relation between the fields: RecipeCategory.CategoryId - Category.Id</summary>
		public virtual IEntityRelation CategoryEntityUsingCategoryId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Category", false, new[] { CategoryFields.Id, RecipeCategoryFields.CategoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between RecipeCategoryEntity and RecipeEntity over the m:1 relation they have, using the relation between the fields: RecipeCategory.RecipeId - Recipe.Id</summary>
		public virtual IEntityRelation RecipeEntityUsingRecipeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Recipe", false, new[] { RecipeFields.Id, RecipeCategoryFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRecipeCategoryRelations
	{
		internal static readonly IEntityRelation CategoryEntityUsingCategoryIdStatic = new RecipeCategoryRelations().CategoryEntityUsingCategoryId;
		internal static readonly IEntityRelation RecipeEntityUsingRecipeIdStatic = new RecipeCategoryRelations().RecipeEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticRecipeCategoryRelations() { }
	}
}
