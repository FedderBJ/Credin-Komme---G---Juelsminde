﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Resources
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TEST-NAV")]
	public partial class AbsenceRelationConnDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCredin_Employee_Absence_Kode_Relation(Credin_Employee_Absence_Kode_Relation instance);
    partial void UpdateCredin_Employee_Absence_Kode_Relation(Credin_Employee_Absence_Kode_Relation instance);
    partial void DeleteCredin_Employee_Absence_Kode_Relation(Credin_Employee_Absence_Kode_Relation instance);
    #endregion
		
		public AbsenceRelationConnDataContext() : 
				base(global::WindowsFormsApplication1.Properties.Settings.Default.TEST_NAVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AbsenceRelationConnDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AbsenceRelationConnDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AbsenceRelationConnDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AbsenceRelationConnDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Credin_Employee_Absence_Kode_Relation> Credin_Employee_Absence_Kode_Relations
		{
			get
			{
				return this.GetTable<Credin_Employee_Absence_Kode_Relation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Credin$Employee Absence Kode Relation]")]
	public partial class Credin_Employee_Absence_Kode_Relation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Data.Linq.Binary _timestamp;
		
		private string _Employee_No_;
		
		private string _Absence_Code;
		
		private string _Absence_Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntimestampChanging(System.Data.Linq.Binary value);
    partial void OntimestampChanged();
    partial void OnEmployee_No_Changing(string value);
    partial void OnEmployee_No_Changed();
    partial void OnAbsence_CodeChanging(string value);
    partial void OnAbsence_CodeChanged();
    partial void OnAbsence_NameChanging(string value);
    partial void OnAbsence_NameChanged();
    #endregion
		
		public Credin_Employee_Absence_Kode_Relation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Employee No_]", Storage="_Employee_No_", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string Employee_No_
		{
			get
			{
				return this._Employee_No_;
			}
			set
			{
				if ((this._Employee_No_ != value))
				{
					this.OnEmployee_No_Changing(value);
					this.SendPropertyChanging();
					this._Employee_No_ = value;
					this.SendPropertyChanged("Employee_No_");
					this.OnEmployee_No_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Absence Code]", Storage="_Absence_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string Absence_Code
		{
			get
			{
				return this._Absence_Code;
			}
			set
			{
				if ((this._Absence_Code != value))
				{
					this.OnAbsence_CodeChanging(value);
					this.SendPropertyChanging();
					this._Absence_Code = value;
					this.SendPropertyChanged("Absence_Code");
					this.OnAbsence_CodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Absence Name]", Storage="_Absence_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Absence_Name
		{
			get
			{
				return this._Absence_Name;
			}
			set
			{
				if ((this._Absence_Name != value))
				{
					this.OnAbsence_NameChanging(value);
					this.SendPropertyChanging();
					this._Absence_Name = value;
					this.SendPropertyChanged("Absence_Name");
					this.OnAbsence_NameChanged();
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
