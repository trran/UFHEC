
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
	/// Encapsulates the 'Ordenes' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Ordenes))]	
	[XmlType("Ordenes")]
	public partial class Ordenes : esOrdenes
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Ordenes();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Ordenes();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Ordenes();
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
	[XmlType("OrdenesCollection")]
	public partial class OrdenesCollection : esOrdenesCollection, IEnumerable<Ordenes>
	{
		public Ordenes FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Ordenes))]
		public class OrdenesCollectionWCFPacket : esCollectionWCFPacket<OrdenesCollection>
		{
			public static implicit operator OrdenesCollection(OrdenesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator OrdenesCollectionWCFPacket(OrdenesCollection collection)
			{
				return new OrdenesCollectionWCFPacket() { Collection = collection };
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
	public partial class OrdenesQuery : esOrdenesQuery
	{
		public OrdenesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "OrdenesQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(OrdenesQuery query)
		{
			return OrdenesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrdenesQuery(string query)
		{
			return (OrdenesQuery)OrdenesQuery.SerializeHelper.FromXml(query, typeof(OrdenesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrdenes : esEntity
	{
		public esOrdenes()
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
			OrdenesQuery query = new OrdenesQuery();
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
		/// Maps to Ordenes.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(OrdenesMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.IdConsignatario
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? IdConsignatario
		{
			get
			{
				return base.GetSystemInt32(OrdenesMetadata.ColumnNames.IdConsignatario);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesMetadata.ColumnNames.IdConsignatario, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.IdConsignatario);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.NombreConsignatario
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NombreConsignatario
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.NombreConsignatario);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.NombreConsignatario, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.NombreConsignatario);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.Direccion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Direccion
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.Direccion);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.Direccion, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Direccion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.Telefono
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Telefono
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.Telefono);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.Telefono, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Telefono);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Email);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.SubTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? SubTotal
		{
			get
			{
				return base.GetSystemDecimal(OrdenesMetadata.ColumnNames.SubTotal);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesMetadata.ColumnNames.SubTotal, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.SubTotal);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.LlevaITBIS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? LlevaITBIS
		{
			get
			{
				return base.GetSystemBoolean(OrdenesMetadata.ColumnNames.LlevaITBIS);
			}
			
			set
			{
				if(base.SetSystemBoolean(OrdenesMetadata.ColumnNames.LlevaITBIS, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.LlevaITBIS);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.ITBIS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Itbis
		{
			get
			{
				return base.GetSystemDecimal(OrdenesMetadata.ColumnNames.Itbis);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesMetadata.ColumnNames.Itbis, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Itbis);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.Total
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Total
		{
			get
			{
				return base.GetSystemDecimal(OrdenesMetadata.ColumnNames.Total);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesMetadata.ColumnNames.Total, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.Total);
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
						case "IdConsignatario": this.str().IdConsignatario = (string)value; break;							
						case "NombreConsignatario": this.str().NombreConsignatario = (string)value; break;							
						case "Direccion": this.str().Direccion = (string)value; break;							
						case "Telefono": this.str().Telefono = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "SubTotal": this.str().SubTotal = (string)value; break;							
						case "LlevaITBIS": this.str().LlevaITBIS = (string)value; break;							
						case "Itbis": this.str().Itbis = (string)value; break;							
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
								OnPropertyChanged(OrdenesMetadata.PropertyNames.Id);
							break;
						
						case "IdConsignatario":
						
							if (value == null || value is System.Int32)
								this.IdConsignatario = (System.Int32?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.IdConsignatario);
							break;
						
						case "SubTotal":
						
							if (value == null || value is System.Decimal)
								this.SubTotal = (System.Decimal?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.SubTotal);
							break;
						
						case "LlevaITBIS":
						
							if (value == null || value is System.Boolean)
								this.LlevaITBIS = (System.Boolean?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.LlevaITBIS);
							break;
						
						case "Itbis":
						
							if (value == null || value is System.Decimal)
								this.Itbis = (System.Decimal?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.Itbis);
							break;
						
						case "Total":
						
							if (value == null || value is System.Decimal)
								this.Total = (System.Decimal?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.Total);
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
			public esStrings(esOrdenes entity)
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
				
			public System.String IdConsignatario
			{
				get
				{
					System.Int32? data = entity.IdConsignatario;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdConsignatario = null;
					else entity.IdConsignatario = Convert.ToInt32(value);
				}
			}
				
			public System.String NombreConsignatario
			{
				get
				{
					System.String data = entity.NombreConsignatario;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NombreConsignatario = null;
					else entity.NombreConsignatario = Convert.ToString(value);
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
				
			public System.String SubTotal
			{
				get
				{
					System.Decimal? data = entity.SubTotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubTotal = null;
					else entity.SubTotal = Convert.ToDecimal(value);
				}
			}
				
			public System.String LlevaITBIS
			{
				get
				{
					System.Boolean? data = entity.LlevaITBIS;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LlevaITBIS = null;
					else entity.LlevaITBIS = Convert.ToBoolean(value);
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
			

			private esOrdenes entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrdenesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrdenesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrdenesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrdenesQuery query;		
	}



	[Serializable]
	abstract public partial class esOrdenesCollection : esEntityCollection<Ordenes>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrdenesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrdenesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrdenesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrdenesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrdenesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrdenesQuery)query);
		}

		#endregion
		
		private OrdenesQuery query;
	}



	[Serializable]
	abstract public partial class esOrdenesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrdenesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "IdConsignatario": return this.IdConsignatario;
				case "NombreConsignatario": return this.NombreConsignatario;
				case "Direccion": return this.Direccion;
				case "Telefono": return this.Telefono;
				case "Email": return this.Email;
				case "SubTotal": return this.SubTotal;
				case "LlevaITBIS": return this.LlevaITBIS;
				case "Itbis": return this.Itbis;
				case "Total": return this.Total;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem IdConsignatario
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.IdConsignatario, esSystemType.Int32); }
		} 
		
		public esQueryItem NombreConsignatario
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.NombreConsignatario, esSystemType.String); }
		} 
		
		public esQueryItem Direccion
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Direccion, esSystemType.String); }
		} 
		
		public esQueryItem Telefono
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Telefono, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem SubTotal
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.SubTotal, esSystemType.Decimal); }
		} 
		
		public esQueryItem LlevaITBIS
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.LlevaITBIS, esSystemType.Boolean); }
		} 
		
		public esQueryItem Itbis
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Itbis, esSystemType.Decimal); }
		} 
		
		public esQueryItem Total
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Total, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Ordenes : esOrdenes
	{

		#region OrdenesDetalleCollectionByIdOrden - Zero To Many

        public override void Save()
        {
            base.Save();
        }
		static public esPrefetchMap Prefetch_OrdenesDetalleCollectionByIdOrden
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjectsRTM.Ordenes.OrdenesDetalleCollectionByIdOrden_Delegate;
				map.PropertyName = "OrdenesDetalleCollectionByIdOrden";
				map.MyColumnName = "IdOrden";
				map.ParentColumnName = "Id";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void OrdenesDetalleCollectionByIdOrden_Delegate(esPrefetchParameters data)
		{
			OrdenesQuery parent = new OrdenesQuery(data.NextAlias());

			OrdenesDetalleQuery me = data.You != null ? data.You as OrdenesDetalleQuery : new OrdenesDetalleQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Id == me.IdOrden);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_OrdenesDetalle_Ordenes
		/// </summary>

		[XmlIgnore]
		public OrdenesDetalleCollection OrdenesDetalleCollectionByIdOrden
		{
			get
			{
				if(this._OrdenesDetalleCollectionByIdOrden == null)
				{
					this._OrdenesDetalleCollectionByIdOrden = new OrdenesDetalleCollection();
					this._OrdenesDetalleCollectionByIdOrden.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("OrdenesDetalleCollectionByIdOrden", this._OrdenesDetalleCollectionByIdOrden);
				
					if (this.Id != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._OrdenesDetalleCollectionByIdOrden.Query.Where(this._OrdenesDetalleCollectionByIdOrden.Query.IdOrden == this.Id);
							this._OrdenesDetalleCollectionByIdOrden.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._OrdenesDetalleCollectionByIdOrden.fks.Add(OrdenesDetalleMetadata.ColumnNames.IdOrden, this.Id);
					}
				}

				return this._OrdenesDetalleCollectionByIdOrden;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._OrdenesDetalleCollectionByIdOrden != null) 
				{ 
					this.RemovePostSave("OrdenesDetalleCollectionByIdOrden"); 
					this._OrdenesDetalleCollectionByIdOrden = null;
					
				} 
			} 			
		}
			
		
		private OrdenesDetalleCollection _OrdenesDetalleCollectionByIdOrden;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "OrdenesDetalleCollectionByIdOrden":
					coll = this.OrdenesDetalleCollectionByIdOrden;
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
			
			props.Add(new esPropertyDescriptor(this, "OrdenesDetalleCollectionByIdOrden", typeof(OrdenesDetalleCollection), new OrdenesDetalle()));
		
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
			if(this._OrdenesDetalleCollectionByIdOrden != null)
			{
				Apply(this._OrdenesDetalleCollectionByIdOrden, "IdOrden", this.Id);
			}
		}
		
	}
	



	[Serializable]
	public partial class OrdenesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrdenesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.IdConsignatario, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesMetadata.PropertyNames.IdConsignatario;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.NombreConsignatario, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.NombreConsignatario;
			c.CharacterMaxLength = 250;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Direccion, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.Direccion;
			c.CharacterMaxLength = 250;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Telefono, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.Telefono;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Email, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.SubTotal, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.SubTotal;
			c.NumericPrecision = 19;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.LlevaITBIS, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = OrdenesMetadata.PropertyNames.LlevaITBIS;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Itbis, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.Itbis;
			c.NumericPrecision = 19;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Total, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.Total;
			c.NumericPrecision = 19;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrdenesMetadata Meta()
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
			 public const string IdConsignatario = "IdConsignatario";
			 public const string NombreConsignatario = "NombreConsignatario";
			 public const string Direccion = "Direccion";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string SubTotal = "SubTotal";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Itbis = "ITBIS";
			 public const string Total = "Total";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string IdConsignatario = "IdConsignatario";
			 public const string NombreConsignatario = "NombreConsignatario";
			 public const string Direccion = "Direccion";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string SubTotal = "SubTotal";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Itbis = "Itbis";
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
			lock (typeof(OrdenesMetadata))
			{
				if(OrdenesMetadata.mapDelegates == null)
				{
					OrdenesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrdenesMetadata.meta == null)
				{
					OrdenesMetadata.meta = new OrdenesMetadata();
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
				meta.AddTypeMap("IdConsignatario", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("NombreConsignatario", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Direccion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telefono", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SubTotal", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("LlevaITBIS", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Itbis", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"));			
				
				
				
				meta.Source = "Ordenes";
				meta.Destination = "Ordenes";
				
				meta.spInsert = "proc_OrdenesInsert";				
				meta.spUpdate = "proc_OrdenesUpdate";		
				meta.spDelete = "proc_OrdenesDelete";
				meta.spLoadAll = "proc_OrdenesLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrdenesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrdenesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
