﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCompany1Table(Company1Table instance);
  partial void UpdateCompany1Table(Company1Table instance);
  partial void DeleteCompany1Table(Company1Table instance);
  partial void InsertAdminTable(AdminTable instance);
  partial void UpdateAdminTable(AdminTable instance);
  partial void DeleteAdminTable(AdminTable instance);
  partial void InsertContactTable(ContactTable instance);
  partial void UpdateContactTable(ContactTable instance);
  partial void DeleteContactTable(ContactTable instance);
  partial void InsertCVTable(CVTable instance);
  partial void UpdateCVTable(CVTable instance);
  partial void DeleteCVTable(CVTable instance);
  partial void InsertITjobPostTable(ITjobPostTable instance);
  partial void UpdateITjobPostTable(ITjobPostTable instance);
  partial void DeleteITjobPostTable(ITjobPostTable instance);
  partial void InsertJobPostTable(JobPostTable instance);
  partial void UpdateJobPostTable(JobPostTable instance);
  partial void DeleteJobPostTable(JobPostTable instance);
  partial void InsertEmployeeTable(EmployeeTable instance);
  partial void UpdateEmployeeTable(EmployeeTable instance);
  partial void DeleteEmployeeTable(EmployeeTable instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Company1Table> Company1Tables
	{
		get
		{
			return this.GetTable<Company1Table>();
		}
	}
	
	public System.Data.Linq.Table<AdminTable> AdminTables
	{
		get
		{
			return this.GetTable<AdminTable>();
		}
	}
	
	public System.Data.Linq.Table<ContactTable> ContactTables
	{
		get
		{
			return this.GetTable<ContactTable>();
		}
	}
	
	public System.Data.Linq.Table<CVTable> CVTables
	{
		get
		{
			return this.GetTable<CVTable>();
		}
	}
	
	public System.Data.Linq.Table<ITjobPostTable> ITjobPostTables
	{
		get
		{
			return this.GetTable<ITjobPostTable>();
		}
	}
	
	public System.Data.Linq.Table<JobPostTable> JobPostTables
	{
		get
		{
			return this.GetTable<JobPostTable>();
		}
	}
	
	public System.Data.Linq.Table<EmployeeTable> EmployeeTables
	{
		get
		{
			return this.GetTable<EmployeeTable>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Company1Table")]
public partial class Company1Table : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Location;
	
	private System.Nullable<int> _EmployeeNo;
	
	private string _Contact;
	
	private string _Email;
	
	private string _Website;
	
	private EntitySet<EmployeeTable> _EmployeeTables;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnEmployeeNoChanging(System.Nullable<int> value);
    partial void OnEmployeeNoChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnWebsiteChanging(string value);
    partial void OnWebsiteChanged();
    #endregion
	
	public Company1Table()
	{
		this._EmployeeTables = new EntitySet<EmployeeTable>(new Action<EmployeeTable>(this.attach_EmployeeTables), new Action<EmployeeTable>(this.detach_EmployeeTables));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(50)")]
	public string Location
	{
		get
		{
			return this._Location;
		}
		set
		{
			if ((this._Location != value))
			{
				this.OnLocationChanging(value);
				this.SendPropertyChanging();
				this._Location = value;
				this.SendPropertyChanged("Location");
				this.OnLocationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeNo", DbType="Int")]
	public System.Nullable<int> EmployeeNo
	{
		get
		{
			return this._EmployeeNo;
		}
		set
		{
			if ((this._EmployeeNo != value))
			{
				this.OnEmployeeNoChanging(value);
				this.SendPropertyChanging();
				this._EmployeeNo = value;
				this.SendPropertyChanged("EmployeeNo");
				this.OnEmployeeNoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="VarChar(50)")]
	public string Contact
	{
		get
		{
			return this._Contact;
		}
		set
		{
			if ((this._Contact != value))
			{
				this.OnContactChanging(value);
				this.SendPropertyChanging();
				this._Contact = value;
				this.SendPropertyChanged("Contact");
				this.OnContactChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Website", DbType="VarChar(50)")]
	public string Website
	{
		get
		{
			return this._Website;
		}
		set
		{
			if ((this._Website != value))
			{
				this.OnWebsiteChanging(value);
				this.SendPropertyChanging();
				this._Website = value;
				this.SendPropertyChanged("Website");
				this.OnWebsiteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company1Table_EmployeeTable", Storage="_EmployeeTables", ThisKey="Id", OtherKey="Cid")]
	public EntitySet<EmployeeTable> EmployeeTables
	{
		get
		{
			return this._EmployeeTables;
		}
		set
		{
			this._EmployeeTables.Assign(value);
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
	
	private void attach_EmployeeTables(EmployeeTable entity)
	{
		this.SendPropertyChanging();
		entity.Company1Table = this;
	}
	
	private void detach_EmployeeTables(EmployeeTable entity)
	{
		this.SendPropertyChanging();
		entity.Company1Table = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminTable")]
public partial class AdminTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _AdminEmail;
	
	private string _Password;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAdminEmailChanging(string value);
    partial void OnAdminEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
	
	public AdminTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminEmail", DbType="VarChar(50)")]
	public string AdminEmail
	{
		get
		{
			return this._AdminEmail;
		}
		set
		{
			if ((this._AdminEmail != value))
			{
				this.OnAdminEmailChanging(value);
				this.SendPropertyChanging();
				this._AdminEmail = value;
				this.SendPropertyChanged("AdminEmail");
				this.OnAdminEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ContactTable")]
public partial class ContactTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Email;
	
	private string _Telephone;
	
	private string _Name;
	
	private string _Subject;
	
	private string _Message;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    #endregion
	
	public ContactTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="VarChar(50)")]
	public string Telephone
	{
		get
		{
			return this._Telephone;
		}
		set
		{
			if ((this._Telephone != value))
			{
				this.OnTelephoneChanging(value);
				this.SendPropertyChanging();
				this._Telephone = value;
				this.SendPropertyChanged("Telephone");
				this.OnTelephoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="VarChar(50)")]
	public string Subject
	{
		get
		{
			return this._Subject;
		}
		set
		{
			if ((this._Subject != value))
			{
				this.OnSubjectChanging(value);
				this.SendPropertyChanging();
				this._Subject = value;
				this.SendPropertyChanged("Subject");
				this.OnSubjectChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(50)")]
	public string Message
	{
		get
		{
			return this._Message;
		}
		set
		{
			if ((this._Message != value))
			{
				this.OnMessageChanging(value);
				this.SendPropertyChanging();
				this._Message = value;
				this.SendPropertyChanged("Message");
				this.OnMessageChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CVTable")]
public partial class CVTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Full_Name;
	
	private string _Email;
	
	private string _Company;
	
	private string _Address;
	
	private string _Phone;
	
	private string _Apply_For;
	
	private string _Upload_your_Pic;
	
	private string _Upload_your_resume;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFull_NameChanging(string value);
    partial void OnFull_NameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnApply_ForChanging(string value);
    partial void OnApply_ForChanged();
    partial void OnUpload_your_PicChanging(string value);
    partial void OnUpload_your_PicChanged();
    partial void OnUpload_your_resumeChanging(string value);
    partial void OnUpload_your_resumeChanged();
    #endregion
	
	public CVTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Full Name]", Storage="_Full_Name", DbType="VarChar(50)")]
	public string Full_Name
	{
		get
		{
			return this._Full_Name;
		}
		set
		{
			if ((this._Full_Name != value))
			{
				this.OnFull_NameChanging(value);
				this.SendPropertyChanging();
				this._Full_Name = value;
				this.SendPropertyChanged("Full_Name");
				this.OnFull_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(50)")]
	public string Company
	{
		get
		{
			return this._Company;
		}
		set
		{
			if ((this._Company != value))
			{
				this.OnCompanyChanging(value);
				this.SendPropertyChanging();
				this._Company = value;
				this.SendPropertyChanged("Company");
				this.OnCompanyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Apply For]", Storage="_Apply_For", DbType="VarChar(50)")]
	public string Apply_For
	{
		get
		{
			return this._Apply_For;
		}
		set
		{
			if ((this._Apply_For != value))
			{
				this.OnApply_ForChanging(value);
				this.SendPropertyChanging();
				this._Apply_For = value;
				this.SendPropertyChanged("Apply_For");
				this.OnApply_ForChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Upload your Pic]", Storage="_Upload_your_Pic", DbType="VarChar(MAX)")]
	public string Upload_your_Pic
	{
		get
		{
			return this._Upload_your_Pic;
		}
		set
		{
			if ((this._Upload_your_Pic != value))
			{
				this.OnUpload_your_PicChanging(value);
				this.SendPropertyChanging();
				this._Upload_your_Pic = value;
				this.SendPropertyChanged("Upload_your_Pic");
				this.OnUpload_your_PicChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Upload your resume]", Storage="_Upload_your_resume", DbType="VarChar(MAX)")]
	public string Upload_your_resume
	{
		get
		{
			return this._Upload_your_resume;
		}
		set
		{
			if ((this._Upload_your_resume != value))
			{
				this.OnUpload_your_resumeChanging(value);
				this.SendPropertyChanging();
				this._Upload_your_resume = value;
				this.SendPropertyChanged("Upload_your_resume");
				this.OnUpload_your_resumeChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITjobPostTable")]
public partial class ITjobPostTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Post;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    #endregion
	
	public ITjobPostTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(50)")]
	public string Post
	{
		get
		{
			return this._Post;
		}
		set
		{
			if ((this._Post != value))
			{
				this.OnPostChanging(value);
				this.SendPropertyChanging();
				this._Post = value;
				this.SendPropertyChanged("Post");
				this.OnPostChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JobPostTable")]
public partial class JobPostTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.Nullable<int> _PostName;
	
	private System.Nullable<int> _CompanyName;
	
	private System.Nullable<System.DateTime> _PublishDate;
	
	private string _Duration;
	
	private string _Stipend;
	
	private System.Nullable<System.DateTime> _LastDate;
	
	private string _Description;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPostNameChanging(System.Nullable<int> value);
    partial void OnPostNameChanged();
    partial void OnCompanyNameChanging(System.Nullable<int> value);
    partial void OnCompanyNameChanged();
    partial void OnPublishDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPublishDateChanged();
    partial void OnDurationChanging(string value);
    partial void OnDurationChanged();
    partial void OnStipendChanging(string value);
    partial void OnStipendChanged();
    partial void OnLastDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastDateChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
	
	public JobPostTable()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostName", DbType="Int")]
	public System.Nullable<int> PostName
	{
		get
		{
			return this._PostName;
		}
		set
		{
			if ((this._PostName != value))
			{
				this.OnPostNameChanging(value);
				this.SendPropertyChanging();
				this._PostName = value;
				this.SendPropertyChanged("PostName");
				this.OnPostNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="Int")]
	public System.Nullable<int> CompanyName
	{
		get
		{
			return this._CompanyName;
		}
		set
		{
			if ((this._CompanyName != value))
			{
				this.OnCompanyNameChanging(value);
				this.SendPropertyChanging();
				this._CompanyName = value;
				this.SendPropertyChanged("CompanyName");
				this.OnCompanyNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PublishDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> PublishDate
	{
		get
		{
			return this._PublishDate;
		}
		set
		{
			if ((this._PublishDate != value))
			{
				this.OnPublishDateChanging(value);
				this.SendPropertyChanging();
				this._PublishDate = value;
				this.SendPropertyChanged("PublishDate");
				this.OnPublishDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="VarChar(50)")]
	public string Duration
	{
		get
		{
			return this._Duration;
		}
		set
		{
			if ((this._Duration != value))
			{
				this.OnDurationChanging(value);
				this.SendPropertyChanging();
				this._Duration = value;
				this.SendPropertyChanged("Duration");
				this.OnDurationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stipend", DbType="VarChar(50)")]
	public string Stipend
	{
		get
		{
			return this._Stipend;
		}
		set
		{
			if ((this._Stipend != value))
			{
				this.OnStipendChanging(value);
				this.SendPropertyChanging();
				this._Stipend = value;
				this.SendPropertyChanged("Stipend");
				this.OnStipendChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> LastDate
	{
		get
		{
			return this._LastDate;
		}
		set
		{
			if ((this._LastDate != value))
			{
				this.OnLastDateChanging(value);
				this.SendPropertyChanging();
				this._LastDate = value;
				this.SendPropertyChanged("LastDate");
				this.OnLastDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX)")]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeTable")]
public partial class EmployeeTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.Nullable<int> _Cid;
	
	private string _EmpployeeName;
	
	private string _JobProfile;
	
	private string _Review;
	
	private string _Linkedlink;
	
	private string _EmpPic;
	
	private EntityRef<Company1Table> _Company1Table;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCidChanging(System.Nullable<int> value);
    partial void OnCidChanged();
    partial void OnEmpployeeNameChanging(string value);
    partial void OnEmpployeeNameChanged();
    partial void OnJobProfileChanging(string value);
    partial void OnJobProfileChanged();
    partial void OnReviewChanging(string value);
    partial void OnReviewChanged();
    partial void OnLinkedlinkChanging(string value);
    partial void OnLinkedlinkChanged();
    partial void OnEmpPicChanging(string value);
    partial void OnEmpPicChanged();
    #endregion
	
	public EmployeeTable()
	{
		this._Company1Table = default(EntityRef<Company1Table>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cid", DbType="Int")]
	public System.Nullable<int> Cid
	{
		get
		{
			return this._Cid;
		}
		set
		{
			if ((this._Cid != value))
			{
				if (this._Company1Table.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCidChanging(value);
				this.SendPropertyChanging();
				this._Cid = value;
				this.SendPropertyChanged("Cid");
				this.OnCidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpployeeName", DbType="VarChar(50)")]
	public string EmpployeeName
	{
		get
		{
			return this._EmpployeeName;
		}
		set
		{
			if ((this._EmpployeeName != value))
			{
				this.OnEmpployeeNameChanging(value);
				this.SendPropertyChanging();
				this._EmpployeeName = value;
				this.SendPropertyChanged("EmpployeeName");
				this.OnEmpployeeNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobProfile", DbType="VarChar(MAX)")]
	public string JobProfile
	{
		get
		{
			return this._JobProfile;
		}
		set
		{
			if ((this._JobProfile != value))
			{
				this.OnJobProfileChanging(value);
				this.SendPropertyChanging();
				this._JobProfile = value;
				this.SendPropertyChanged("JobProfile");
				this.OnJobProfileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Review", DbType="VarChar(MAX)")]
	public string Review
	{
		get
		{
			return this._Review;
		}
		set
		{
			if ((this._Review != value))
			{
				this.OnReviewChanging(value);
				this.SendPropertyChanging();
				this._Review = value;
				this.SendPropertyChanged("Review");
				this.OnReviewChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Linkedlink", DbType="VarChar(MAX)")]
	public string Linkedlink
	{
		get
		{
			return this._Linkedlink;
		}
		set
		{
			if ((this._Linkedlink != value))
			{
				this.OnLinkedlinkChanging(value);
				this.SendPropertyChanging();
				this._Linkedlink = value;
				this.SendPropertyChanged("Linkedlink");
				this.OnLinkedlinkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpPic", DbType="VarChar(MAX)")]
	public string EmpPic
	{
		get
		{
			return this._EmpPic;
		}
		set
		{
			if ((this._EmpPic != value))
			{
				this.OnEmpPicChanging(value);
				this.SendPropertyChanging();
				this._EmpPic = value;
				this.SendPropertyChanged("EmpPic");
				this.OnEmpPicChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company1Table_EmployeeTable", Storage="_Company1Table", ThisKey="Cid", OtherKey="Id", IsForeignKey=true)]
	public Company1Table Company1Table
	{
		get
		{
			return this._Company1Table.Entity;
		}
		set
		{
			Company1Table previousValue = this._Company1Table.Entity;
			if (((previousValue != value) 
						|| (this._Company1Table.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Company1Table.Entity = null;
					previousValue.EmployeeTables.Remove(this);
				}
				this._Company1Table.Entity = value;
				if ((value != null))
				{
					value.EmployeeTables.Add(this);
					this._Cid = value.Id;
				}
				else
				{
					this._Cid = default(Nullable<int>);
				}
				this.SendPropertyChanged("Company1Table");
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
#pragma warning restore 1591
