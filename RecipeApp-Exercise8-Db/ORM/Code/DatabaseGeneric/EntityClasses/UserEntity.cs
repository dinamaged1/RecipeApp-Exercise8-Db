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

	/// <summary>Entity class which represents the entity 'User'.<br/><br/></summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static UserEntityStaticMetaData _staticMetaData = new UserEntityStaticMetaData();
		private static UserRelations _relationsFactory = new UserRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UserEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UserEntityStaticMetaData()
			{
				SetEntityCoreInfo("UserEntity", InheritanceHierarchyType.None, false, (int)RecipeDB.EntityType.UserEntity, typeof(UserEntity), typeof(UserEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static UserEntity()
		{
		}

		/// <summary> CTor</summary>
		public UserEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.String id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.String id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
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
		/// <param name="validator">The validator object for this UserEntity</param>
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
		public static UserRelations Relations { get { return _relationsFactory; } }

		/// <summary>The Id property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."id".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Id
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Id, true); }
			set	{ SetValue((int)UserFieldIndex.Id, value); }
		}

		/// <summary>The IsActive property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserFieldIndex.IsActive, value); }
		}

		/// <summary>The PasswordHash property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."password_hash".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)UserFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)UserFieldIndex.PasswordHash, value); }
		}

		/// <summary>The PasswordSalt property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."password_salt".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)UserFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)UserFieldIndex.PasswordSalt, value); }
		}

		/// <summary>The RefreshToken property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."refresh_token".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RefreshToken
		{
			get { return (System.String)GetValue((int)UserFieldIndex.RefreshToken, true); }
			set	{ SetValue((int)UserFieldIndex.RefreshToken, value); }
		}

		/// <summary>The TokenCreated property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."token_created".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> TokenCreated
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.TokenCreated, false); }
			set	{ SetValue((int)UserFieldIndex.TokenCreated, value); }
		}

		/// <summary>The TokenExpires property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."token_expires".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> TokenExpires
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.TokenExpires, false); }
			set	{ SetValue((int)UserFieldIndex.TokenExpires, value); }
		}

		/// <summary>The Username property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."username".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Username, true); }
			set	{ SetValue((int)UserFieldIndex.Username, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace RecipeDB
{
	public enum UserFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>PasswordSalt. </summary>
		PasswordSalt,
		///<summary>RefreshToken. </summary>
		RefreshToken,
		///<summary>TokenCreated. </summary>
		TokenCreated,
		///<summary>TokenExpires. </summary>
		TokenExpires,
		///<summary>Username. </summary>
		Username,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace RecipeDB.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRelations
	{

		/// <summary>CTor</summary>
		static StaticUserRelations() { }
	}
}