﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Recipes-Databse-Code.HelperClasses
{
	/// <summary>Field Creation Class for entity CategoryEntity</summary>
	public partial class CategoryFields
	{
		/// <summary>Creates a new CategoryEntity.CategoryName field instance</summary>
		public static EntityField2 CategoryName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.CategoryName); }}
		/// <summary>Creates a new CategoryEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.IsActive); }}
	}

	/// <summary>Field Creation Class for entity RecipeEntity</summary>
	public partial class RecipeFields
	{
		/// <summary>Creates a new RecipeEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Id); }}
		/// <summary>Creates a new RecipeEntity.ImagePath field instance</summary>
		public static EntityField2 ImagePath { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.ImagePath); }}
		/// <summary>Creates a new RecipeEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeEntity.Title field instance</summary>
		public static EntityField2 Title { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Title); }}
	}

	/// <summary>Field Creation Class for entity RecipeCategoryEntity</summary>
	public partial class RecipeCategoryFields
	{
		/// <summary>Creates a new RecipeCategoryEntity.Category field instance</summary>
		public static EntityField2 Category { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.Category); }}
		/// <summary>Creates a new RecipeCategoryEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.Id); }}
		/// <summary>Creates a new RecipeCategoryEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeCategoryEntity.RecipeId field instance</summary>
		public static EntityField2 RecipeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.RecipeId); }}
	}

	/// <summary>Field Creation Class for entity RecipeIngredientEntity</summary>
	public partial class RecipeIngredientFields
	{
		/// <summary>Creates a new RecipeIngredientEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeIngredientFieldIndex.Id); }}
		/// <summary>Creates a new RecipeIngredientEntity.Ingredient field instance</summary>
		public static EntityField2 Ingredient { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeIngredientFieldIndex.Ingredient); }}
		/// <summary>Creates a new RecipeIngredientEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeIngredientFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeIngredientEntity.RecipeId field instance</summary>
		public static EntityField2 RecipeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeIngredientFieldIndex.RecipeId); }}
	}

	/// <summary>Field Creation Class for entity RecipeInstructionEntity</summary>
	public partial class RecipeInstructionFields
	{
		/// <summary>Creates a new RecipeInstructionEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeInstructionFieldIndex.Id); }}
		/// <summary>Creates a new RecipeInstructionEntity.Instruction field instance</summary>
		public static EntityField2 Instruction { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeInstructionFieldIndex.Instruction); }}
		/// <summary>Creates a new RecipeInstructionEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeInstructionFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeInstructionEntity.RecipeId field instance</summary>
		public static EntityField2 RecipeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeInstructionFieldIndex.RecipeId); }}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Id); }}
		/// <summary>Creates a new UserEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.IsActive); }}
		/// <summary>Creates a new UserEntity.PasswordHash field instance</summary>
		public static EntityField2 PasswordHash { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.PasswordHash); }}
		/// <summary>Creates a new UserEntity.PasswordSalt field instance</summary>
		public static EntityField2 PasswordSalt { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.PasswordSalt); }}
		/// <summary>Creates a new UserEntity.RefreshToken field instance</summary>
		public static EntityField2 RefreshToken { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.RefreshToken); }}
		/// <summary>Creates a new UserEntity.TokenCreated field instance</summary>
		public static EntityField2 TokenCreated { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.TokenCreated); }}
		/// <summary>Creates a new UserEntity.TokenExpires field instance</summary>
		public static EntityField2 TokenExpires { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.TokenExpires); }}
		/// <summary>Creates a new UserEntity.Username field instance</summary>
		public static EntityField2 Username { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Username); }}
	}
	

}