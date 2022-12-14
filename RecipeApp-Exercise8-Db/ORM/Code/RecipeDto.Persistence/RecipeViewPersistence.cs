//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.QuerySpec;
using RecipeDB.HelperClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace RecipeDto.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of RecipeDto.DtoClasses.RecipeView from the entity model.</summary>
	public static partial class RecipeViewPersistence
	{
		private static readonly System.Linq.Expressions.Expression<Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView> _compiledProjector = CreateProjectionFunc().Compile();
		/// <summary>Linq specific partial method for obtaining projection adjustments for the projection method <see cref="ProjectToRecipeView(System.Linq.IQueryable{RecipeDB.EntityClasses.RecipeEntity})"/></summary>
		/// <param name="projectionAdjustments">Set this argument in an implementation of this partial method to a projection lambda similar to the generated projection in <see cref="CreateProjectionFunc"/></param>
		/// <remarks>Linq specific</remarks>
		static partial void GetAdjustmentsForProjectToRecipeView(ref System.Linq.Expressions.Expression<Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView>> projectionAdjustments);
		/// <summary>QuerySpec specific partial method for obtaining projection adjustments for the projection method <see cref="ProjectToRecipeView(EntityQuery{RecipeDB.EntityClasses.RecipeEntity}, RecipeDB.FactoryClasses.QueryFactory)"/></summary>
		/// <param name="projectionAdjustments">Set this argument in an implementation of this partial method to a projection lambda similar to the generated projection in <see cref="ProjectToRecipeView(EntityQuery{RecipeDB.EntityClasses.RecipeEntity}, RecipeDB.FactoryClasses.QueryFactory)"/></param>
		/// <remarks>QuerySpec specific</remarks>
		static partial void GetAdjustmentsForProjectToRecipeViewQs(ref System.Linq.Expressions.Expression<Func<RecipeDto.DtoClasses.RecipeView>> projectionAdjustments);
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static RecipeViewPersistence() { }
	
		/// <summary>Extension method which produces a projection to RecipeDto.DtoClasses.RecipeView which instances are projected from the 
		/// results of the specified baseQuery, which returns RecipeDB.EntityClasses.RecipeEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve RecipeDto.DtoClasses.RecipeView instances</returns>
		public static IQueryable<RecipeDto.DtoClasses.RecipeView> ProjectToRecipeView(this IQueryable<RecipeDB.EntityClasses.RecipeEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}

		/// <summary>Extension method which produces a projection to RecipeDto.DtoClasses.RecipeView which instances are projected from the 
		/// results of the specified baseQuery using QuerySpec, which returns RecipeDB.EntityClasses.RecipeEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <param name="qf">The query factory used to create baseQuery.</param>
		/// <returns>DynamicQuery to retrieve RecipeDto.DtoClasses.RecipeView instances</returns>
		public static DynamicQuery<RecipeDto.DtoClasses.RecipeView> ProjectToRecipeView(this EntityQuery<RecipeDB.EntityClasses.RecipeEntity> baseQuery, RecipeDB.FactoryClasses.QueryFactory qf)
		{
			System.Linq.Expressions.Expression<Func<RecipeDto.DtoClasses.RecipeView>> projectionAdjustments = null;
			GetAdjustmentsForProjectToRecipeViewQs(ref projectionAdjustments);
			return qf.Create()
				.From(baseQuery.Select(Projection.Full).As("__BQ"))
				.Select(LinqUtils.MergeProjectionAdjustmentsIntoProjection(() => new RecipeDto.DtoClasses.RecipeView()
				{
					Id = RecipeFields.Id.Source("__BQ").ToValue<System.String>(),
					ImagePath = RecipeFields.ImagePath.Source("__BQ").ToValue<System.String>(),
					IsActive = RecipeFields.IsActive.Source("__BQ").ToValue<System.Boolean>(),
					RecipeCategories = (List<RecipeDto.DtoClasses.RecipeViewTypes.RecipeCategory>)qf.RecipeCategory.TargetAs("__L1_0")
						.CorrelatedOver(RecipeFields.Id.Source("__BQ").Equal(RecipeCategoryFields.RecipeId.Source("__L1_0")))
						.From(QueryTarget
							.InnerJoin(qf.Category.As("__L1_1")).On(RecipeCategoryFields.CategoryId.Source("__L1_0").Equal(CategoryFields.Id.Source("__L1_1"))))
						.Select(() => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeCategory()
						{
							Category = new RecipeDto.DtoClasses.RecipeViewTypes.RecipeCategoryTypes.Category()
								{
									CategoryName = CategoryFields.CategoryName.Source("__L1_1").ToValue<System.String>(),
									Id = CategoryFields.Id.As("Id1").Source("__L1_1").ToValue<System.String>(),
									IsActive = CategoryFields.IsActive.As("IsActive1").Source("__L1_1").ToValue<System.Boolean>(),
								},
							CategoryId = RecipeCategoryFields.CategoryId.Source("__L1_0").ToValue<System.String>(),
							Id = RecipeCategoryFields.Id.Source("__L1_0").ToValue<System.String>(),
							IsActive = RecipeCategoryFields.IsActive.Source("__L1_0").ToValue<System.Boolean>(),
							RecipeId = RecipeCategoryFields.RecipeId.Source("__L1_0").ToValue<System.String>(),
						}).ToResultset(),
					RecipeIngredients = (List<RecipeDto.DtoClasses.RecipeViewTypes.RecipeIngredient>)qf.RecipeIngredient.TargetAs("__L1_0")
						.CorrelatedOver(RecipeFields.Id.Source("__BQ").Equal(RecipeIngredientFields.RecipeId.Source("__L1_0")))
						.Select(() => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeIngredient()
						{
							Id = RecipeIngredientFields.Id.Source("__L1_0").ToValue<System.String>(),
							Ingredient = RecipeIngredientFields.Ingredient.Source("__L1_0").ToValue<System.String>(),
							IsActive = RecipeIngredientFields.IsActive.Source("__L1_0").ToValue<System.Boolean>(),
							RecipeId = RecipeIngredientFields.RecipeId.Source("__L1_0").ToValue<System.String>(),
						}).ToResultset(),
					RecipeInstructions = (List<RecipeDto.DtoClasses.RecipeViewTypes.RecipeInstruction>)qf.RecipeInstruction.TargetAs("__L1_0")
						.CorrelatedOver(RecipeFields.Id.Source("__BQ").Equal(RecipeInstructionFields.RecipeId.Source("__L1_0")))
						.Select(() => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeInstruction()
						{
							Id = RecipeInstructionFields.Id.Source("__L1_0").ToValue<System.String>(),
							Instruction = RecipeInstructionFields.Instruction.Source("__L1_0").ToValue<System.String>(),
							IsActive = RecipeInstructionFields.IsActive.Source("__L1_0").ToValue<System.Boolean>(),
							RecipeId = RecipeInstructionFields.RecipeId.Source("__L1_0").ToValue<System.String>(),
						}).ToResultset(),
					Title = RecipeFields.Title.Source("__BQ").ToValue<System.String>(),
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegionQS_RecipeView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
				}, projectionAdjustments, false));
		}

		/// <summary>Extension method which produces a projection to RecipeDto.DtoClasses.RecipeView which instances are projected from the
		/// RecipeDB.EntityClasses.RecipeEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>RecipeDB.EntityClasses.RecipeEntity instance created from the specified entity instance</returns>
		public static RecipeDto.DtoClasses.RecipeView ProjectToRecipeView(this RecipeDB.EntityClasses.RecipeEntity entity)
		{
			return _compiledProjector(entity);
		}
		
		private static System.Linq.Expressions.Expression<Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView>> CreateProjectionFunc()
		{
			System.Linq.Expressions.Expression<Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView>> mainProjection = p__0 => new RecipeDto.DtoClasses.RecipeView()
			{
				Id = p__0.Id,
				ImagePath = p__0.ImagePath,
				IsActive = p__0.IsActive,
				RecipeCategories = p__0.RecipeCategories.Select(p__1 => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeCategory()
				{
					Category = new RecipeDto.DtoClasses.RecipeViewTypes.RecipeCategoryTypes.Category()
					{
						CategoryName = p__1.Category.CategoryName,
						Id = p__1.Category.Id,
						IsActive = p__1.Category.IsActive,
					},
					CategoryId = p__1.CategoryId,
					Id = p__1.Id,
					IsActive = p__1.IsActive,
					RecipeId = p__1.RecipeId,
				}).ToList(),
				RecipeIngredients = p__0.RecipeIngredients.Select(p__1 => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeIngredient()
				{
					Id = p__1.Id,
					Ingredient = p__1.Ingredient,
					IsActive = p__1.IsActive,
					RecipeId = p__1.RecipeId,
				}).ToList(),
				RecipeInstructions = p__0.RecipeInstructions.Select(p__1 => new RecipeDto.DtoClasses.RecipeViewTypes.RecipeInstruction()
				{
					Id = p__1.Id,
					Instruction = p__1.Instruction,
					IsActive = p__1.IsActive,
					RecipeId = p__1.RecipeId,
				}).ToList(),
				Title = p__0.Title,
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegion_RecipeView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			};
			System.Linq.Expressions.Expression<Func<RecipeDB.EntityClasses.RecipeEntity, RecipeDto.DtoClasses.RecipeView>> projectionAdjustments = null;
			GetAdjustmentsForProjectToRecipeView(ref projectionAdjustments);
			return LinqUtils.MergeProjectionAdjustmentsIntoProjection(mainProjection, projectionAdjustments, true);
		}
	}
}


