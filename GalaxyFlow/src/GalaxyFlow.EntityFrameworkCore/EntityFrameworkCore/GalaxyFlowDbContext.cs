using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GalaxyFlow.Entities;

namespace GalaxyFlow.EntityFrameworkCore
{
    public class GalaxyFlowDbContext : AbpDbContext
    {
        #region DbSet

        //Add DbSet properties for your entities...
        public virtual DbSet<AppLibrary> AppLibrary { get; set; }

        public virtual DbSet<AppLibraryButtons> AppLibraryButtons { get; set; }

        public virtual DbSet<AppLibraryButtons1> AppLibraryButtons1 { get; set; }

        public virtual DbSet<AppLibrarySubPages> AppLibrarySubPages { get; set; }

        public virtual DbSet<DbConnection> DBConnection { get; set; }

        public virtual DbSet<Dictionary> Dictionary { get; set; }

        public virtual DbSet<DocumentDirectory> DocumentDirectory { get; set; }

        public virtual DbSet<Documents> Documents { get; set; }

        public virtual DbSet<DocumentsReadUsers> DocumentsReadUsers { get; set; }

        public virtual DbSet<HastenLog> HastenLog { get; set; }

        public virtual DbSet<HomeItems> HomeItems { get; set; }

        public virtual DbSet<Log> Log { get; set; }

        public virtual DbSet<Menu> Menu { get; set; }

        public virtual DbSet<MenuUser> MenuUser { get; set; }

        public virtual DbSet<Organize> Organize { get; set; }

        public virtual DbSet<ProgramBuilder> ProgramBuilder { get; set; }

        public virtual DbSet<ProgramBuilderButtons> ProgramBuilderButtons { get; set; }

        public virtual DbSet<ProgramBuilderExport> ProgramBuilderExport { get; set; }

        public virtual DbSet<ProgramBuilderFields> ProgramBuilderFields { get; set; }

        public virtual DbSet<ProgramBuilderQuerys> ProgramBuilderQuerys { get; set; }

        public virtual DbSet<ProgramBuilderValidates> ProgramBuilderValidates { get; set; }

        public virtual DbSet<ShortMessage> ShortMessage { get; set; }

        public virtual DbSet<ShortMessage1> ShortMessage1 { get; set; }

        public virtual DbSet<SMSLog> SMSLog { get; set; }

        public virtual DbSet<TempTest> TempTest { get; set; }

        public virtual DbSet<TempTest_CustomForm> TempTest_CustomForm { get; set; }

        public virtual DbSet<TempTest_News> TempTest_News { get; set; }

        public virtual DbSet<TempTest_Purchase> TempTest_Purchase { get; set; }

        public virtual DbSet<TempTest_PurchaseList> TempTest_PurchaseList { get; set; }

        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<UserShortcut> UserShortcut { get; set; }

        public virtual DbSet<UsersRelation> UsersRelation { get; set; }

        public virtual DbSet<WeiXinMessage> WeiXinMessage { get; set; }

        public virtual DbSet<WorkCalendar> WorkCalendar { get; set; }

        public virtual DbSet<WorkFlow> WorkFlow { get; set; }

        public virtual DbSet<WorkFlowArchives> WorkFlowArchives { get; set; }

        public virtual DbSet<WorkFlowButtons> WorkFlowButtons { get; set; }

        public virtual DbSet<WorkFlowComment> WorkFlowComment { get; set; }

        public virtual DbSet<WorkFlowDelegation> WorkFlowDelegation { get; set; }

        public virtual DbSet<WorkFlowForm> WorkFlowForm { get; set; }

        public virtual DbSet<WorkFlowTask> WorkFlowTask { get; set; }

        public virtual DbSet<WorkGroup> WorkGroup { get; set; }

        public virtual DbSet<WorkTime> WorkTime { get; set; }

        #endregion

        public GalaxyFlowDbContext(DbContextOptions<GalaxyFlowDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 4);
        }
    }
}
