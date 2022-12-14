//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RecipeDto.DtoClasses
{ 
	/// <summary> DTO class which is derived from the entity 'Recipe'.</summary>
	[Serializable]
	[DataContract]
	public partial class RecipeView
	{
		/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'Recipe.Id'</summary>
		[DataMember]
		public System.String Id { get; set; }
		/// <summary>Gets or sets the ImagePath field. Derived from Entity Model Field 'Recipe.ImagePath'</summary>
		[DataMember]
		public System.String ImagePath { get; set; }
		/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'Recipe.IsActive'</summary>
		[DataMember]
		public System.Boolean IsActive { get; set; }
		/// <summary>Gets or sets the RecipeCategories field. </summary>
		[DataMember]
		public List<RecipeViewTypes.RecipeCategory> RecipeCategories { get; set; }
		/// <summary>Gets or sets the RecipeIngredients field. </summary>
		[DataMember]
		public List<RecipeViewTypes.RecipeIngredient> RecipeIngredients { get; set; }
		/// <summary>Gets or sets the RecipeInstructions field. </summary>
		[DataMember]
		public List<RecipeViewTypes.RecipeInstruction> RecipeInstructions { get; set; }
		/// <summary>Gets or sets the Title field. Derived from Entity Model Field 'Recipe.Title'</summary>
		[DataMember]
		public System.String Title { get; set; }
	}

	namespace RecipeViewTypes
	{
		/// <summary> DTO class which is derived from the entity 'RecipeCategory (RecipeCategories)'.</summary>
		[Serializable]
		[DataContract]
		public partial class RecipeCategory
		{
			/// <summary>Gets or sets the Category field. </summary>
			[DataMember]
			public RecipeCategoryTypes.Category Category { get; set; }
			/// <summary>Gets or sets the CategoryId field. Derived from Entity Model Field 'RecipeCategory.CategoryId (FK)'</summary>
			[DataMember]
			public System.String CategoryId { get; set; }
			/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'RecipeCategory.Id'</summary>
			[DataMember]
			public System.String Id { get; set; }
			/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'RecipeCategory.IsActive'</summary>
			[DataMember]
			public System.Boolean IsActive { get; set; }
			/// <summary>Gets or sets the RecipeId field. Derived from Entity Model Field 'RecipeCategory.RecipeId (FK)'</summary>
			[DataMember]
			public System.String RecipeId { get; set; }
		}

		namespace RecipeCategoryTypes
		{
			/// <summary> DTO class which is derived from the entity 'Category (RecipeCategories.Category)'.</summary>
			[Serializable]
			[DataContract]
			public partial class Category
			{
				/// <summary>Gets or sets the CategoryName field. Derived from Entity Model Field 'Category.CategoryName'</summary>
				[DataMember]
				public System.String CategoryName { get; set; }
				/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'Category.Id'</summary>
				[DataMember]
				public System.String Id { get; set; }
				/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'Category.IsActive'</summary>
				[DataMember]
				public System.Boolean IsActive { get; set; }
			}
		}

		/// <summary> DTO class which is derived from the entity 'RecipeIngredient (RecipeIngredients)'.</summary>
		[Serializable]
		[DataContract]
		public partial class RecipeIngredient
		{
			/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'RecipeIngredient.Id'</summary>
			[DataMember]
			public System.String Id { get; set; }
			/// <summary>Gets or sets the Ingredient field. Derived from Entity Model Field 'RecipeIngredient.Ingredient'</summary>
			[DataMember]
			public System.String Ingredient { get; set; }
			/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'RecipeIngredient.IsActive'</summary>
			[DataMember]
			public System.Boolean IsActive { get; set; }
			/// <summary>Gets or sets the RecipeId field. Derived from Entity Model Field 'RecipeIngredient.RecipeId (FK)'</summary>
			[DataMember]
			public System.String RecipeId { get; set; }
		}

		/// <summary> DTO class which is derived from the entity 'RecipeInstruction (RecipeInstructions)'.</summary>
		[Serializable]
		[DataContract]
		public partial class RecipeInstruction
		{
			/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'RecipeInstruction.Id'</summary>
			[DataMember]
			public System.String Id { get; set; }
			/// <summary>Gets or sets the Instruction field. Derived from Entity Model Field 'RecipeInstruction.Instruction'</summary>
			[DataMember]
			public System.String Instruction { get; set; }
			/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'RecipeInstruction.IsActive'</summary>
			[DataMember]
			public System.Boolean IsActive { get; set; }
			/// <summary>Gets or sets the RecipeId field. Derived from Entity Model Field 'RecipeInstruction.RecipeId (FK)'</summary>
			[DataMember]
			public System.String RecipeId { get; set; }
		}
	}

}




