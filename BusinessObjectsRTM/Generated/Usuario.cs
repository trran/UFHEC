
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 12/1/2019 8:05:58 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjectsRTM
{
	/// <summary>
	/// Encapsulates the 'Usuario' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Usuario))]	
	[XmlType("Usuario")]
	public partial class Usuario : esUsuario
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Usuario();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Usuario();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Usuario();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("UsuarioCollection")]
	public partial class UsuarioCollection : esUsuarioCollection, IEnumerable<Usuario>
	{
		public Usuario FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Usuario))]
		public class UsuarioCollectionWCFPacket : esCollectionWCFPacket<UsuarioCollection>
		{
			public static implicit operator UsuarioCollection(UsuarioCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator UsuarioCollectionWCFPacket(UsuarioCollection collection)
			{
				return new UsuarioCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}		
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class UsuarioQuery : esUsuarioQuery
	{
		public UsuarioQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "UsuarioQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(UsuarioQuery query)
		{
			return UsuarioQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator UsuarioQuery(string query)
		{
			return (UsuarioQuery)UsuarioQuery.SerializeHelper.FromXml(query, typeof(UsuarioQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esUsuario : esEntity
	{
		public esUsuario()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			UsuarioQuery query = new UsuarioQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Usuario.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(UsuarioMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(UsuarioMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.BirthDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? BirthDate
		{
			get
			{
				return base.GetSystemDateTime(UsuarioMetadata.ColumnNames.BirthDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(UsuarioMetadata.ColumnNames.BirthDate, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.BirthDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.ZipCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ZipCode
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.ZipCode);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.ZipCode, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.ZipCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Position
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Position
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Position);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Position, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Position);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Username
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Username
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Username);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Username, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Username);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.Password, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Password);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.Avatar
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Avatar
		{
			get
			{
				return base.GetSystemByteArray(UsuarioMetadata.ColumnNames.Avatar);
			}
			
			set
			{
				if(base.SetSystemByteArray(UsuarioMetadata.ColumnNames.Avatar, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.Avatar);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Usuario.FullName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FullName
		{
			get
			{
				return base.GetSystemString(UsuarioMetadata.ColumnNames.FullName);
			}
			
			set
			{
				if(base.SetSystemString(UsuarioMetadata.ColumnNames.FullName, value))
				{
					OnPropertyChanged(UsuarioMetadata.PropertyNames.FullName);
				}
			}
		}		
		
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str().Id = (string)value; break;							
						case "FirstName": this.str().FirstName = (string)value; break;							
						case "LastName": this.str().LastName = (string)value; break;							
						case "BirthDate": this.str().BirthDate = (string)value; break;							
						case "Address": this.str().Address = (string)value; break;							
						case "City": this.str().City = (string)value; break;							
						case "ZipCode": this.str().ZipCode = (string)value; break;							
						case "Position": this.str().Position = (string)value; break;							
						case "Phone": this.str().Phone = (string)value; break;							
						case "Notes": this.str().Notes = (string)value; break;							
						case "Username": this.str().Username = (string)value; break;							
						case "Password": this.str().Password = (string)value; break;							
						case "FullName": this.str().FullName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(UsuarioMetadata.PropertyNames.Id);
							break;
						
						case "BirthDate":
						
							if (value == null || value is System.DateTime)
								this.BirthDate = (System.DateTime?)value;
								OnPropertyChanged(UsuarioMetadata.PropertyNames.BirthDate);
							break;
						
						case "Avatar":
						
							if (value == null || value is System.Byte[])
								this.Avatar = (System.Byte[])value;
								OnPropertyChanged(UsuarioMetadata.PropertyNames.Avatar);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esUsuario entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int32? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt32(value);
				}
			}
				
			public System.String FirstName
			{
				get
				{
					System.String data = entity.FirstName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FirstName = null;
					else entity.FirstName = Convert.ToString(value);
				}
			}
				
			public System.String LastName
			{
				get
				{
					System.String data = entity.LastName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastName = null;
					else entity.LastName = Convert.ToString(value);
				}
			}
				
			public System.String BirthDate
			{
				get
				{
					System.DateTime? data = entity.BirthDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BirthDate = null;
					else entity.BirthDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Address
			{
				get
				{
					System.String data = entity.Address;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Address = null;
					else entity.Address = Convert.ToString(value);
				}
			}
				
			public System.String City
			{
				get
				{
					System.String data = entity.City;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.City = null;
					else entity.City = Convert.ToString(value);
				}
			}
				
			public System.String ZipCode
			{
				get
				{
					System.String data = entity.ZipCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ZipCode = null;
					else entity.ZipCode = Convert.ToString(value);
				}
			}
				
			public System.String Position
			{
				get
				{
					System.String data = entity.Position;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Position = null;
					else entity.Position = Convert.ToString(value);
				}
			}
				
			public System.String Phone
			{
				get
				{
					System.String data = entity.Phone;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Phone = null;
					else entity.Phone = Convert.ToString(value);
				}
			}
				
			public System.String Notes
			{
				get
				{
					System.String data = entity.Notes;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Notes = null;
					else entity.Notes = Convert.ToString(value);
				}
			}
				
			public System.String Username
			{
				get
				{
					System.String data = entity.Username;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Username = null;
					else entity.Username = Convert.ToString(value);
				}
			}
				
			public System.String Password
			{
				get
				{
					System.String data = entity.Password;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Password = null;
					else entity.Password = Convert.ToString(value);
				}
			}
				
			public System.String FullName
			{
				get
				{
					System.String data = entity.FullName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FullName = null;
					else entity.FullName = Convert.ToString(value);
				}
			}
			

			private esUsuario entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return UsuarioMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public UsuarioQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsuarioQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsuarioQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(UsuarioQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private UsuarioQuery query;		
	}



	[Serializable]
	abstract public partial class esUsuarioCollection : esEntityCollection<Usuario>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UsuarioMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "UsuarioCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public UsuarioQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsuarioQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsuarioQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UsuarioQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(UsuarioQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UsuarioQuery)query);
		}

		#endregion
		
		private UsuarioQuery query;
	}



	[Serializable]
	abstract public partial class esUsuarioQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UsuarioMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "FirstName": return this.FirstName;
				case "LastName": return this.LastName;
				case "BirthDate": return this.BirthDate;
				case "Address": return this.Address;
				case "City": return this.City;
				case "ZipCode": return this.ZipCode;
				case "Position": return this.Position;
				case "Phone": return this.Phone;
				case "Notes": return this.Notes;
				case "Username": return this.Username;
				case "Password": return this.Password;
				case "Avatar": return this.Avatar;
				case "FullName": return this.FullName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem BirthDate
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.BirthDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem ZipCode
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.ZipCode, esSystemType.String); }
		} 
		
		public esQueryItem Position
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Position, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem Username
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Username, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem Avatar
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.Avatar, esSystemType.ByteArray); }
		} 
		
		public esQueryItem FullName
		{
			get { return new esQueryItem(this, UsuarioMetadata.ColumnNames.FullName, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Usuario : esUsuario
	{

		
		
	}
	



	[Serializable]
	public partial class UsuarioMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UsuarioMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsuarioMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.FirstName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.LastName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.BirthDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = UsuarioMetadata.PropertyNames.BirthDate;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 256;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.ZipCode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.ZipCode;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Position, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Position;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Phone, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 23;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Notes, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 512;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Username, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Username;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Password, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.Avatar, 12, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = UsuarioMetadata.PropertyNames.Avatar;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsuarioMetadata.ColumnNames.FullName, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = UsuarioMetadata.PropertyNames.FullName;
			c.CharacterMaxLength = 151;
			c.IsComputed = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public UsuarioMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "Id";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string BirthDate = "BirthDate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string ZipCode = "ZipCode";
			 public const string Position = "Position";
			 public const string Phone = "Phone";
			 public const string Notes = "Notes";
			 public const string Username = "Username";
			 public const string Password = "Password";
			 public const string Avatar = "Avatar";
			 public const string FullName = "FullName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string BirthDate = "BirthDate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string ZipCode = "ZipCode";
			 public const string Position = "Position";
			 public const string Phone = "Phone";
			 public const string Notes = "Notes";
			 public const string Username = "Username";
			 public const string Password = "Password";
			 public const string Avatar = "Avatar";
			 public const string FullName = "FullName";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(UsuarioMetadata))
			{
				if(UsuarioMetadata.mapDelegates == null)
				{
					UsuarioMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (UsuarioMetadata.meta == null)
				{
					UsuarioMetadata.meta = new UsuarioMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("FirstName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("BirthDate", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("Address", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ZipCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Position", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Notes", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Username", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Password", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Avatar", new esTypeMap("image", "System.Byte[]"));
				meta.AddTypeMap("FullName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Usuario";
				meta.Destination = "Usuario";
				
				meta.spInsert = "proc_UsuarioInsert";				
				meta.spUpdate = "proc_UsuarioUpdate";		
				meta.spDelete = "proc_UsuarioDelete";
				meta.spLoadAll = "proc_UsuarioLoadAll";
				meta.spLoadByPrimaryKey = "proc_UsuarioLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UsuarioMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
