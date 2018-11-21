﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestIntegraciones
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VSSECTEST")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertUnidad(Unidad instance);
    partial void UpdateUnidad(Unidad instance);
    partial void DeleteUnidad(Unidad instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::TestIntegraciones.Properties.Settings.Default.VSSECTESTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Unidad> Unidad
		{
			get
			{
				return this.GetTable<Unidad>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Unidad")]
	public partial class Unidad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDUN;
		
		private string _NombreUN;
		
		private string _RazonSocialUN;
		
		private int _IDHumanSiteUN;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDUNChanging(int value);
    partial void OnIDUNChanged();
    partial void OnNombreUNChanging(string value);
    partial void OnNombreUNChanged();
    partial void OnRazonSocialUNChanging(string value);
    partial void OnRazonSocialUNChanged();
    partial void OnIDHumanSiteUNChanging(int value);
    partial void OnIDHumanSiteUNChanged();
    #endregion
		
		public Unidad()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDUN
		{
			get
			{
				return this._IDUN;
			}
			set
			{
				if ((this._IDUN != value))
				{
					this.OnIDUNChanging(value);
					this.SendPropertyChanging();
					this._IDUN = value;
					this.SendPropertyChanged("IDUN");
					this.OnIDUNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUN", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string NombreUN
		{
			get
			{
				return this._NombreUN;
			}
			set
			{
				if ((this._NombreUN != value))
				{
					this.OnNombreUNChanging(value);
					this.SendPropertyChanging();
					this._NombreUN = value;
					this.SendPropertyChanged("NombreUN");
					this.OnNombreUNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RazonSocialUN", DbType="VarChar(600) NOT NULL", CanBeNull=false)]
		public string RazonSocialUN
		{
			get
			{
				return this._RazonSocialUN;
			}
			set
			{
				if ((this._RazonSocialUN != value))
				{
					this.OnRazonSocialUNChanging(value);
					this.SendPropertyChanging();
					this._RazonSocialUN = value;
					this.SendPropertyChanged("RazonSocialUN");
					this.OnRazonSocialUNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDHumanSiteUN", DbType="Int NOT NULL")]
		public int IDHumanSiteUN
		{
			get
			{
				return this._IDHumanSiteUN;
			}
			set
			{
				if ((this._IDHumanSiteUN != value))
				{
					this.OnIDHumanSiteUNChanging(value);
					this.SendPropertyChanging();
					this._IDHumanSiteUN = value;
					this.SendPropertyChanged("IDHumanSiteUN");
					this.OnIDHumanSiteUNChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
