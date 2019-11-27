
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
	/// Encapsulates the 'OrdenesDetalle' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(OrdenesDetalle))]	
	[XmlType("OrdenesDetalle")]
	public partial class OrdenesDetalle : esOrdenesDetalle
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new OrdenesDetalle();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new OrdenesDetalle();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new OrdenesDetalle();
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
	[XmlType("OrdenesDetalleCollection")]
	public partial class OrdenesDetalleCollection : esOrdenesDetalleCollection, IEnumerable<OrdenesDetalle>
	{
		public OrdenesDetalle FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(OrdenesDetalle))]
		public class OrdenesDetalleCollectionWCFPacket : esCollectionWCFPacket<OrdenesDetalleCollection>
		{
			public static implicit operator OrdenesDetalleCollection(OrdenesDetalleCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator OrdenesDetalleCollectionWCFPacket(OrdenesDetalleCollection collection)
			{
				return new OrdenesDetalleCollectionWCFPacket() { Collection = collection };
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
	public partial class OrdenesDetalleQuery : esOrdenesDetalleQuery
	{
		public OrdenesDetalleQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "OrdenesDetalleQuery";
		}
		
		
		override protected string GetConnectionName()
		{
			return "RTM";
		}			
	
		#region Explicit Casts
		
		public static explicit operator string(OrdenesDetalleQuery query)
		{
			return OrdenesDetalleQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrdenesDetalleQuery(string query)
		{
			return (OrdenesDetalleQuery)OrdenesDetalleQuery.SerializeHelper.FromXml(query, typeof(OrdenesDetalleQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrdenesDetalle : esEntity
	{
		public esOrdenesDetalle()
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
			OrdenesDetalleQuery query = new OrdenesDetalleQuery();
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
		/// Maps to OrdenesDetalle.Id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(OrdenesDetalleMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesDetalleMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.IdOrden
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? IdOrden
		{
			get
			{
				return base.GetSystemInt32(OrdenesDetalleMetadata.ColumnNames.IdOrden);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesDetalleMetadata.ColumnNames.IdOrden, value))
				{
					this._UpToOrdenesByIdOrden = null;
					this.OnPropertyChanged("UpToOrdenesByIdOrden");
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.IdOrden);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.Cantidad
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Cantidad
		{
			get
			{
				return base.GetSystemInt32(OrdenesDetalleMetadata.ColumnNames.Cantidad);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesDetalleMetadata.ColumnNames.Cantidad, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Cantidad);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.IdProducto
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? IdProducto
		{
			get
			{
				return base.GetSystemInt32(OrdenesDetalleMetadata.ColumnNames.IdProducto);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesDetalleMetadata.ColumnNames.IdProducto, value))
				{
					this._UpToProductosByIdProducto = null;
					this.OnPropertyChanged("UpToProductosByIdProducto");
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.IdProducto);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.Descripcion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Descripcion
		{
			get
			{
				return base.GetSystemString(OrdenesDetalleMetadata.ColumnNames.Descripcion);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesDetalleMetadata.ColumnNames.Descripcion, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Descripcion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.Precio
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Precio
		{
			get
			{
				return base.GetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Precio);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Precio, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Precio);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.UnidadMedida
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UnidadMedida
		{
			get
			{
				return base.GetSystemString(OrdenesDetalleMetadata.ColumnNames.UnidadMedida);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesDetalleMetadata.ColumnNames.UnidadMedida, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.UnidadMedida);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.LlevaITBIS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? LlevaITBIS
		{
			get
			{
				return base.GetSystemBoolean(OrdenesDetalleMetadata.ColumnNames.LlevaITBIS);
			}
			
			set
			{
				if(base.SetSystemBoolean(OrdenesDetalleMetadata.ColumnNames.LlevaITBIS, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.LlevaITBIS);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.Subtotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Subtotal
		{
			get
			{
				return base.GetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Subtotal);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Subtotal, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Subtotal);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.ITBIS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Itbis
		{
			get
			{
				return base.GetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Itbis);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Itbis, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Itbis);
				}
			}
		}		
		
		/// <summary>
		/// Maps to OrdenesDetalle.Total
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Total
		{
			get
			{
				return base.GetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Total);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdenesDetalleMetadata.ColumnNames.Total, value))
				{
					OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Total);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected Ordenes _UpToOrdenesByIdOrden;
		[CLSCompliant(false)]
		internal protected Productos _UpToProductosByIdProducto;
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
						case "IdOrden": this.str().IdOrden = (string)value; break;							
						case "Cantidad": this.str().Cantidad = (string)value; break;							
						case "IdProducto": this.str().IdProducto = (string)value; break;							
						case "Descripcion": this.str().Descripcion = (string)value; break;							
						case "Precio": this.str().Precio = (string)value; break;							
						case "UnidadMedida": this.str().UnidadMedida = (string)value; break;							
						case "LlevaITBIS": this.str().LlevaITBIS = (string)value; break;							
						case "Subtotal": this.str().Subtotal = (string)value; break;							
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
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Id);
							break;
						
						case "IdOrden":
						
							if (value == null || value is System.Int32)
								this.IdOrden = (System.Int32?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.IdOrden);
							break;
						
						case "Cantidad":
						
							if (value == null || value is System.Int32)
								this.Cantidad = (System.Int32?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Cantidad);
							break;
						
						case "IdProducto":
						
							if (value == null || value is System.Int32)
								this.IdProducto = (System.Int32?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.IdProducto);
							break;
						
						case "Precio":
						
							if (value == null || value is System.Decimal)
								this.Precio = (System.Decimal?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Precio);
							break;
						
						case "LlevaITBIS":
						
							if (value == null || value is System.Boolean)
								this.LlevaITBIS = (System.Boolean?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.LlevaITBIS);
							break;
						
						case "Subtotal":
						
							if (value == null || value is System.Decimal)
								this.Subtotal = (System.Decimal?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Subtotal);
							break;
						
						case "Itbis":
						
							if (value == null || value is System.Decimal)
								this.Itbis = (System.Decimal?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Itbis);
							break;
						
						case "Total":
						
							if (value == null || value is System.Decimal)
								this.Total = (System.Decimal?)value;
								OnPropertyChanged(OrdenesDetalleMetadata.PropertyNames.Total);
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
			public esStrings(esOrdenesDetalle entity)
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
				
			public System.String IdOrden
			{
				get
				{
					System.Int32? data = entity.IdOrden;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdOrden = null;
					else entity.IdOrden = Convert.ToInt32(value);
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
				
			public System.String IdProducto
			{
				get
				{
					System.Int32? data = entity.IdProducto;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdProducto = null;
					else entity.IdProducto = Convert.ToInt32(value);
				}
			}
				
			public System.String Descripcion
			{
				get
				{
					System.String data = entity.Descripcion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Descripcion = null;
					else entity.Descripcion = Convert.ToString(value);
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
				
			public System.String UnidadMedida
			{
				get
				{
					System.String data = entity.UnidadMedida;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnidadMedida = null;
					else entity.UnidadMedida = Convert.ToString(value);
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
				
			public System.String Subtotal
			{
				get
				{
					System.Decimal? data = entity.Subtotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Subtotal = null;
					else entity.Subtotal = Convert.ToDecimal(value);
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
			

			private esOrdenesDetalle entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrdenesDetalleMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrdenesDetalleQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenesDetalleQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenesDetalleQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrdenesDetalleQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrdenesDetalleQuery query;		
	}



	[Serializable]
	abstract public partial class esOrdenesDetalleCollection : esEntityCollection<OrdenesDetalle>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrdenesDetalleMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrdenesDetalleCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrdenesDetalleQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdenesDetalleQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdenesDetalleQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrdenesDetalleQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrdenesDetalleQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrdenesDetalleQuery)query);
		}

		#endregion
		
		private OrdenesDetalleQuery query;
	}



	[Serializable]
	abstract public partial class esOrdenesDetalleQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrdenesDetalleMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "IdOrden": return this.IdOrden;
				case "Cantidad": return this.Cantidad;
				case "IdProducto": return this.IdProducto;
				case "Descripcion": return this.Descripcion;
				case "Precio": return this.Precio;
				case "UnidadMedida": return this.UnidadMedida;
				case "LlevaITBIS": return this.LlevaITBIS;
				case "Subtotal": return this.Subtotal;
				case "Itbis": return this.Itbis;
				case "Total": return this.Total;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem IdOrden
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.IdOrden, esSystemType.Int32); }
		} 
		
		public esQueryItem Cantidad
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Cantidad, esSystemType.Int32); }
		} 
		
		public esQueryItem IdProducto
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.IdProducto, esSystemType.Int32); }
		} 
		
		public esQueryItem Descripcion
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Descripcion, esSystemType.String); }
		} 
		
		public esQueryItem Precio
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Precio, esSystemType.Decimal); }
		} 
		
		public esQueryItem UnidadMedida
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.UnidadMedida, esSystemType.String); }
		} 
		
		public esQueryItem LlevaITBIS
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.LlevaITBIS, esSystemType.Boolean); }
		} 
		
		public esQueryItem Subtotal
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Subtotal, esSystemType.Decimal); }
		} 
		
		public esQueryItem Itbis
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Itbis, esSystemType.Decimal); }
		} 
		
		public esQueryItem Total
		{
			get { return new esQueryItem(this, OrdenesDetalleMetadata.ColumnNames.Total, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class OrdenesDetalle : esOrdenesDetalle
	{

				
		#region UpToOrdenesByIdOrden - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_OrdenesDetalle_Ordenes
		/// </summary>

		[XmlIgnore]
					
		public Ordenes UpToOrdenesByIdOrden
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToOrdenesByIdOrden == null && IdOrden != null)
				{
					this._UpToOrdenesByIdOrden = new Ordenes();
					this._UpToOrdenesByIdOrden.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToOrdenesByIdOrden", this._UpToOrdenesByIdOrden);
					this._UpToOrdenesByIdOrden.Query.Where(this._UpToOrdenesByIdOrden.Query.Id == this.IdOrden);
					this._UpToOrdenesByIdOrden.Query.Load();
				}	
				return this._UpToOrdenesByIdOrden;
			}
			
			set
			{
				this.RemovePreSave("UpToOrdenesByIdOrden");
				

				if(value == null)
				{
					this.IdOrden = null;
					this._UpToOrdenesByIdOrden = null;
				}
				else
				{
					this.IdOrden = value.Id;
					this._UpToOrdenesByIdOrden = value;
					this.SetPreSave("UpToOrdenesByIdOrden", this._UpToOrdenesByIdOrden);
				}
				
			}
		}
		#endregion
		

				
		#region UpToProductosByIdProducto - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_OrdenesDetalle_Productos
		/// </summary>

		[XmlIgnore]
					
		public Productos UpToProductosByIdProducto
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToProductosByIdProducto == null && IdProducto != null)
				{
					this._UpToProductosByIdProducto = new Productos();
					this._UpToProductosByIdProducto.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToProductosByIdProducto", this._UpToProductosByIdProducto);
					this._UpToProductosByIdProducto.Query.Where(this._UpToProductosByIdProducto.Query.Id == this.IdProducto);
					this._UpToProductosByIdProducto.Query.Load();
				}	
				return this._UpToProductosByIdProducto;
			}
			
			set
			{
				this.RemovePreSave("UpToProductosByIdProducto");
				

				if(value == null)
				{
					this.IdProducto = null;
					this._UpToProductosByIdProducto = null;
				}
				else
				{
					this.IdProducto = value.Id;
					this._UpToProductosByIdProducto = value;
					this.SetPreSave("UpToProductosByIdProducto", this._UpToProductosByIdProducto);
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
			if(!this.es.IsDeleted && this._UpToOrdenesByIdOrden != null)
			{
				this.IdOrden = this._UpToOrdenesByIdOrden.Id;
			}
			if(!this.es.IsDeleted && this._UpToProductosByIdProducto != null)
			{
				this.IdProducto = this._UpToProductosByIdProducto.Id;
			}
		}
		
	}
	



	[Serializable]
	public partial class OrdenesDetalleMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrdenesDetalleMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.IdOrden, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.IdOrden;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Cantidad, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Cantidad;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.IdProducto, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.IdProducto;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Descripcion, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Descripcion;
			c.CharacterMaxLength = 80;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Precio, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Precio;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.UnidadMedida, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.UnidadMedida;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.LlevaITBIS, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.LlevaITBIS;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Subtotal, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Subtotal;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Itbis, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Itbis;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesDetalleMetadata.ColumnNames.Total, 10, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesDetalleMetadata.PropertyNames.Total;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrdenesDetalleMetadata Meta()
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
			 public const string IdOrden = "IdOrden";
			 public const string Cantidad = "Cantidad";
			 public const string IdProducto = "IdProducto";
			 public const string Descripcion = "Descripcion";
			 public const string Precio = "Precio";
			 public const string UnidadMedida = "UnidadMedida";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Subtotal = "Subtotal";
			 public const string Itbis = "ITBIS";
			 public const string Total = "Total";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string IdOrden = "IdOrden";
			 public const string Cantidad = "Cantidad";
			 public const string IdProducto = "IdProducto";
			 public const string Descripcion = "Descripcion";
			 public const string Precio = "Precio";
			 public const string UnidadMedida = "UnidadMedida";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Subtotal = "Subtotal";
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
			lock (typeof(OrdenesDetalleMetadata))
			{
				if(OrdenesDetalleMetadata.mapDelegates == null)
				{
					OrdenesDetalleMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrdenesDetalleMetadata.meta == null)
				{
					OrdenesDetalleMetadata.meta = new OrdenesDetalleMetadata();
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
				meta.AddTypeMap("IdOrden", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Cantidad", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IdProducto", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Descripcion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Precio", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("UnidadMedida", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LlevaITBIS", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("Itbis", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"));			
				
				
				
				meta.Source = "OrdenesDetalle";
				meta.Destination = "OrdenesDetalle";
				
				meta.spInsert = "proc_OrdenesDetalleInsert";				
				meta.spUpdate = "proc_OrdenesDetalleUpdate";		
				meta.spDelete = "proc_OrdenesDetalleDelete";
				meta.spLoadAll = "proc_OrdenesDetalleLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrdenesDetalleLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrdenesDetalleMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
