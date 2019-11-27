
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/26/2019 2:18:33 PM
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
	/// Encapsulates the 'Customer' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Customer))]	
	[XmlType("Customer")]
	public partial class Customer : esCustomer
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customer();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Customer();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Customer();
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
	[XmlType("CustomerCollection")]
	public partial class CustomerCollection : esCustomerCollection, IEnumerable<Customer>
	{
		public Customer FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Customer))]
		public class CustomerCollectionWCFPacket : esCollectionWCFPacket<CustomerCollection>
		{
			public static implicit operator CustomerCollection(CustomerCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CustomerCollectionWCFPacket(CustomerCollection collection)
			{
				return new CustomerCollectionWCFPacket() { Collection = collection };
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
	public partial class CustomerQuery : esCustomerQuery
	{
		public CustomerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CustomerQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerQuery query)
		{
			return CustomerQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerQuery(string query)
		{
			return (CustomerQuery)CustomerQuery.SerializeHelper.FromXml(query, typeof(CustomerQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomer : esEntity
	{
		public esCustomer()
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
			CustomerQuery query = new CustomerQuery();
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
		/// Maps to Customer.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(CustomerMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(CustomerMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.BirthDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? BirthDate
		{
			get
			{
				return base.GetSystemDateTime(CustomerMetadata.ColumnNames.BirthDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(CustomerMetadata.ColumnNames.BirthDate, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.BirthDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.ZipCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ZipCode
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.ZipCode);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.ZipCode, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.ZipCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Position
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Position
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Position);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Position, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Position);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Username
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Username
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Username);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Username, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Username);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.Password, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Password);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.Avatar
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Avatar
		{
			get
			{
				return base.GetSystemByteArray(CustomerMetadata.ColumnNames.Avatar);
			}
			
			set
			{
				if(base.SetSystemByteArray(CustomerMetadata.ColumnNames.Avatar, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.Avatar);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customer.FullName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FullName
		{
			get
			{
				return base.GetSystemString(CustomerMetadata.ColumnNames.FullName);
			}
			
			set
			{
				if(base.SetSystemString(CustomerMetadata.ColumnNames.FullName, value))
				{
					OnPropertyChanged(CustomerMetadata.PropertyNames.FullName);
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
								OnPropertyChanged(CustomerMetadata.PropertyNames.Id);
							break;
						
						case "BirthDate":
						
							if (value == null || value is System.DateTime)
								this.BirthDate = (System.DateTime?)value;
								OnPropertyChanged(CustomerMetadata.PropertyNames.BirthDate);
							break;
						
						case "Avatar":
						
							if (value == null || value is System.Byte[])
								this.Avatar = (System.Byte[])value;
								OnPropertyChanged(CustomerMetadata.PropertyNames.Avatar);
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
			public esStrings(esCustomer entity)
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
			

			private esCustomer entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerCollection : esEntityCollection<Customer>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerQuery)query);
		}

		#endregion
		
		private CustomerQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerMetadata.Meta();
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
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem BirthDate
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.BirthDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem ZipCode
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.ZipCode, esSystemType.String); }
		} 
		
		public esQueryItem Position
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Position, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem Username
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Username, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem Avatar
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.Avatar, esSystemType.ByteArray); }
		} 
		
		public esQueryItem FullName
		{
			get { return new esQueryItem(this, CustomerMetadata.ColumnNames.FullName, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customer : esCustomer
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = CustomerMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.FirstName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.LastName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.BirthDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = CustomerMetadata.PropertyNames.BirthDate;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 256;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.ZipCode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.ZipCode;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Position, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Position;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Phone, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 23;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Notes, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 512;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Username, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Username;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Password, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.Avatar, 12, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = CustomerMetadata.PropertyNames.Avatar;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerMetadata.ColumnNames.FullName, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerMetadata.PropertyNames.FullName;
			c.CharacterMaxLength = 151;
			c.IsComputed = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerMetadata Meta()
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
			lock (typeof(CustomerMetadata))
			{
				if(CustomerMetadata.mapDelegates == null)
				{
					CustomerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerMetadata.meta == null)
				{
					CustomerMetadata.meta = new CustomerMetadata();
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
				
				
				
				meta.Source = "Customer";
				meta.Destination = "Customer";
				
				meta.spInsert = "proc_CustomerInsert";				
				meta.spUpdate = "proc_CustomerUpdate";		
				meta.spDelete = "proc_CustomerDelete";
				meta.spLoadAll = "proc_CustomerLoadAll";
				meta.spLoadByPrimaryKey = "proc_CustomerLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
