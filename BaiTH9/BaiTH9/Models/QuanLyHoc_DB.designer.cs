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

namespace BaiTH9.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanlyhocDB")]
	public partial class QuanLyHoc_DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDangKyHoc(DangKyHoc instance);
    partial void UpdateDangKyHoc(DangKyHoc instance);
    partial void DeleteDangKyHoc(DangKyHoc instance);
    partial void InsertKhoaDaoTao(KhoaDaoTao instance);
    partial void UpdateKhoaDaoTao(KhoaDaoTao instance);
    partial void DeleteKhoaDaoTao(KhoaDaoTao instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public QuanLyHoc_DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanlyhocDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoc_DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoc_DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoc_DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoc_DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangKyHoc> DangKyHocs
		{
			get
			{
				return this.GetTable<DangKyHoc>();
			}
		}
		
		public System.Data.Linq.Table<KhoaDaoTao> KhoaDaoTaos
		{
			get
			{
				return this.GetTable<KhoaDaoTao>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangKyHoc")]
	public partial class DangKyHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDangKy;
		
		private string _MaSV;
		
		private string _MaMon;
		
		private string _NamHK;
		
		private string _GhiChu;
		
		private EntityRef<MonHoc> _MonHoc;
		
		private EntityRef<SinhVien> _SinhVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDangKyChanging(string value);
    partial void OnMaDangKyChanged();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnMaMonChanging(string value);
    partial void OnMaMonChanged();
    partial void OnNamHKChanging(string value);
    partial void OnNamHKChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public DangKyHoc()
		{
			this._MonHoc = default(EntityRef<MonHoc>);
			this._SinhVien = default(EntityRef<SinhVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDangKy", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDangKy
		{
			get
			{
				return this._MaDangKy;
			}
			set
			{
				if ((this._MaDangKy != value))
				{
					this.OnMaDangKyChanging(value);
					this.SendPropertyChanging();
					this._MaDangKy = value;
					this.SendPropertyChanged("MaDangKy");
					this.OnMaDangKyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					if (this._SinhVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NChar(3) NOT NULL", CanBeNull=false)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					if (this._MonHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMonChanging(value);
					this.SendPropertyChanging();
					this._MaMon = value;
					this.SendPropertyChanged("MaMon");
					this.OnMaMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamHK", DbType="NChar(10)")]
		public string NamHK
		{
			get
			{
				return this._NamHK;
			}
			set
			{
				if ((this._NamHK != value))
				{
					this.OnNamHKChanging(value);
					this.SendPropertyChanging();
					this._NamHK = value;
					this.SendPropertyChanged("NamHK");
					this.OnNamHKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_DangKyHoc", Storage="_MonHoc", ThisKey="MaMon", OtherKey="MaMon", IsForeignKey=true)]
		public MonHoc MonHoc
		{
			get
			{
				return this._MonHoc.Entity;
			}
			set
			{
				MonHoc previousValue = this._MonHoc.Entity;
				if (((previousValue != value) 
							|| (this._MonHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MonHoc.Entity = null;
						previousValue.DangKyHocs.Remove(this);
					}
					this._MonHoc.Entity = value;
					if ((value != null))
					{
						value.DangKyHocs.Add(this);
						this._MaMon = value.MaMon;
					}
					else
					{
						this._MaMon = default(string);
					}
					this.SendPropertyChanged("MonHoc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_DangKyHoc", Storage="_SinhVien", ThisKey="MaSV", OtherKey="MaSV", IsForeignKey=true)]
		public SinhVien SinhVien
		{
			get
			{
				return this._SinhVien.Entity;
			}
			set
			{
				SinhVien previousValue = this._SinhVien.Entity;
				if (((previousValue != value) 
							|| (this._SinhVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SinhVien.Entity = null;
						previousValue.DangKyHocs.Remove(this);
					}
					this._SinhVien.Entity = value;
					if ((value != null))
					{
						value.DangKyHocs.Add(this);
						this._MaSV = value.MaSV;
					}
					else
					{
						this._MaSV = default(string);
					}
					this.SendPropertyChanged("SinhVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhoaDaoTao")]
	public partial class KhoaDaoTao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _TenKhoa;
		
		private string _Phone;
		
		private EntitySet<MonHoc> _MonHocs;
		
		private EntitySet<SinhVien> _SinhViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnTenKhoaChanging(string value);
    partial void OnTenKhoaChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public KhoaDaoTao()
		{
			this._MonHocs = new EntitySet<MonHoc>(new Action<MonHoc>(this.attach_MonHocs), new Action<MonHoc>(this.detach_MonHocs));
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NChar(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoa", DbType="NChar(50)")]
		public string TenKhoa
		{
			get
			{
				return this._TenKhoa;
			}
			set
			{
				if ((this._TenKhoa != value))
				{
					this.OnTenKhoaChanging(value);
					this.SendPropertyChanging();
					this._TenKhoa = value;
					this.SendPropertyChanged("TenKhoa");
					this.OnTenKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaDaoTao_MonHoc", Storage="_MonHocs", ThisKey="MaKhoa", OtherKey="MaKhoa")]
		public EntitySet<MonHoc> MonHocs
		{
			get
			{
				return this._MonHocs;
			}
			set
			{
				this._MonHocs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaDaoTao_SinhVien", Storage="_SinhViens", ThisKey="MaKhoa", OtherKey="MaKhoa")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
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
		
		private void attach_MonHocs(MonHoc entity)
		{
			this.SendPropertyChanging();
			entity.KhoaDaoTao = this;
		}
		
		private void detach_MonHocs(MonHoc entity)
		{
			this.SendPropertyChanging();
			entity.KhoaDaoTao = null;
		}
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.KhoaDaoTao = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.KhoaDaoTao = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _MaMon;
		
		private string _TenMon;
		
		private System.Nullable<int> _SoTinChi;
		
		private string _GhiChu;
		
		private EntitySet<DangKyHoc> _DangKyHocs;
		
		private EntityRef<KhoaDaoTao> _KhoaDaoTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnMaMonChanging(string value);
    partial void OnMaMonChanged();
    partial void OnTenMonChanging(string value);
    partial void OnTenMonChanged();
    partial void OnSoTinChiChanging(System.Nullable<int> value);
    partial void OnSoTinChiChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public MonHoc()
		{
			this._DangKyHocs = new EntitySet<DangKyHoc>(new Action<DangKyHoc>(this.attach_DangKyHocs), new Action<DangKyHoc>(this.detach_DangKyHocs));
			this._KhoaDaoTao = default(EntityRef<KhoaDaoTao>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					if (this._KhoaDaoTao.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this.OnMaMonChanging(value);
					this.SendPropertyChanging();
					this._MaMon = value;
					this.SendPropertyChanged("MaMon");
					this.OnMaMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NChar(30)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this.OnTenMonChanging(value);
					this.SendPropertyChanging();
					this._TenMon = value;
					this.SendPropertyChanged("TenMon");
					this.OnTenMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTinChi", DbType="Int")]
		public System.Nullable<int> SoTinChi
		{
			get
			{
				return this._SoTinChi;
			}
			set
			{
				if ((this._SoTinChi != value))
				{
					this.OnSoTinChiChanging(value);
					this.SendPropertyChanging();
					this._SoTinChi = value;
					this.SendPropertyChanged("SoTinChi");
					this.OnSoTinChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_DangKyHoc", Storage="_DangKyHocs", ThisKey="MaMon", OtherKey="MaMon")]
		public EntitySet<DangKyHoc> DangKyHocs
		{
			get
			{
				return this._DangKyHocs;
			}
			set
			{
				this._DangKyHocs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaDaoTao_MonHoc", Storage="_KhoaDaoTao", ThisKey="MaKhoa", OtherKey="MaKhoa", IsForeignKey=true)]
		public KhoaDaoTao KhoaDaoTao
		{
			get
			{
				return this._KhoaDaoTao.Entity;
			}
			set
			{
				KhoaDaoTao previousValue = this._KhoaDaoTao.Entity;
				if (((previousValue != value) 
							|| (this._KhoaDaoTao.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhoaDaoTao.Entity = null;
						previousValue.MonHocs.Remove(this);
					}
					this._KhoaDaoTao.Entity = value;
					if ((value != null))
					{
						value.MonHocs.Add(this);
						this._MaKhoa = value.MaKhoa;
					}
					else
					{
						this._MaKhoa = default(string);
					}
					this.SendPropertyChanged("KhoaDaoTao");
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
		
		private void attach_DangKyHocs(DangKyHoc entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = this;
		}
		
		private void detach_DangKyHocs(DangKyHoc entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _LopBC;
		
		private string _MaSV;
		
		private string _HoTen;
		
		private string _NgaySinh;
		
		private string _DiaChi;
		
		private EntitySet<DangKyHoc> _DangKyHocs;
		
		private EntityRef<KhoaDaoTao> _KhoaDaoTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnLopBCChanging(string value);
    partial void OnLopBCChanged();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public SinhVien()
		{
			this._DangKyHocs = new EntitySet<DangKyHoc>(new Action<DangKyHoc>(this.attach_DangKyHocs), new Action<DangKyHoc>(this.detach_DangKyHocs));
			this._KhoaDaoTao = default(EntityRef<KhoaDaoTao>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					if (this._KhoaDaoTao.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LopBC", DbType="NChar(10)")]
		public string LopBC
		{
			get
			{
				return this._LopBC;
			}
			set
			{
				if ((this._LopBC != value))
				{
					this.OnLopBCChanging(value);
					this.SendPropertyChanging();
					this._LopBC = value;
					this.SendPropertyChanged("LopBC");
					this.OnLopBCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NChar(30)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NChar(10)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_DangKyHoc", Storage="_DangKyHocs", ThisKey="MaSV", OtherKey="MaSV")]
		public EntitySet<DangKyHoc> DangKyHocs
		{
			get
			{
				return this._DangKyHocs;
			}
			set
			{
				this._DangKyHocs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoaDaoTao_SinhVien", Storage="_KhoaDaoTao", ThisKey="MaKhoa", OtherKey="MaKhoa", IsForeignKey=true)]
		public KhoaDaoTao KhoaDaoTao
		{
			get
			{
				return this._KhoaDaoTao.Entity;
			}
			set
			{
				KhoaDaoTao previousValue = this._KhoaDaoTao.Entity;
				if (((previousValue != value) 
							|| (this._KhoaDaoTao.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhoaDaoTao.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._KhoaDaoTao.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._MaKhoa = value.MaKhoa;
					}
					else
					{
						this._MaKhoa = default(string);
					}
					this.SendPropertyChanged("KhoaDaoTao");
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
		
		private void attach_DangKyHocs(DangKyHoc entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = this;
		}
		
		private void detach_DangKyHocs(DangKyHoc entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = null;
		}
	}
}
#pragma warning restore 1591
