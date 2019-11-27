
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 16/11/2019 02:05:03 a.m.
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
	/// Encapsulates the 'Clientes' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Clientes))]	
	[XmlType("Clientes")]
	public partial class Clientes : esClientes
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Clientes();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Clientes();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Clientes();
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
	[XmlType("ClientesCollection")]
	public partial class ClientesCollection : esClientesCollection, IEnumerable<Clientes>
	{
		public Clientes FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Clientes))]
		public class ClientesCollectionWCFPacket : esCollectionWCFPacket<ClientesCollection>
		{
			public static implicit operator ClientesCollection(ClientesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ClientesCollectionWCFPacket(ClientesCollection collection)
			{
				return new ClientesCollectionWCFPacket() { Collection = collection };
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
	public partial class ClientesQuery : esClientesQuery
	{
		public ClientesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ClientesQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(ClientesQuery query)
		{
			return ClientesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ClientesQuery(string query)
		{
			return (ClientesQuery)ClientesQuery.SerializeHelper.FromXml(query, typeof(ClientesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esClientes : esEntity
	{
		public esClientes()
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
			ClientesQuery query = new ClientesQuery();
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
		/// Maps to Clientes.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ClientesMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ClientesMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ClientesMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Clientes.Nombre
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Nombre
		{
			get
			{
				return base.GetSystemString(ClientesMetadata.ColumnNames.Nombre);
			}
			
			set
			{
				if(base.SetSystemString(ClientesMetadata.ColumnNames.Nombre, value))
				{
					OnPropertyChanged(ClientesMetadata.PropertyNames.Nombre);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Clientes.Direccion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Direccion
		{
			get
			{
				return base.GetSystemString(ClientesMetadata.ColumnNames.Direccion);
			}
			
			set
			{
				if(base.SetSystemString(ClientesMetadata.ColumnNames.Direccion, value))
				{
					OnPropertyChanged(ClientesMetadata.PropertyNames.Direccion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Clientes.Telefono
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Telefono
		{
			get
			{
				return base.GetSystemString(ClientesMetadata.ColumnNames.Telefono);
			}
			
			set
			{
				if(base.SetSystemString(ClientesMetadata.ColumnNames.Telefono, value))
				{
					OnPropertyChanged(ClientesMetadata.PropertyNames.Telefono);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Clientes.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(ClientesMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(ClientesMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(ClientesMetadata.PropertyNames.Email);
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
						case "Direccion": this.str().Direccion = (string)value; break;							
						case "Telefono": this.str().Telefono = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ClientesMetadata.PropertyNames.Id);
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
			public esStrings(esClientes entity)
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
			

			private esClientes entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ClientesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ClientesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ClientesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ClientesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ClientesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ClientesQuery query;		
	}



	[Serializable]
	abstract public partial class esClientesCollection : esEntityCollection<Clientes>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ClientesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ClientesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ClientesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ClientesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ClientesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ClientesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ClientesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ClientesQuery)query);
		}

		#endregion
		
		private ClientesQuery query;
	}



	[Serializable]
	abstract public partial class esClientesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ClientesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Nombre": return this.Nombre;
				case "Direccion": return this.Direccion;
				case "Telefono": return this.Telefono;
				case "Email": return this.Email;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ClientesMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Nombre
		{
			get { return new esQueryItem(this, ClientesMetadata.ColumnNames.Nombre, esSystemType.String); }
		} 
		
		public esQueryItem Direccion
		{
			get { return new esQueryItem(this, ClientesMetadata.ColumnNames.Direccion, esSystemType.String); }
		} 
		
		public esQueryItem Telefono
		{
			get { return new esQueryItem(this, ClientesMetadata.ColumnNames.Telefono, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, ClientesMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Clientes : esClientes
	{

		
		
	}
	



	[Serializable]
	public partial class ClientesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ClientesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ClientesMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ClientesMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClientesMetadata.ColumnNames.Nombre, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ClientesMetadata.PropertyNames.Nombre;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClientesMetadata.ColumnNames.Direccion, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ClientesMetadata.PropertyNames.Direccion;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClientesMetadata.ColumnNames.Telefono, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ClientesMetadata.PropertyNames.Telefono;
			c.CharacterMaxLength = 23;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ClientesMetadata.ColumnNames.Email, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ClientesMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 75;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ClientesMetadata Meta()
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
			 public const string Direccion = "Direccion";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Nombre = "Nombre";
			 public const string Direccion = "Direccion";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
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
			lock (typeof(ClientesMetadata))
			{
				if(ClientesMetadata.mapDelegates == null)
				{
					ClientesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ClientesMetadata.meta == null)
				{
					ClientesMetadata.meta = new ClientesMetadata();
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
				meta.AddTypeMap("Direccion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telefono", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Clientes";
				meta.Destination = "Clientes";
				
				meta.spInsert = "proc_ClientesInsert";				
				meta.spUpdate = "proc_ClientesUpdate";		
				meta.spDelete = "proc_ClientesDelete";
				meta.spLoadAll = "proc_ClientesLoadAll";
				meta.spLoadByPrimaryKey = "proc_ClientesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ClientesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
