
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 12/4/2019 10:16:55 PM
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
	/// Encapsulates the 'OrdenDetalle' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(OrdenDetalle))]	
	[XmlType("OrdenDetalle")]
	public partial class OrdenDetalle : esOrdenDetalle
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new OrdenDetalle();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new OrdenDetalle();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new OrdenDetalle();
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
	[XmlType("OrdenDetalleCollection")]
	public partial class OrdenDetalleCollection : esOrdenDetalleCollection, IEnumerable<OrdenDetalle>
	{
		public OrdenDetalle FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(OrdenDetalle))]
		public class OrdenDetalleCollectionWCFPacket : esCollectionWCFPacket<OrdenDetalleCollection>
		{
			public static implicit operator OrdenDetalleCollection(OrdenDetalleCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator OrdenDetalleCollectionWCFPacket(OrdenDetalleCollection collection)
			{
				return new OrdenDetalleCollectionWCFPacket() { Collection = collection };
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
	public partial class OrdenDetalleQuery : esOrdenDetalleQuery
	{
		public OrdenDetalleQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "OrdenDetalleQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(OrdenDetalleQuery query)
		{
			return OrdenDetalleQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrdenDetalleQuery(string query)
		{
			return (OrdenDetalleQuery)OrdenDetalleQuery.SerializeHelper.FromXml(query, typeof(OrdenDetalleQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrdenDetalle : esEntity
	{
		public esOrdenDetalle()
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
			OrdenDetalleQuery query = new OrdenDetalleQuery();
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
		/// Maps to OrdenDetalle.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(OrdenDetalleMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenDetalleMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.OrdenId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? OrdenId
		{
			get
			{
				return base.GetSystemInt32(OrdenDetalleMetadata.ColumnNames.OrdenId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenDetalleMetadata.ColumnNames.OrdenId, value))
				{
					this._UpToOrdenesByOrdenId = null;
					this.OnPropertyChanged("UpToOrdenesByOrdenId");
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.OrdenId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.ProductoId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ProductoId
		{
			get
			{
				return base.GetSystemInt32(OrdenDetalleMetadata.ColumnNames.ProductoId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenDetalleMetadata.ColumnNames.ProductoId, value))
				{
					this._UpToProductosByProductoId = null;
					this.OnPropertyChanged("UpToProductosByProductoId");
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.ProductoId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.ProductoNombre
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProductoNombre
		{
			get
			{
				return base.GetSystemString(OrdenDetalleMetadata.ColumnNames.ProductoNombre);
			}
			
			set
			{
				if(base.SetSystemString(OrdenDetalleMetadata.ColumnNames.ProductoNombre, value))
				{
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.ProductoNombre);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.Cantidad
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Cantidad
		{
			get
			{
				return base.GetSystemInt32(OrdenDetalleMetadata.ColumnNames.Cantidad);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenDetalleMetadata.ColumnNames.Cantidad, value))
				{
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Cantidad);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.Precio
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Precio
		{
			get
			{
				return base.GetSystemDecimal(OrdenDetalleMetadata.ColumnNames.Precio);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenDetalleMetadata.ColumnNames.Precio, value))
				{
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Precio);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenDetalle.Total
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Total
		{
			get
			{
				return base.GetSystemDecimal(OrdenDetalleMetadata.ColumnNames.Total);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenDetalleMetadata.ColumnNames.Total, value))
				{
					OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Total);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected Ordenes _UpToOrdenesByOrdenId;
		[CLSCompliant(false)]
		internal protected Productos _UpToProductosByProductoId;
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
						case "OrdenId": this.str().OrdenId = (string)value; break;							
						case "ProductoId": this.str().ProductoId = (string)value; break;							
						case "ProductoNombre": this.str().ProductoNombre = (string)value; break;							
						case "Cantidad": this.str().Cantidad = (string)value; break;							
						case "Precio": this.str().Precio = (string)value; break;							
						case "Total": this.str().Total = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Id);
							break;
						
						case "OrdenId":
						
							if (value == null || value is System.Int32)
								this.OrdenId = (System.Int32?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.OrdenId);
							break;
						
						case "ProductoId":
						
							if (value == null || value is System.Int32)
								this.ProductoId = (System.Int32?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.ProductoId);
							break;
						
						case "Cantidad":
						
							if (value == null || value is System.Int32)
								this.Cantidad = (System.Int32?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Cantidad);
							break;
						
						case "Precio":
						
							if (value == null || value is System.Decimal)
								this.Precio = (System.Decimal?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Precio);
							break;
						
						case "Total":
						
							if (value == null || value is System.Decimal)
								this.Total = (System.Decimal?)value;
								OnPropertyChanged(OrdenDetalleMetadata.PropertyNames.Total);
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
			public esStrings(esOrdenDetalle entity)
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
				
			public System.String OrdenId
			{
				get
				{
					System.Int32? data = entity.OrdenId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OrdenId = null;
					else entity.OrdenId = Convert.ToInt32(value);
				}
			}
				
			public System.String ProductoId
			{
				get
				{
					System.Int32? data = entity.ProductoId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductoId = null;
					else entity.ProductoId = Convert.ToInt32(value);
				}
			}
				
			public System.String ProductoNombre
			{
				get
				{
					System.String data = entity.ProductoNombre;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductoNombre = null;
					else entity.ProductoNombre = Convert.ToString(value);
				}
			}
				
			public System.String Cantidad
			{
				get
				{
					System.Int32? data = entity.Cantidad;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Cantidad = null;
					else entity.Cantidad = Convert.ToInt32(value);
				}
			}
				
			public System.String Precio
			{
				get
				{
					System.Decimal? data = entity.Precio;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Precio = null;
					else entity.Precio = Convert.ToDecimal(value);
				}
			}
				
			public System.String Total
			{
				get
				{
					System.Decimal? data = entity.Total;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Total = null;
					else entity.Total = Convert.ToDecimal(value);
				}
			}
			

			private esOrdenDetalle entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrdenDetalleMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrdenDetalleQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenDetalleQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenDetalleQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrdenDetalleQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrdenDetalleQuery query;		
	}



	[Serializable]
	abstract public partial class esOrdenDetalleCollection : esEntityCollection<OrdenDetalle>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrdenDetalleMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrdenDetalleCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrdenDetalleQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenDetalleQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenDetalleQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrdenDetalleQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrdenDetalleQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrdenDetalleQuery)query);
		}

		#endregion
		
		private OrdenDetalleQuery query;
	}



	[Serializable]
	abstract public partial class esOrdenDetalleQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrdenDetalleMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "OrdenId": return this.OrdenId;
				case "ProductoId": return this.ProductoId;
				case "ProductoNombre": return this.ProductoNombre;
				case "Cantidad": return this.Cantidad;
				case "Precio": return this.Precio;
				case "Total": return this.Total;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem OrdenId
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.OrdenId, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductoId
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.ProductoId, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductoNombre
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.ProductoNombre, esSystemType.String); }
		} 
		
		public esQueryItem Cantidad
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.Cantidad, esSystemType.Int32); }
		} 
		
		public esQueryItem Precio
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.Precio, esSystemType.Decimal); }
		} 
		
		public esQueryItem Total
		{
			get { return new esQueryItem(this, OrdenDetalleMetadata.ColumnNames.Total, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class OrdenDetalle : esOrdenDetalle
	{

				
		#region UpToOrdenesByOrdenId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_OrdenDetalle_Ordenes
		/// </summary>

		[XmlIgnore]
					
		public Ordenes UpToOrdenesByOrdenId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToOrdenesByOrdenId == null && OrdenId != null)
				{
					this._UpToOrdenesByOrdenId = new Ordenes();
					this._UpToOrdenesByOrdenId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToOrdenesByOrdenId", this._UpToOrdenesByOrdenId);
					this._UpToOrdenesByOrdenId.Query.Where(this._UpToOrdenesByOrdenId.Query.Id == this.OrdenId);
					this._UpToOrdenesByOrdenId.Query.Load();
				}	
				return this._UpToOrdenesByOrdenId;
			}
			
			set
			{
				this.RemovePreSave("UpToOrdenesByOrdenId");
				

				if(value == null)
				{
					this.OrdenId = null;
					this._UpToOrdenesByOrdenId = null;
				}
				else
				{
					this.OrdenId = value.Id;
					this._UpToOrdenesByOrdenId = value;
					this.SetPreSave("UpToOrdenesByOrdenId", this._UpToOrdenesByOrdenId);
				}
				
			}
		}
		#endregion
		

				
		#region UpToProductosByProductoId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_OrdenDetalle_Productos
		/// </summary>

		[XmlIgnore]
					
		public Productos UpToProductosByProductoId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToProductosByProductoId == null && ProductoId != null)
				{
					this._UpToProductosByProductoId = new Productos();
					this._UpToProductosByProductoId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToProductosByProductoId", this._UpToProductosByProductoId);
					this._UpToProductosByProductoId.Query.Where(this._UpToProductosByProductoId.Query.Id == this.ProductoId);
					this._UpToProductosByProductoId.Query.Load();
				}	
				return this._UpToProductosByProductoId;
			}
			
			set
			{
				this.RemovePreSave("UpToProductosByProductoId");
				

				if(value == null)
				{
					this.ProductoId = null;
					this._UpToProductosByProductoId = null;
				}
				else
				{
					this.ProductoId = value.Id;
					this._UpToProductosByProductoId = value;
					this.SetPreSave("UpToProductosByProductoId", this._UpToProductosByProductoId);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToOrdenesByOrdenId != null)
			{
				this.OrdenId = this._UpToOrdenesByOrdenId.Id;
			}
			if(!this.es.IsDeleted && this._UpToProductosByProductoId != null)
			{
				this.ProductoId = this._UpToProductosByProductoId.Id;
			}
		}
		
	}
	



	[Serializable]
	public partial class OrdenDetalleMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrdenDetalleMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.OrdenId, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.OrdenId;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.ProductoId, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.ProductoId;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.ProductoNombre, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.ProductoNombre;
			c.CharacterMaxLength = 200;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.Cantidad, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.Cantidad;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.Precio, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.Precio;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenDetalleMetadata.ColumnNames.Total, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenDetalleMetadata.PropertyNames.Total;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrdenDetalleMetadata Meta()
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
			 public const string OrdenId = "OrdenId";
			 public const string ProductoId = "ProductoId";
			 public const string ProductoNombre = "ProductoNombre";
			 public const string Cantidad = "Cantidad";
			 public const string Precio = "Precio";
			 public const string Total = "Total";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string OrdenId = "OrdenId";
			 public const string ProductoId = "ProductoId";
			 public const string ProductoNombre = "ProductoNombre";
			 public const string Cantidad = "Cantidad";
			 public const string Precio = "Precio";
			 public const string Total = "Total";
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
			lock (typeof(OrdenDetalleMetadata))
			{
				if(OrdenDetalleMetadata.mapDelegates == null)
				{
					OrdenDetalleMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrdenDetalleMetadata.meta == null)
				{
					OrdenDetalleMetadata.meta = new OrdenDetalleMetadata();
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
				meta.AddTypeMap("OrdenId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ProductoId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ProductoNombre", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cantidad", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Precio", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"));			
				
				
				
				meta.Source = "OrdenDetalle";
				meta.Destination = "OrdenDetalle";
				
				meta.spInsert = "proc_OrdenDetalleInsert";				
				meta.spUpdate = "proc_OrdenDetalleUpdate";		
				meta.spDelete = "proc_OrdenDetalleDelete";
				meta.spLoadAll = "proc_OrdenDetalleLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrdenDetalleLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrdenDetalleMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
