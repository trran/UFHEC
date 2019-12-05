
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 12/4/2019 10:16:52 PM
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
	/// Encapsulates the 'Cliente' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Cliente))]	
	[XmlType("Cliente")]
	public partial class Cliente : esCliente
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Cliente();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Cliente();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Cliente();
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
	[XmlType("ClienteCollection")]
	public partial class ClienteCollection : esClienteCollection, IEnumerable<Cliente>
	{
		public Cliente FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Cliente))]
		public class ClienteCollectionWCFPacket : esCollectionWCFPacket<ClienteCollection>
		{
			public static implicit operator ClienteCollection(ClienteCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ClienteCollectionWCFPacket(ClienteCollection collection)
			{
				return new ClienteCollectionWCFPacket() { Collection = collection };
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
	public partial class ClienteQuery : esClienteQuery
	{
		public ClienteQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ClienteQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(ClienteQuery query)
		{
			return ClienteQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ClienteQuery(string query)
		{
			return (ClienteQuery)ClienteQuery.SerializeHelper.FromXml(query, typeof(ClienteQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCliente : esEntity
	{
		public esCliente()
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
			ClienteQuery query = new ClienteQuery();
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
		/// Maps to Cliente.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ClienteMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ClienteMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.Nombre
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Nombre
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.Nombre);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.Nombre, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Nombre);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.DocumentType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DocumentType
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.DocumentType);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.DocumentType, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.DocumentType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.DocumentNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DocumentNo
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.DocumentNo);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.DocumentNo, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.DocumentNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.Telefono
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Telefono
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.Telefono);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.Telefono, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Telefono);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Email);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.Direccion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Direccion
		{
			get
			{
				return base.GetSystemString(ClienteMetadata.ColumnNames.Direccion);
			}
			
			set
			{
				if(base.SetSystemString(ClienteMetadata.ColumnNames.Direccion, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Direccion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Cliente.Estatus
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Estatus
		{
			get
			{
				return base.GetSystemBoolean(ClienteMetadata.ColumnNames.Estatus);
			}
			
			set
			{
				if(base.SetSystemBoolean(ClienteMetadata.ColumnNames.Estatus, value))
				{
					OnPropertyChanged(ClienteMetadata.PropertyNames.Estatus);
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
						case "Nombre": this.str().Nombre = (string)value; break;							
						case "DocumentType": this.str().DocumentType = (string)value; break;							
						case "DocumentNo": this.str().DocumentNo = (string)value; break;							
						case "Telefono": this.str().Telefono = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "Direccion": this.str().Direccion = (string)value; break;							
						case "Estatus": this.str().Estatus = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ClienteMetadata.PropertyNames.Id);
							break;
						
						case "Estatus":
						
							if (value == null || value is System.Boolean)
								this.Estatus = (System.Boolean?)value;
								OnPropertyChanged(ClienteMetadata.PropertyNames.Estatus);
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
			public esStrings(esCliente entity)
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
				
			public System.String Nombre
			{
				get
				{
					System.String data = entity.Nombre;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Nombre = null;
					else entity.Nombre = Convert.ToString(value);
				}
			}
				
			public System.String DocumentType
			{
				get
				{
					System.String data = entity.DocumentType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DocumentType = null;
					else entity.DocumentType = Convert.ToString(value);
				}
			}
				
			public System.String DocumentNo
			{
				get
				{
					System.String data = entity.DocumentNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DocumentNo = null;
					else entity.DocumentNo = Convert.ToString(value);
				}
			}
				
			public System.String Telefono
			{
				get
				{
					System.String data = entity.Telefono;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Telefono = null;
					else entity.Telefono = Convert.ToString(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String Direccion
			{
				get
				{
					System.String data = entity.Direccion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Direccion = null;
					else entity.Direccion = Convert.ToString(value);
				}
			}
				
			public System.String Estatus
			{
				get
				{
					System.Boolean? data = entity.Estatus;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Estatus = null;
					else entity.Estatus = Convert.ToBoolean(value);
				}
			}
			

			private esCliente entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ClienteMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ClienteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ClienteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ClienteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ClienteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ClienteQuery query;		
	}



	[Serializable]
	abstract public partial class esClienteCollection : esEntityCollection<Cliente>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ClienteMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ClienteCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ClienteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ClienteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ClienteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ClienteQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ClienteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ClienteQuery)query);
		}

		#endregion
		
		private ClienteQuery query;
	}



	[Serializable]
	abstract public partial class esClienteQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ClienteMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Nombre": return this.Nombre;
				case "DocumentType": return this.DocumentType;
				case "DocumentNo": return this.DocumentNo;
				case "Telefono": return this.Telefono;
				case "Email": return this.Email;
				case "Direccion": return this.Direccion;
				case "Estatus": return this.Estatus;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Nombre
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Nombre, esSystemType.String); }
		} 
		
		public esQueryItem DocumentType
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.DocumentType, esSystemType.String); }
		} 
		
		public esQueryItem DocumentNo
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.DocumentNo, esSystemType.String); }
		} 
		
		public esQueryItem Telefono
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Telefono, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Direccion
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Direccion, esSystemType.String); }
		} 
		
		public esQueryItem Estatus
		{
			get { return new esQueryItem(this, ClienteMetadata.ColumnNames.Estatus, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class Cliente : esCliente
	{

		#region OrdenesCollectionByClienteId - Zero To Many
		
		static public esPrefetchMap Prefetch_OrdenesCollectionByClienteId
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjectsRTM.Cliente.OrdenesCollectionByClienteId_Delegate;
				map.PropertyName = "OrdenesCollectionByClienteId";
				map.MyColumnName = "ClienteId";
				map.ParentColumnName = "Id";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void OrdenesCollectionByClienteId_Delegate(esPrefetchParameters data)
		{
			ClienteQuery parent = new ClienteQuery(data.NextAlias());

			OrdenesQuery me = data.You != null ? data.You as OrdenesQuery : new OrdenesQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Id == me.ClienteId);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_Ordenes_Cliente
		/// </summary>

		[XmlIgnore]
		public OrdenesCollection OrdenesCollectionByClienteId
		{
			get
			{
				if(this._OrdenesCollectionByClienteId == null)
				{
					this._OrdenesCollectionByClienteId = new OrdenesCollection();
					this._OrdenesCollectionByClienteId.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("OrdenesCollectionByClienteId", this._OrdenesCollectionByClienteId);
				
					if (this.Id != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._OrdenesCollectionByClienteId.Query.Where(this._OrdenesCollectionByClienteId.Query.ClienteId == this.Id);
							this._OrdenesCollectionByClienteId.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._OrdenesCollectionByClienteId.fks.Add(OrdenesMetadata.ColumnNames.ClienteId, this.Id);
					}
				}

				return this._OrdenesCollectionByClienteId;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._OrdenesCollectionByClienteId != null) 
				{ 
					this.RemovePostSave("OrdenesCollectionByClienteId"); 
					this._OrdenesCollectionByClienteId = null;
					
				} 
			} 			
		}
			
		
		private OrdenesCollection _OrdenesCollectionByClienteId;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "OrdenesCollectionByClienteId":
					coll = this.OrdenesCollectionByClienteId;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "OrdenesCollectionByClienteId", typeof(OrdenesCollection), new Ordenes()));
		
			return props;
		}
		
		/// <summary>
		/// Called by ApplyPostSaveKeys 
		/// </summary>
		/// <param name="coll">The collection to enumerate over</param>
		/// <param name="key">"The column name</param>
		/// <param name="value">The column value</param>
		private void Apply(esEntityCollectionBase coll, string key, object value)
		{
			foreach (esEntity obj in coll)
			{
				if (obj.es.IsAdded)
				{
					obj.SetProperty(key, value);
				}
			}
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
			if(this._OrdenesCollectionByClienteId != null)
			{
				Apply(this._OrdenesCollectionByClienteId, "ClienteId", this.Id);
			}
		}
		
	}
	



	[Serializable]
	public partial class ClienteMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ClienteMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ClienteMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Nombre, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.Nombre;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.DocumentType, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.DocumentType;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.DocumentNo, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.DocumentNo;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Telefono, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.Telefono;
			c.CharacterMaxLength = 27;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Email, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 128;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Direccion, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ClienteMetadata.PropertyNames.Direccion;
			c.CharacterMaxLength = 512;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClienteMetadata.ColumnNames.Estatus, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ClienteMetadata.PropertyNames.Estatus;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ClienteMetadata Meta()
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
			 public const string Nombre = "Nombre";
			 public const string DocumentType = "DocumentType";
			 public const string DocumentNo = "DocumentNo";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string Direccion = "Direccion";
			 public const string Estatus = "Estatus";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Nombre = "Nombre";
			 public const string DocumentType = "DocumentType";
			 public const string DocumentNo = "DocumentNo";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string Direccion = "Direccion";
			 public const string Estatus = "Estatus";
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
			lock (typeof(ClienteMetadata))
			{
				if(ClienteMetadata.mapDelegates == null)
				{
					ClienteMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ClienteMetadata.meta == null)
				{
					ClienteMetadata.meta = new ClienteMetadata();
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
				meta.AddTypeMap("Nombre", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DocumentType", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("DocumentNo", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telefono", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Direccion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Estatus", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "Cliente";
				meta.Destination = "Cliente";
				
				meta.spInsert = "proc_ClienteInsert";				
				meta.spUpdate = "proc_ClienteUpdate";		
				meta.spDelete = "proc_ClienteDelete";
				meta.spLoadAll = "proc_ClienteLoadAll";
				meta.spLoadByPrimaryKey = "proc_ClienteLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ClienteMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
