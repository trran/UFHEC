
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 16/11/2019 02:05:06 a.m.
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
	/// Encapsulates the 'Productos' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Productos))]	
	[XmlType("Productos")]
	public partial class Productos : esProductos
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Productos();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Productos();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Productos();
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
	[XmlType("ProductosCollection")]
	public partial class ProductosCollection : esProductosCollection, IEnumerable<Productos>
	{
		public Productos FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Productos))]
		public class ProductosCollectionWCFPacket : esCollectionWCFPacket<ProductosCollection>
		{
			public static implicit operator ProductosCollection(ProductosCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ProductosCollectionWCFPacket(ProductosCollection collection)
			{
				return new ProductosCollectionWCFPacket() { Collection = collection };
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
	public partial class ProductosQuery : esProductosQuery
	{
		public ProductosQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ProductosQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(ProductosQuery query)
		{
			return ProductosQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProductosQuery(string query)
		{
			return (ProductosQuery)ProductosQuery.SerializeHelper.FromXml(query, typeof(ProductosQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProductos : esEntity
	{
		public esProductos()
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
			ProductosQuery query = new ProductosQuery();
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
		/// Maps to Productos.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ProductosMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductosMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.Nombre
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Nombre
		{
			get
			{
				return base.GetSystemString(ProductosMetadata.ColumnNames.Nombre);
			}
			
			set
			{
				if(base.SetSystemString(ProductosMetadata.ColumnNames.Nombre, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Nombre);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.Precio
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Precio
		{
			get
			{
				return base.GetSystemDecimal(ProductosMetadata.ColumnNames.Precio);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductosMetadata.ColumnNames.Precio, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Precio);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.ITBIS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Itbis
		{
			get
			{
				return base.GetSystemDecimal(ProductosMetadata.ColumnNames.Itbis);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductosMetadata.ColumnNames.Itbis, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Itbis);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.IdUnidad
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String IdUnidad
		{
			get
			{
				return base.GetSystemString(ProductosMetadata.ColumnNames.IdUnidad);
			}
			
			set
			{
				if(base.SetSystemString(ProductosMetadata.ColumnNames.IdUnidad, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.IdUnidad);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.Bloqueado
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Bloqueado
		{
			get
			{
				return base.GetSystemBoolean(ProductosMetadata.ColumnNames.Bloqueado);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProductosMetadata.ColumnNames.Bloqueado, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Bloqueado);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.Qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Qty
		{
			get
			{
				return base.GetSystemInt32(ProductosMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductosMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Qty);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Productos.Estatus
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Estatus
		{
			get
			{
				return base.GetSystemBoolean(ProductosMetadata.ColumnNames.Estatus);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProductosMetadata.ColumnNames.Estatus, value))
				{
					OnPropertyChanged(ProductosMetadata.PropertyNames.Estatus);
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
						case "Precio": this.str().Precio = (string)value; break;							
						case "Itbis": this.str().Itbis = (string)value; break;							
						case "IdUnidad": this.str().IdUnidad = (string)value; break;							
						case "Bloqueado": this.str().Bloqueado = (string)value; break;							
						case "Qty": this.str().Qty = (string)value; break;							
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
								OnPropertyChanged(ProductosMetadata.PropertyNames.Id);
							break;
						
						case "Precio":
						
							if (value == null || value is System.Decimal)
								this.Precio = (System.Decimal?)value;
								OnPropertyChanged(ProductosMetadata.PropertyNames.Precio);
							break;
						
						case "Itbis":
						
							if (value == null || value is System.Decimal)
								this.Itbis = (System.Decimal?)value;
								OnPropertyChanged(ProductosMetadata.PropertyNames.Itbis);
							break;
						
						case "Bloqueado":
						
							if (value == null || value is System.Boolean)
								this.Bloqueado = (System.Boolean?)value;
								OnPropertyChanged(ProductosMetadata.PropertyNames.Bloqueado);
							break;
						
						case "Qty":
						
							if (value == null || value is System.Int32)
								this.Qty = (System.Int32?)value;
								OnPropertyChanged(ProductosMetadata.PropertyNames.Qty);
							break;
						
						case "Estatus":
						
							if (value == null || value is System.Boolean)
								this.Estatus = (System.Boolean?)value;
								OnPropertyChanged(ProductosMetadata.PropertyNames.Estatus);
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
			public esStrings(esProductos entity)
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
				
			public System.String Itbis
			{
				get
				{
					System.Decimal? data = entity.Itbis;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Itbis = null;
					else entity.Itbis = Convert.ToDecimal(value);
				}
			}
				
			public System.String IdUnidad
			{
				get
				{
					System.String data = entity.IdUnidad;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdUnidad = null;
					else entity.IdUnidad = Convert.ToString(value);
				}
			}
				
			public System.String Bloqueado
			{
				get
				{
					System.Boolean? data = entity.Bloqueado;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Bloqueado = null;
					else entity.Bloqueado = Convert.ToBoolean(value);
				}
			}
				
			public System.String Qty
			{
				get
				{
					System.Int32? data = entity.Qty;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qty = null;
					else entity.Qty = Convert.ToInt32(value);
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
			

			private esProductos entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProductosMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProductosQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductosQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductosQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ProductosQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ProductosQuery query;		
	}



	[Serializable]
	abstract public partial class esProductosCollection : esEntityCollection<Productos>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProductosMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProductosCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProductosQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductosQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductosQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProductosQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProductosQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProductosQuery)query);
		}

		#endregion
		
		private ProductosQuery query;
	}



	[Serializable]
	abstract public partial class esProductosQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProductosMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Nombre": return this.Nombre;
				case "Precio": return this.Precio;
				case "Itbis": return this.Itbis;
				case "IdUnidad": return this.IdUnidad;
				case "Bloqueado": return this.Bloqueado;
				case "Qty": return this.Qty;
				case "Estatus": return this.Estatus;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Nombre
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Nombre, esSystemType.String); }
		} 
		
		public esQueryItem Precio
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Precio, esSystemType.Decimal); }
		} 
		
		public esQueryItem Itbis
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Itbis, esSystemType.Decimal); }
		} 
		
		public esQueryItem IdUnidad
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.IdUnidad, esSystemType.String); }
		} 
		
		public esQueryItem Bloqueado
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Bloqueado, esSystemType.Boolean); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Qty, esSystemType.Int32); }
		} 
		
		public esQueryItem Estatus
		{
			get { return new esQueryItem(this, ProductosMetadata.ColumnNames.Estatus, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class Productos : esProductos
	{

		#region OrdenesDetalleCollectionByIdProducto - Zero To Many
		
		static public esPrefetchMap Prefetch_OrdenesDetalleCollectionByIdProducto
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjectsRTM.Productos.OrdenesDetalleCollectionByIdProducto_Delegate;
				map.PropertyName = "OrdenesDetalleCollectionByIdProducto";
				map.MyColumnName = "IdProducto";
				map.ParentColumnName = "Id";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void OrdenesDetalleCollectionByIdProducto_Delegate(esPrefetchParameters data)
		{
			ProductosQuery parent = new ProductosQuery(data.NextAlias());

			OrdenesDetalleQuery me = data.You != null ? data.You as OrdenesDetalleQuery : new OrdenesDetalleQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Id == me.IdProducto);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_OrdenesDetalle_Productos
		/// </summary>

		[XmlIgnore]
		public OrdenesDetalleCollection OrdenesDetalleCollectionByIdProducto
		{
			get
			{
				if(this._OrdenesDetalleCollectionByIdProducto == null)
				{
					this._OrdenesDetalleCollectionByIdProducto = new OrdenesDetalleCollection();
					this._OrdenesDetalleCollectionByIdProducto.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("OrdenesDetalleCollectionByIdProducto", this._OrdenesDetalleCollectionByIdProducto);
				
					if (this.Id != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._OrdenesDetalleCollectionByIdProducto.Query.Where(this._OrdenesDetalleCollectionByIdProducto.Query.IdProducto == this.Id);
							this._OrdenesDetalleCollectionByIdProducto.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._OrdenesDetalleCollectionByIdProducto.fks.Add(OrdenesDetalleMetadata.ColumnNames.IdProducto, this.Id);
					}
				}

				return this._OrdenesDetalleCollectionByIdProducto;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._OrdenesDetalleCollectionByIdProducto != null) 
				{ 
					this.RemovePostSave("OrdenesDetalleCollectionByIdProducto"); 
					this._OrdenesDetalleCollectionByIdProducto = null;
					
				} 
			} 			
		}
			
		
		private OrdenesDetalleCollection _OrdenesDetalleCollectionByIdProducto;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "OrdenesDetalleCollectionByIdProducto":
					coll = this.OrdenesDetalleCollectionByIdProducto;
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
			
			props.Add(new esPropertyDescriptor(this, "OrdenesDetalleCollectionByIdProducto", typeof(OrdenesDetalleCollection), new OrdenesDetalle()));
		
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
			if(this._OrdenesDetalleCollectionByIdProducto != null)
			{
				Apply(this._OrdenesDetalleCollectionByIdProducto, "IdProducto", this.Id);
			}
		}
		
	}
	



	[Serializable]
	public partial class ProductosMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProductosMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductosMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Nombre, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductosMetadata.PropertyNames.Nombre;
			c.CharacterMaxLength = 80;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Precio, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductosMetadata.PropertyNames.Precio;
			c.NumericPrecision = 19;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Itbis, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductosMetadata.PropertyNames.Itbis;
			c.NumericPrecision = 4;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.IdUnidad, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductosMetadata.PropertyNames.IdUnidad;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('EA')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Bloqueado, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProductosMetadata.PropertyNames.Bloqueado;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Qty, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductosMetadata.PropertyNames.Qty;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductosMetadata.ColumnNames.Estatus, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProductosMetadata.PropertyNames.Estatus;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProductosMetadata Meta()
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
			 public const string Precio = "Precio";
			 public const string Itbis = "ITBIS";
			 public const string IdUnidad = "IdUnidad";
			 public const string Bloqueado = "Bloqueado";
			 public const string Qty = "Qty";
			 public const string Estatus = "Estatus";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Nombre = "Nombre";
			 public const string Precio = "Precio";
			 public const string Itbis = "Itbis";
			 public const string IdUnidad = "IdUnidad";
			 public const string Bloqueado = "Bloqueado";
			 public const string Qty = "Qty";
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
			lock (typeof(ProductosMetadata))
			{
				if(ProductosMetadata.mapDelegates == null)
				{
					ProductosMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductosMetadata.meta == null)
				{
					ProductosMetadata.meta = new ProductosMetadata();
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
				meta.AddTypeMap("Precio", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("Itbis", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("IdUnidad", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Bloqueado", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Estatus", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "Productos";
				meta.Destination = "Productos";
				
				meta.spInsert = "proc_ProductosInsert";				
				meta.spUpdate = "proc_ProductosUpdate";		
				meta.spDelete = "proc_ProductosDelete";
				meta.spLoadAll = "proc_ProductosLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProductosLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProductosMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
