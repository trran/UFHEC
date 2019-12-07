
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 12/5/2019 1:50:00 PM
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
		/// Maps to Ordenes.ClienteId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ClienteId
		{
			get
			{
				return base.GetSystemInt32(OrdenesMetadata.ColumnNames.ClienteId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesMetadata.ColumnNames.ClienteId, value))
				{
					this._UpToClienteByClienteId = null;
					this.OnPropertyChanged("UpToClienteByClienteId");
					OnPropertyChanged(OrdenesMetadata.PropertyNames.ClienteId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.ClienteNombre
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ClienteNombre
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.ClienteNombre);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.ClienteNombre, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.ClienteNombre);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.ClienteDireccion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ClienteDireccion
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.ClienteDireccion);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.ClienteDireccion, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.ClienteDireccion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.DocumentType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DocumentType
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.DocumentType);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.DocumentType, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.DocumentType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Ordenes.DocumentNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DocumentNo
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.DocumentNo);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.DocumentNo, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.DocumentNo);
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
		/// Maps to Ordenes.IdMoneda
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String IdMoneda
		{
			get
			{
				return base.GetSystemString(OrdenesMetadata.ColumnNames.IdMoneda);
			}
			
			set
			{
				if(base.SetSystemString(OrdenesMetadata.ColumnNames.IdMoneda, value))
				{
					OnPropertyChanged(OrdenesMetadata.PropertyNames.IdMoneda);
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
		
		/// <summary>
		/// Maps to Ordenes.UsuarioId
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UsuarioId
		{
			get
			{
				return base.GetSystemInt32(OrdenesMetadata.ColumnNames.UsuarioId);
			}
			
			set
			{
				if(base.SetSystemInt32(OrdenesMetadata.ColumnNames.UsuarioId, value))
				{
					this._UpToUsuarioByUsuarioId = null;
					this.OnPropertyChanged("UpToUsuarioByUsuarioId");
					OnPropertyChanged(OrdenesMetadata.PropertyNames.UsuarioId);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected Cliente _UpToClienteByClienteId;
		[CLSCompliant(false)]
		internal protected Usuario _UpToUsuarioByUsuarioId;
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
						case "ClienteId": this.str().ClienteId = (string)value; break;							
						case "ClienteNombre": this.str().ClienteNombre = (string)value; break;							
						case "ClienteDireccion": this.str().ClienteDireccion = (string)value; break;							
						case "DocumentType": this.str().DocumentType = (string)value; break;							
						case "DocumentNo": this.str().DocumentNo = (string)value; break;							
						case "Telefono": this.str().Telefono = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "IdMoneda": this.str().IdMoneda = (string)value; break;							
						case "SubTotal": this.str().SubTotal = (string)value; break;							
						case "LlevaITBIS": this.str().LlevaITBIS = (string)value; break;							
						case "Itbis": this.str().Itbis = (string)value; break;							
						case "Total": this.str().Total = (string)value; break;							
						case "UsuarioId": this.str().UsuarioId = (string)value; break;
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
						
						case "ClienteId":
						
							if (value == null || value is System.Int32)
								this.ClienteId = (System.Int32?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.ClienteId);
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
						
						case "UsuarioId":
						
							if (value == null || value is System.Int32)
								this.UsuarioId = (System.Int32?)value;
								OnPropertyChanged(OrdenesMetadata.PropertyNames.UsuarioId);
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
				
			public System.String ClienteId
			{
				get
				{
					System.Int32? data = entity.ClienteId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ClienteId = null;
					else entity.ClienteId = Convert.ToInt32(value);
				}
			}
				
			public System.String ClienteNombre
			{
				get
				{
					System.String data = entity.ClienteNombre;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ClienteNombre = null;
					else entity.ClienteNombre = Convert.ToString(value);
				}
			}
				
			public System.String ClienteDireccion
			{
				get
				{
					System.String data = entity.ClienteDireccion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ClienteDireccion = null;
					else entity.ClienteDireccion = Convert.ToString(value);
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
				
			public System.String IdMoneda
			{
				get
				{
					System.String data = entity.IdMoneda;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdMoneda = null;
					else entity.IdMoneda = Convert.ToString(value);
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
				
			public System.String UsuarioId
			{
				get
				{
					System.Int32? data = entity.UsuarioId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UsuarioId = null;
					else entity.UsuarioId = Convert.ToInt32(value);
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
				case "ClienteId": return this.ClienteId;
				case "ClienteNombre": return this.ClienteNombre;
				case "ClienteDireccion": return this.ClienteDireccion;
				case "DocumentType": return this.DocumentType;
				case "DocumentNo": return this.DocumentNo;
				case "Telefono": return this.Telefono;
				case "Email": return this.Email;
				case "IdMoneda": return this.IdMoneda;
				case "SubTotal": return this.SubTotal;
				case "LlevaITBIS": return this.LlevaITBIS;
				case "Itbis": return this.Itbis;
				case "Total": return this.Total;
				case "UsuarioId": return this.UsuarioId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem ClienteId
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.ClienteId, esSystemType.Int32); }
		} 
		
		public esQueryItem ClienteNombre
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.ClienteNombre, esSystemType.String); }
		} 
		
		public esQueryItem ClienteDireccion
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.ClienteDireccion, esSystemType.String); }
		} 
		
		public esQueryItem DocumentType
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.DocumentType, esSystemType.String); }
		} 
		
		public esQueryItem DocumentNo
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.DocumentNo, esSystemType.String); }
		} 
		
		public esQueryItem Telefono
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Telefono, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem IdMoneda
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.IdMoneda, esSystemType.String); }
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
		
		public esQueryItem UsuarioId
		{
			get { return new esQueryItem(this, OrdenesMetadata.ColumnNames.UsuarioId, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class Ordenes : esOrdenes
	{

		#region OrdenDetalleCollectionByOrdenId - Zero To Many
		
		static public esPrefetchMap Prefetch_OrdenDetalleCollectionByOrdenId
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjectsRTM.Ordenes.OrdenDetalleCollectionByOrdenId_Delegate;
				map.PropertyName = "OrdenDetalleCollectionByOrdenId";
				map.MyColumnName = "OrdenId";
				map.ParentColumnName = "Id";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void OrdenDetalleCollectionByOrdenId_Delegate(esPrefetchParameters data)
		{
			OrdenesQuery parent = new OrdenesQuery(data.NextAlias());

			OrdenDetalleQuery me = data.You != null ? data.You as OrdenDetalleQuery : new OrdenDetalleQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Id == me.OrdenId);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_OrdenDetalle_Ordenes
		/// </summary>

		[XmlIgnore]
		public OrdenDetalleCollection OrdenDetalleCollectionByOrdenId
		{
			get
			{
				if(this._OrdenDetalleCollectionByOrdenId == null)
				{
					this._OrdenDetalleCollectionByOrdenId = new OrdenDetalleCollection();
					this._OrdenDetalleCollectionByOrdenId.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("OrdenDetalleCollectionByOrdenId", this._OrdenDetalleCollectionByOrdenId);
				
					if (this.Id != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._OrdenDetalleCollectionByOrdenId.Query.Where(this._OrdenDetalleCollectionByOrdenId.Query.OrdenId == this.Id);
							this._OrdenDetalleCollectionByOrdenId.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._OrdenDetalleCollectionByOrdenId.fks.Add(OrdenDetalleMetadata.ColumnNames.OrdenId, this.Id);
					}
				}

				return this._OrdenDetalleCollectionByOrdenId;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._OrdenDetalleCollectionByOrdenId != null) 
				{ 
					this.RemovePostSave("OrdenDetalleCollectionByOrdenId"); 
					this._OrdenDetalleCollectionByOrdenId = null;
					
				} 
			} 			
		}
			
		
		private OrdenDetalleCollection _OrdenDetalleCollectionByOrdenId;
		#endregion

				
		#region UpToClienteByClienteId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_Ordenes_Cliente
		/// </summary>

		[XmlIgnore]
					
		public Cliente UpToClienteByClienteId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToClienteByClienteId == null && ClienteId != null)
				{
					this._UpToClienteByClienteId = new Cliente();
					this._UpToClienteByClienteId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToClienteByClienteId", this._UpToClienteByClienteId);
					this._UpToClienteByClienteId.Query.Where(this._UpToClienteByClienteId.Query.Id == this.ClienteId);
					this._UpToClienteByClienteId.Query.Load();
				}	
				return this._UpToClienteByClienteId;
			}
			
			set
			{
				this.RemovePreSave("UpToClienteByClienteId");
				

				if(value == null)
				{
					this.ClienteId = null;
					this._UpToClienteByClienteId = null;
				}
				else
				{
					this.ClienteId = value.Id;
					this._UpToClienteByClienteId = value;
					this.SetPreSave("UpToClienteByClienteId", this._UpToClienteByClienteId);
				}
				
			}
		}
		#endregion
		

				
		#region UpToUsuarioByUsuarioId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_Ordenes_Usuario
		/// </summary>

		[XmlIgnore]
					
		public Usuario UpToUsuarioByUsuarioId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToUsuarioByUsuarioId == null && UsuarioId != null)
				{
					this._UpToUsuarioByUsuarioId = new Usuario();
					this._UpToUsuarioByUsuarioId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToUsuarioByUsuarioId", this._UpToUsuarioByUsuarioId);
					this._UpToUsuarioByUsuarioId.Query.Where(this._UpToUsuarioByUsuarioId.Query.Id == this.UsuarioId);
					this._UpToUsuarioByUsuarioId.Query.Load();
				}	
				return this._UpToUsuarioByUsuarioId;
			}
			
			set
			{
				this.RemovePreSave("UpToUsuarioByUsuarioId");
				

				if(value == null)
				{
					this.UsuarioId = null;
					this._UpToUsuarioByUsuarioId = null;
				}
				else
				{
					this.UsuarioId = value.Id;
					this._UpToUsuarioByUsuarioId = value;
					this.SetPreSave("UpToUsuarioByUsuarioId", this._UpToUsuarioByUsuarioId);
				}
				
			}
		}
		#endregion
		

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "OrdenDetalleCollectionByOrdenId":
					coll = this.OrdenDetalleCollectionByOrdenId;
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
			
			props.Add(new esPropertyDescriptor(this, "OrdenDetalleCollectionByOrdenId", typeof(OrdenDetalleCollection), new OrdenDetalle()));
		
			return props;
		}
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToClienteByClienteId != null)
			{
				this.ClienteId = this._UpToClienteByClienteId.Id;
			}
			if(!this.es.IsDeleted && this._UpToUsuarioByUsuarioId != null)
			{
				this.UsuarioId = this._UpToUsuarioByUsuarioId.Id;
			}
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
			if(this._OrdenDetalleCollectionByOrdenId != null)
			{
				Apply(this._OrdenDetalleCollectionByOrdenId, "OrdenId", this.Id);
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
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.ClienteId, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesMetadata.PropertyNames.ClienteId;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.ClienteNombre, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.ClienteNombre;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.ClienteDireccion, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.ClienteDireccion;
			c.CharacterMaxLength = 512;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.DocumentType, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.DocumentType;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.DocumentNo, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.DocumentNo;
			c.CharacterMaxLength = 11;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Telefono, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.Telefono;
			c.CharacterMaxLength = 27;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Email, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 128;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.IdMoneda, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdenesMetadata.PropertyNames.IdMoneda;
			c.CharacterMaxLength = 3;
			c.HasDefault = true;
			c.Default = @"(N'DOP')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.SubTotal, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.SubTotal;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.LlevaITBIS, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = OrdenesMetadata.PropertyNames.LlevaITBIS;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Itbis, 11, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.Itbis;
			c.NumericPrecision = 22;
			c.NumericScale = 6;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.Total, 12, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdenesMetadata.PropertyNames.Total;
			c.NumericPrecision = 23;
			c.NumericScale = 6;
			c.IsNullable = true;
			c.IsComputed = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdenesMetadata.ColumnNames.UsuarioId, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OrdenesMetadata.PropertyNames.UsuarioId;
			c.NumericPrecision = 10;
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
			 public const string ClienteId = "ClienteId";
			 public const string ClienteNombre = "ClienteNombre";
			 public const string ClienteDireccion = "ClienteDireccion";
			 public const string DocumentType = "DocumentType";
			 public const string DocumentNo = "DocumentNo";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string IdMoneda = "IdMoneda";
			 public const string SubTotal = "SubTotal";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Itbis = "ITBIS";
			 public const string Total = "Total";
			 public const string UsuarioId = "UsuarioId";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string ClienteId = "ClienteId";
			 public const string ClienteNombre = "ClienteNombre";
			 public const string ClienteDireccion = "ClienteDireccion";
			 public const string DocumentType = "DocumentType";
			 public const string DocumentNo = "DocumentNo";
			 public const string Telefono = "Telefono";
			 public const string Email = "Email";
			 public const string IdMoneda = "IdMoneda";
			 public const string SubTotal = "SubTotal";
			 public const string LlevaITBIS = "LlevaITBIS";
			 public const string Itbis = "Itbis";
			 public const string Total = "Total";
			 public const string UsuarioId = "UsuarioId";
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
				meta.AddTypeMap("ClienteId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ClienteNombre", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ClienteDireccion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DocumentType", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("DocumentNo", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telefono", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IdMoneda", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SubTotal", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("LlevaITBIS", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Itbis", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Total", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("UsuarioId", new esTypeMap("int", "System.Int32"));			
				
				
				
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
