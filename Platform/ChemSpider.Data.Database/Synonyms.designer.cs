﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChemSpider.Data.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ChemSpider")]
	public partial class SynonymsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcompounds_synonym(compounds_synonym instance);
    partial void Updatecompounds_synonym(compounds_synonym instance);
    partial void Deletecompounds_synonym(compounds_synonym instance);
    partial void Insertsynonym(synonym instance);
    partial void Updatesynonym(synonym instance);
    partial void Deletesynonym(synonym instance);
    partial void Insertsynonyms_synonyms_flag(synonyms_synonyms_flag instance);
    partial void Updatesynonyms_synonyms_flag(synonyms_synonyms_flag instance);
    partial void Deletesynonyms_synonyms_flag(synonyms_synonyms_flag instance);
    partial void Insertsynonyms_flag(synonyms_flag instance);
    partial void Updatesynonyms_flag(synonyms_flag instance);
    partial void Deletesynonyms_flag(synonyms_flag instance);
    partial void Insertsynonyms_lookup(synonyms_lookup instance);
    partial void Updatesynonyms_lookup(synonyms_lookup instance);
    partial void Deletesynonyms_lookup(synonyms_lookup instance);
    partial void Insertsystematic_name(systematic_name instance);
    partial void Updatesystematic_name(systematic_name instance);
    partial void Deletesystematic_name(systematic_name instance);
    partial void Insertlanguage(language instance);
    partial void Updatelanguage(language instance);
    partial void Deletelanguage(language instance);
    #endregion
		
		public SynonymsDataContext() : 
				base(global::ChemSpider.Data.Database.Properties.Settings.Default.ChemSpiderConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public SynonymsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SynonymsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SynonymsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SynonymsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<compounds_synonym> compounds_synonyms
		{
			get
			{
				return this.GetTable<compounds_synonym>();
			}
		}
		
		public System.Data.Linq.Table<synonym> synonyms
		{
			get
			{
				return this.GetTable<synonym>();
			}
		}
		
		public System.Data.Linq.Table<synonyms_synonyms_flag> synonyms_synonyms_flags
		{
			get
			{
				return this.GetTable<synonyms_synonyms_flag>();
			}
		}
		
		public System.Data.Linq.Table<synonyms_flag> synonyms_flags
		{
			get
			{
				return this.GetTable<synonyms_flag>();
			}
		}
		
		public System.Data.Linq.Table<synonyms_lookup> synonyms_lookups
		{
			get
			{
				return this.GetTable<synonyms_lookup>();
			}
		}
		
		public System.Data.Linq.Table<systematic_name> systematic_names
		{
			get
			{
				return this.GetTable<systematic_name>();
			}
		}
		
		public System.Data.Linq.Table<language> languages
		{
			get
			{
				return this.GetTable<language>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.compounds_synonyms")]
	public partial class compounds_synonym : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cmp_id;
		
		private int _syn_id;
		
		private System.Nullable<char> _opinion;
		
		private bool _approved_yn;
		
		private System.Nullable<System.DateTime> _date_changed;
		
		private bool _deleted_yn;
		
		private System.Nullable<int> _usr_id;
		
		private System.Nullable<int> _cur_id;
		
		private bool _common_name_yn;
		
		private System.Nullable<int> _csid;
		
		private System.Nullable<int> _dep_id;
		
		private System.DateTime _date_created;
		
		private System.DateTime _date_updated;
		
		private EntityRef<synonym> _synonym;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncmp_idChanging(int value);
    partial void Oncmp_idChanged();
    partial void Onsyn_idChanging(int value);
    partial void Onsyn_idChanged();
    partial void OnopinionChanging(System.Nullable<char> value);
    partial void OnopinionChanged();
    partial void Onapproved_ynChanging(bool value);
    partial void Onapproved_ynChanged();
    partial void Ondate_changedChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_changedChanged();
    partial void Ondeleted_ynChanging(bool value);
    partial void Ondeleted_ynChanged();
    partial void Onusr_idChanging(System.Nullable<int> value);
    partial void Onusr_idChanged();
    partial void Oncur_idChanging(System.Nullable<int> value);
    partial void Oncur_idChanged();
    partial void Oncommon_name_ynChanging(bool value);
    partial void Oncommon_name_ynChanged();
    partial void OncsidChanging(System.Nullable<int> value);
    partial void OncsidChanged();
    partial void Ondep_idChanging(System.Nullable<int> value);
    partial void Ondep_idChanged();
    partial void Ondate_createdChanging(System.DateTime value);
    partial void Ondate_createdChanged();
    partial void Ondate_updatedChanging(System.DateTime value);
    partial void Ondate_updatedChanged();
    #endregion
		
		public compounds_synonym()
		{
			this._synonym = default(EntityRef<synonym>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmp_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cmp_id
		{
			get
			{
				return this._cmp_id;
			}
			set
			{
				if ((this._cmp_id != value))
				{
					this.Oncmp_idChanging(value);
					this.SendPropertyChanging();
					this._cmp_id = value;
					this.SendPropertyChanged("cmp_id");
					this.Oncmp_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_syn_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int syn_id
		{
			get
			{
				return this._syn_id;
			}
			set
			{
				if ((this._syn_id != value))
				{
					if (this._synonym.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsyn_idChanging(value);
					this.SendPropertyChanging();
					this._syn_id = value;
					this.SendPropertyChanged("syn_id");
					this.Onsyn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opinion", DbType="Char(1)")]
		public System.Nullable<char> opinion
		{
			get
			{
				return this._opinion;
			}
			set
			{
				if ((this._opinion != value))
				{
					this.OnopinionChanging(value);
					this.SendPropertyChanging();
					this._opinion = value;
					this.SendPropertyChanged("opinion");
					this.OnopinionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_approved_yn", DbType="Bit NOT NULL")]
		public bool approved_yn
		{
			get
			{
				return this._approved_yn;
			}
			set
			{
				if ((this._approved_yn != value))
				{
					this.Onapproved_ynChanging(value);
					this.SendPropertyChanging();
					this._approved_yn = value;
					this.SendPropertyChanged("approved_yn");
					this.Onapproved_ynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_changed", DbType="DateTime")]
		public System.Nullable<System.DateTime> date_changed
		{
			get
			{
				return this._date_changed;
			}
			set
			{
				if ((this._date_changed != value))
				{
					this.Ondate_changedChanging(value);
					this.SendPropertyChanging();
					this._date_changed = value;
					this.SendPropertyChanged("date_changed");
					this.Ondate_changedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted_yn", DbType="Bit NOT NULL")]
		public bool deleted_yn
		{
			get
			{
				return this._deleted_yn;
			}
			set
			{
				if ((this._deleted_yn != value))
				{
					this.Ondeleted_ynChanging(value);
					this.SendPropertyChanging();
					this._deleted_yn = value;
					this.SendPropertyChanged("deleted_yn");
					this.Ondeleted_ynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usr_id", DbType="Int")]
		public System.Nullable<int> usr_id
		{
			get
			{
				return this._usr_id;
			}
			set
			{
				if ((this._usr_id != value))
				{
					this.Onusr_idChanging(value);
					this.SendPropertyChanging();
					this._usr_id = value;
					this.SendPropertyChanged("usr_id");
					this.Onusr_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cur_id", DbType="Int")]
		public System.Nullable<int> cur_id
		{
			get
			{
				return this._cur_id;
			}
			set
			{
				if ((this._cur_id != value))
				{
					this.Oncur_idChanging(value);
					this.SendPropertyChanging();
					this._cur_id = value;
					this.SendPropertyChanged("cur_id");
					this.Oncur_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_common_name_yn", DbType="Bit NOT NULL")]
		public bool common_name_yn
		{
			get
			{
				return this._common_name_yn;
			}
			set
			{
				if ((this._common_name_yn != value))
				{
					this.Oncommon_name_ynChanging(value);
					this.SendPropertyChanging();
					this._common_name_yn = value;
					this.SendPropertyChanged("common_name_yn");
					this.Oncommon_name_ynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_csid", DbType="Int")]
		public System.Nullable<int> csid
		{
			get
			{
				return this._csid;
			}
			set
			{
				if ((this._csid != value))
				{
					this.OncsidChanging(value);
					this.SendPropertyChanging();
					this._csid = value;
					this.SendPropertyChanged("csid");
					this.OncsidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dep_id", DbType="Int")]
		public System.Nullable<int> dep_id
		{
			get
			{
				return this._dep_id;
			}
			set
			{
				if ((this._dep_id != value))
				{
					this.Ondep_idChanging(value);
					this.SendPropertyChanging();
					this._dep_id = value;
					this.SendPropertyChanged("dep_id");
					this.Ondep_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_created", DbType="DateTime NOT NULL")]
		public System.DateTime date_created
		{
			get
			{
				return this._date_created;
			}
			set
			{
				if ((this._date_created != value))
				{
					this.Ondate_createdChanging(value);
					this.SendPropertyChanging();
					this._date_created = value;
					this.SendPropertyChanged("date_created");
					this.Ondate_createdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_updated", AutoSync=AutoSync.Always, DbType="DateTime NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.DateTime date_updated
		{
			get
			{
				return this._date_updated;
			}
			set
			{
				if ((this._date_updated != value))
				{
					this.Ondate_updatedChanging(value);
					this.SendPropertyChanging();
					this._date_updated = value;
					this.SendPropertyChanged("date_updated");
					this.Ondate_updatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="synonym_compounds_synonym", Storage="_synonym", ThisKey="syn_id", OtherKey="syn_id", IsForeignKey=true)]
		public synonym synonym
		{
			get
			{
				return this._synonym.Entity;
			}
			set
			{
				synonym previousValue = this._synonym.Entity;
				if (((previousValue != value) 
							|| (this._synonym.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._synonym.Entity = null;
						previousValue.compounds_synonyms.Remove(this);
					}
					this._synonym.Entity = value;
					if ((value != null))
					{
						value.compounds_synonyms.Add(this);
						this._syn_id = value.syn_id;
					}
					else
					{
						this._syn_id = default(int);
					}
					this.SendPropertyChanged("synonym");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.synonyms")]
	public partial class synonym : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _syn_id;
		
		private string _synonym1;
		
		private string _lang_id1;
		
		private bool _checked_yn;
		
		private bool _deleted_yn;
		
		private System.DateTime _date_created;
		
		private System.Nullable<System.DateTime> _date_updated;
		
		private EntitySet<compounds_synonym> _compounds_synonyms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsyn_idChanging(int value);
    partial void Onsyn_idChanged();
    partial void Onsynonym1Changing(string value);
    partial void Onsynonym1Changed();
    partial void Onlang_id1Changing(string value);
    partial void Onlang_id1Changed();
    partial void Onchecked_ynChanging(bool value);
    partial void Onchecked_ynChanged();
    partial void Ondeleted_ynChanging(bool value);
    partial void Ondeleted_ynChanged();
    partial void Ondate_createdChanging(System.DateTime value);
    partial void Ondate_createdChanged();
    partial void Ondate_updatedChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_updatedChanged();
    #endregion
		
		public synonym()
		{
			this._compounds_synonyms = new EntitySet<compounds_synonym>(new Action<compounds_synonym>(this.attach_compounds_synonyms), new Action<compounds_synonym>(this.detach_compounds_synonyms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_syn_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int syn_id
		{
			get
			{
				return this._syn_id;
			}
			set
			{
				if ((this._syn_id != value))
				{
					this.Onsyn_idChanging(value);
					this.SendPropertyChanging();
					this._syn_id = value;
					this.SendPropertyChanged("syn_id");
					this.Onsyn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="synonym", Storage="_synonym1", DbType="NVarChar(448) NOT NULL", CanBeNull=false)]
		public string synonym1
		{
			get
			{
				return this._synonym1;
			}
			set
			{
				if ((this._synonym1 != value))
				{
					this.Onsynonym1Changing(value);
					this.SendPropertyChanging();
					this._synonym1 = value;
					this.SendPropertyChanged("synonym1");
					this.Onsynonym1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lang_id1", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string lang_id1
		{
			get
			{
				return this._lang_id1;
			}
			set
			{
				if ((this._lang_id1 != value))
				{
					this.Onlang_id1Changing(value);
					this.SendPropertyChanging();
					this._lang_id1 = value;
					this.SendPropertyChanged("lang_id1");
					this.Onlang_id1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checked_yn", DbType="Bit NOT NULL")]
		public bool checked_yn
		{
			get
			{
				return this._checked_yn;
			}
			set
			{
				if ((this._checked_yn != value))
				{
					this.Onchecked_ynChanging(value);
					this.SendPropertyChanging();
					this._checked_yn = value;
					this.SendPropertyChanged("checked_yn");
					this.Onchecked_ynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted_yn", DbType="Bit NOT NULL")]
		public bool deleted_yn
		{
			get
			{
				return this._deleted_yn;
			}
			set
			{
				if ((this._deleted_yn != value))
				{
					this.Ondeleted_ynChanging(value);
					this.SendPropertyChanging();
					this._deleted_yn = value;
					this.SendPropertyChanged("deleted_yn");
					this.Ondeleted_ynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_created", DbType="DateTime NOT NULL")]
		public System.DateTime date_created
		{
			get
			{
				return this._date_created;
			}
			set
			{
				if ((this._date_created != value))
				{
					this.Ondate_createdChanging(value);
					this.SendPropertyChanging();
					this._date_created = value;
					this.SendPropertyChanged("date_created");
					this.Ondate_createdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_updated", DbType="DateTime")]
		public System.Nullable<System.DateTime> date_updated
		{
			get
			{
				return this._date_updated;
			}
			set
			{
				if ((this._date_updated != value))
				{
					this.Ondate_updatedChanging(value);
					this.SendPropertyChanging();
					this._date_updated = value;
					this.SendPropertyChanged("date_updated");
					this.Ondate_updatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="synonym_compounds_synonym", Storage="_compounds_synonyms", ThisKey="syn_id", OtherKey="syn_id")]
		public EntitySet<compounds_synonym> compounds_synonyms
		{
			get
			{
				return this._compounds_synonyms;
			}
			set
			{
				this._compounds_synonyms.Assign(value);
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
		
		private void attach_compounds_synonyms(compounds_synonym entity)
		{
			this.SendPropertyChanging();
			entity.synonym = this;
		}
		
		private void detach_compounds_synonyms(compounds_synonym entity)
		{
			this.SendPropertyChanging();
			entity.synonym = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.synonyms_synonyms_flags")]
	public partial class synonyms_synonyms_flag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _syn_id;
		
		private byte _flag_id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsyn_idChanging(int value);
    partial void Onsyn_idChanged();
    partial void Onflag_idChanging(byte value);
    partial void Onflag_idChanged();
    #endregion
		
		public synonyms_synonyms_flag()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_syn_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int syn_id
		{
			get
			{
				return this._syn_id;
			}
			set
			{
				if ((this._syn_id != value))
				{
					this.Onsyn_idChanging(value);
					this.SendPropertyChanging();
					this._syn_id = value;
					this.SendPropertyChanged("syn_id");
					this.Onsyn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_flag_id", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte flag_id
		{
			get
			{
				return this._flag_id;
			}
			set
			{
				if ((this._flag_id != value))
				{
					this.Onflag_idChanging(value);
					this.SendPropertyChanging();
					this._flag_id = value;
					this.SendPropertyChanged("flag_id");
					this.Onflag_idChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.synonyms_flags")]
	public partial class synonyms_flag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _flag_id;
		
		private string _name;
		
		private string _title;
		
		private string _descr;
		
		private string _url;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onflag_idChanging(byte value);
    partial void Onflag_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescrChanging(string value);
    partial void OndescrChanged();
    partial void OnurlChanging(string value);
    partial void OnurlChanged();
    #endregion
		
		public synonyms_flag()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_flag_id", AutoSync=AutoSync.OnInsert, DbType="TinyInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public byte flag_id
		{
			get
			{
				return this._flag_id;
			}
			set
			{
				if ((this._flag_id != value))
				{
					this.Onflag_idChanging(value);
					this.SendPropertyChanging();
					this._flag_id = value;
					this.SendPropertyChanged("flag_id");
					this.Onflag_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(100)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descr", DbType="NVarChar(200)")]
		public string descr
		{
			get
			{
				return this._descr;
			}
			set
			{
				if ((this._descr != value))
				{
					this.OndescrChanging(value);
					this.SendPropertyChanging();
					this._descr = value;
					this.SendPropertyChanged("descr");
					this.OndescrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url", DbType="VarChar(200)")]
		public string url
		{
			get
			{
				return this._url;
			}
			set
			{
				if ((this._url != value))
				{
					this.OnurlChanging(value);
					this.SendPropertyChanging();
					this._url = value;
					this.SendPropertyChanged("url");
					this.OnurlChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.synonyms_lookup")]
	public partial class synonyms_lookup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _synonym;
		
		private System.Nullable<short> _score;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsynonymChanging(string value);
    partial void OnsynonymChanged();
    partial void OnscoreChanging(System.Nullable<short> value);
    partial void OnscoreChanged();
    #endregion
		
		public synonyms_lookup()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_synonym", DbType="NVarChar(448) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string synonym
		{
			get
			{
				return this._synonym;
			}
			set
			{
				if ((this._synonym != value))
				{
					this.OnsynonymChanging(value);
					this.SendPropertyChanging();
					this._synonym = value;
					this.SendPropertyChanged("synonym");
					this.OnsynonymChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_score", DbType="SmallInt")]
		public System.Nullable<short> score
		{
			get
			{
				return this._score;
			}
			set
			{
				if ((this._score != value))
				{
					this.OnscoreChanging(value);
					this.SendPropertyChanging();
					this._score = value;
					this.SendPropertyChanged("score");
					this.OnscoreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.systematic_names")]
	public partial class systematic_name : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cmp_id;
		
		private string _oechem_name;
		
		private bool _oechem_blah_yn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncmp_idChanging(int value);
    partial void Oncmp_idChanged();
    partial void Onoechem_nameChanging(string value);
    partial void Onoechem_nameChanged();
    partial void Onoechem_blah_ynChanging(bool value);
    partial void Onoechem_blah_ynChanged();
    #endregion
		
		public systematic_name()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmp_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cmp_id
		{
			get
			{
				return this._cmp_id;
			}
			set
			{
				if ((this._cmp_id != value))
				{
					this.Oncmp_idChanging(value);
					this.SendPropertyChanging();
					this._cmp_id = value;
					this.SendPropertyChanged("cmp_id");
					this.Oncmp_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oechem_name", DbType="NVarChar(MAX)")]
		public string oechem_name
		{
			get
			{
				return this._oechem_name;
			}
			set
			{
				if ((this._oechem_name != value))
				{
					this.Onoechem_nameChanging(value);
					this.SendPropertyChanging();
					this._oechem_name = value;
					this.SendPropertyChanged("oechem_name");
					this.Onoechem_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oechem_blah_yn", DbType="Bit NOT NULL")]
		public bool oechem_blah_yn
		{
			get
			{
				return this._oechem_blah_yn;
			}
			set
			{
				if ((this._oechem_blah_yn != value))
				{
					this.Onoechem_blah_ynChanging(value);
					this.SendPropertyChanging();
					this._oechem_blah_yn = value;
					this.SendPropertyChanged("oechem_blah_yn");
					this.Onoechem_blah_ynChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.languages")]
	public partial class language : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _lang_id;
		
		private string _iso639_3;
		
		private string _iso639_2b;
		
		private string _iso639_2t;
		
		private string _name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onlang_idChanging(string value);
    partial void Onlang_idChanged();
    partial void Oniso639_3Changing(string value);
    partial void Oniso639_3Changed();
    partial void Oniso639_2bChanging(string value);
    partial void Oniso639_2bChanged();
    partial void Oniso639_2tChanging(string value);
    partial void Oniso639_2tChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public language()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lang_id", DbType="Char(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string lang_id
		{
			get
			{
				return this._lang_id;
			}
			set
			{
				if ((this._lang_id != value))
				{
					this.Onlang_idChanging(value);
					this.SendPropertyChanging();
					this._lang_id = value;
					this.SendPropertyChanged("lang_id");
					this.Onlang_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iso639_3", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string iso639_3
		{
			get
			{
				return this._iso639_3;
			}
			set
			{
				if ((this._iso639_3 != value))
				{
					this.Oniso639_3Changing(value);
					this.SendPropertyChanging();
					this._iso639_3 = value;
					this.SendPropertyChanged("iso639_3");
					this.Oniso639_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iso639_2b", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string iso639_2b
		{
			get
			{
				return this._iso639_2b;
			}
			set
			{
				if ((this._iso639_2b != value))
				{
					this.Oniso639_2bChanging(value);
					this.SendPropertyChanging();
					this._iso639_2b = value;
					this.SendPropertyChanged("iso639_2b");
					this.Oniso639_2bChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iso639_2t", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string iso639_2t
		{
			get
			{
				return this._iso639_2t;
			}
			set
			{
				if ((this._iso639_2t != value))
				{
					this.Oniso639_2tChanging(value);
					this.SendPropertyChanging();
					this._iso639_2t = value;
					this.SendPropertyChanged("iso639_2t");
					this.Oniso639_2tChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
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
