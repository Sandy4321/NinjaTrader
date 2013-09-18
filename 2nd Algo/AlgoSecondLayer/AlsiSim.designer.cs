﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSecondLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ALSI_SIM")]
	public partial class AlsiSimDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblResult_5Min(tblResult_5Min instance);
    partial void UpdatetblResult_5Min(tblResult_5Min instance);
    partial void DeletetblResult_5Min(tblResult_5Min instance);
    partial void InserttblSequence(tblSequence instance);
    partial void UpdatetblSequence(tblSequence instance);
    partial void DeletetblSequence(tblSequence instance);
    partial void InserttblResult_5Min_D(tblResult_5Min_D instance);
    partial void UpdatetblResult_5Min_D(tblResult_5Min_D instance);
    partial void DeletetblResult_5Min_D(tblResult_5Min_D instance);
    partial void InserttblResult_5Min_SSPOP(tblResult_5Min_SSPOP instance);
    partial void UpdatetblResult_5Min_SSPOP(tblResult_5Min_SSPOP instance);
    partial void DeletetblResult_5Min_SSPOP(tblResult_5Min_SSPOP instance);
    #endregion
		
		public AlsiSimDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlsiSimDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlsiSimDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlsiSimDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblResult_5Min> tblResult_5Mins
		{
			get
			{
				return this.GetTable<tblResult_5Min>();
			}
		}
		
		public System.Data.Linq.Table<tblSequence> tblSequences
		{
			get
			{
				return this.GetTable<tblSequence>();
			}
		}
		
		public System.Data.Linq.Table<tblResult_5Min_D> tblResult_5Min_Ds
		{
			get
			{
				return this.GetTable<tblResult_5Min_D>();
			}
		}
		
		public System.Data.Linq.Table<tblResult_5Min_SSPOP> tblResult_5Min_SSPOPs
		{
			get
			{
				return this.GetTable<tblResult_5Min_SSPOP>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblResult_5Min")]
	public partial class tblResult_5Min : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sequence;
		
		private System.Nullable<double> _Profit;
		
		private System.Nullable<int> _Trades;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSequenceChanging(string value);
    partial void OnSequenceChanged();
    partial void OnProfitChanging(System.Nullable<double> value);
    partial void OnProfitChanged();
    partial void OnTradesChanging(System.Nullable<int> value);
    partial void OnTradesChanged();
    #endregion
		
		public tblResult_5Min()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sequence", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sequence
		{
			get
			{
				return this._Sequence;
			}
			set
			{
				if ((this._Sequence != value))
				{
					this.OnSequenceChanging(value);
					this.SendPropertyChanging();
					this._Sequence = value;
					this.SendPropertyChanged("Sequence");
					this.OnSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profit", DbType="Float")]
		public System.Nullable<double> Profit
		{
			get
			{
				return this._Profit;
			}
			set
			{
				if ((this._Profit != value))
				{
					this.OnProfitChanging(value);
					this.SendPropertyChanging();
					this._Profit = value;
					this.SendPropertyChanged("Profit");
					this.OnProfitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trades", DbType="Int")]
		public System.Nullable<int> Trades
		{
			get
			{
				return this._Trades;
			}
			set
			{
				if ((this._Trades != value))
				{
					this.OnTradesChanging(value);
					this.SendPropertyChanging();
					this._Trades = value;
					this.SendPropertyChanged("Trades");
					this.OnTradesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblSequence")]
	public partial class tblSequence : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sequence;
		
		private bool _Started;
		
		private bool _Completed;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSequenceChanging(string value);
    partial void OnSequenceChanged();
    partial void OnStartedChanging(bool value);
    partial void OnStartedChanged();
    partial void OnCompletedChanging(bool value);
    partial void OnCompletedChanged();
    #endregion
		
		public tblSequence()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sequence", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sequence
		{
			get
			{
				return this._Sequence;
			}
			set
			{
				if ((this._Sequence != value))
				{
					this.OnSequenceChanging(value);
					this.SendPropertyChanging();
					this._Sequence = value;
					this.SendPropertyChanged("Sequence");
					this.OnSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Started", DbType="Bit NOT NULL")]
		public bool Started
		{
			get
			{
				return this._Started;
			}
			set
			{
				if ((this._Started != value))
				{
					this.OnStartedChanging(value);
					this.SendPropertyChanging();
					this._Started = value;
					this.SendPropertyChanged("Started");
					this.OnStartedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Completed", DbType="Bit NOT NULL")]
		public bool Completed
		{
			get
			{
				return this._Completed;
			}
			set
			{
				if ((this._Completed != value))
				{
					this.OnCompletedChanging(value);
					this.SendPropertyChanging();
					this._Completed = value;
					this.SendPropertyChanged("Completed");
					this.OnCompletedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblResult_5Min_D")]
	public partial class tblResult_5Min_D : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sequence;
		
		private System.Nullable<double> _Profit;
		
		private System.Nullable<int> _Trades;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSequenceChanging(string value);
    partial void OnSequenceChanged();
    partial void OnProfitChanging(System.Nullable<double> value);
    partial void OnProfitChanged();
    partial void OnTradesChanging(System.Nullable<int> value);
    partial void OnTradesChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public tblResult_5Min_D()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sequence", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sequence
		{
			get
			{
				return this._Sequence;
			}
			set
			{
				if ((this._Sequence != value))
				{
					this.OnSequenceChanging(value);
					this.SendPropertyChanging();
					this._Sequence = value;
					this.SendPropertyChanged("Sequence");
					this.OnSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profit", DbType="Float")]
		public System.Nullable<double> Profit
		{
			get
			{
				return this._Profit;
			}
			set
			{
				if ((this._Profit != value))
				{
					this.OnProfitChanging(value);
					this.SendPropertyChanging();
					this._Profit = value;
					this.SendPropertyChanged("Profit");
					this.OnProfitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trades", DbType="Int")]
		public System.Nullable<int> Trades
		{
			get
			{
				return this._Trades;
			}
			set
			{
				if ((this._Trades != value))
				{
					this.OnTradesChanging(value);
					this.SendPropertyChanging();
					this._Trades = value;
					this.SendPropertyChanged("Trades");
					this.OnTradesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(50)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblResult_5Min_SSPOP")]
	public partial class tblResult_5Min_SSPOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sequence;
		
		private System.Nullable<double> _Profit;
		
		private System.Nullable<int> _Trades;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSequenceChanging(string value);
    partial void OnSequenceChanged();
    partial void OnProfitChanging(System.Nullable<double> value);
    partial void OnProfitChanged();
    partial void OnTradesChanging(System.Nullable<int> value);
    partial void OnTradesChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public tblResult_5Min_SSPOP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sequence", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sequence
		{
			get
			{
				return this._Sequence;
			}
			set
			{
				if ((this._Sequence != value))
				{
					this.OnSequenceChanging(value);
					this.SendPropertyChanging();
					this._Sequence = value;
					this.SendPropertyChanged("Sequence");
					this.OnSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profit", DbType="Float")]
		public System.Nullable<double> Profit
		{
			get
			{
				return this._Profit;
			}
			set
			{
				if ((this._Profit != value))
				{
					this.OnProfitChanging(value);
					this.SendPropertyChanging();
					this._Profit = value;
					this.SendPropertyChanged("Profit");
					this.OnProfitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trades", DbType="Int")]
		public System.Nullable<int> Trades
		{
			get
			{
				return this._Trades;
			}
			set
			{
				if ((this._Trades != value))
				{
					this.OnTradesChanging(value);
					this.SendPropertyChanging();
					this._Trades = value;
					this.SendPropertyChanged("Trades");
					this.OnTradesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(50)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
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
