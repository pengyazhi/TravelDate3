﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace proj_Traveldate
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TraveldateEntities : DbContext
    {
        public TraveldateEntities()
            : base("name=TraveldateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CityList> CityLists { get; set; }
        public virtual DbSet<CommentList> CommentLists { get; set; }
        public virtual DbSet<Companion> Companions { get; set; }
        public virtual DbSet<CompanionList> CompanionLists { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CountryList> CountryLists { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponList> CouponLists { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<LevelList> LevelLists { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatusList> OrderStatusLists { get; set; }
        public virtual DbSet<PaymentList> PaymentLists { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<ProductPhotoList> ProductPhotoLists { get; set; }
        public virtual DbSet<ProductTagDetail> ProductTagDetails { get; set; }
        public virtual DbSet<ProductTagList> ProductTagLists { get; set; }
        public virtual DbSet<ProductTypeList> ProductTypeLists { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripDetail> TripDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
