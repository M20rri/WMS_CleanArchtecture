using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            ILoggerFactory loggerFactory
            ) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _loggerFactory = loggerFactory;
        }

        public virtual DbSet<ARC_MOVE_1_2019> ARC_MOVE_1_2019s { get; set; }

        public virtual DbSet<ARC_MOVE_2_2019> ARC_MOVE_2_2019s { get; set; }

        public virtual DbSet<ARC_MOVE_3_2019> ARC_MOVE_3_2019s { get; set; }

        public virtual DbSet<ARC_PICKING> ARC_PICKINGs { get; set; }

        public virtual DbSet<ARC_PICKING_APR20> ARC_PICKING_APR20s { get; set; }

        public virtual DbSet<ARC_PICKING_DEC19> ARC_PICKING_DEC19s { get; set; }

        public virtual DbSet<ARC_PICKING_FEB20> ARC_PICKING_FEB20s { get; set; }

        public virtual DbSet<ARC_PICKING_JAN20> ARC_PICKING_JAN20s { get; set; }

        public virtual DbSet<ARC_PICKING_MAR20> ARC_PICKING_MAR20s { get; set; }

        public virtual DbSet<ARC_PICKING_NOV19> ARC_PICKING_NOV19s { get; set; }

        public virtual DbSet<ARC_PICKING_RETURNCANCEL> ARC_PICKING_RETURNCANCELs { get; set; }

        public virtual DbSet<ARC_PNA_BIN> ARC_PNA_BINs { get; set; }

        public virtual DbSet<ARC_PUTAWAY> ARC_PUTAWAYs { get; set; }

        public virtual DbSet<ARC_PUTAWAY_RETURNCANCEL> ARC_PUTAWAY_RETURNCANCELs { get; set; }

        public virtual DbSet<ARC_PUTAWAY_SCAN> ARC_PUTAWAY_SCANs { get; set; }

        public virtual DbSet<ARC_SORTING_DETAIL> ARC_SORTING_DETAILs { get; set; }

        public virtual DbSet<ARC_SORTING_DETAIL2019> ARC_SORTING_DETAIL2019s { get; set; }

        public virtual DbSet<ARC_SORTING_DETAIL201901> ARC_SORTING_DETAIL201901s { get; set; }

        public virtual DbSet<ARC_STOCKCOUNT> ARC_STOCKCOUNTs { get; set; }

        public virtual DbSet<BILAL_LOCATION> BILAL_LOCATIONs { get; set; }

        public virtual DbSet<BKP_ARC_SORTING_DETAIL> BKP_ARC_SORTING_DETAILs { get; set; }

        public virtual DbSet<BKP_SORTING_DETAIL> BKP_SORTING_DETAILs { get; set; }

        public virtual DbSet<IMTYAZ_TEMP> IMTYAZ_TEMPs { get; set; }

        public virtual DbSet<TBLDEVICE> TBLDEVICEs { get; set; }

        public virtual DbSet<TBL_TEST_TEMP> TBL_TEST_TEMPs { get; set; }

        public virtual DbSet<TESTPICKING> TESTPICKINGs { get; set; }

        public virtual DbSet<WMS_APICONFIG> WMS_APICONFIGs { get; set; }

        public virtual DbSet<WMS_APILOG> WMS_APILOGs { get; set; }

        public virtual DbSet<WMS_BIN> WMS_BINs { get; set; }

        public virtual DbSet<WMS_BIN_ZONE_MAPPING> WMS_BIN_ZONE_MAPPINGs { get; set; }

        public virtual DbSet<WMS_CANCELLED_ITEM> WMS_CANCELLED_ITEMs { get; set; }

        public virtual DbSet<WMS_CC_REQUEST> WMS_CC_REQUESTs { get; set; }

        public virtual DbSet<WMS_CC_SCAN> WMS_CC_SCANs { get; set; }

        public virtual DbSet<WMS_CC_SCHEDULE> WMS_CC_SCHEDULEs { get; set; }

        public virtual DbSet<WMS_CLASS_EDITOR> WMS_CLASS_EDITORs { get; set; }

        public virtual DbSet<WMS_COMMON_DEVICELEDGER> WMS_COMMON_DEVICELEDGERs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT> WMS_CYCLECOUNTs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT_DISCREPANCY_REQUEST> WMS_CYCLECOUNT_DISCREPANCY_REQUESTs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT_ITEMAPPROVED> WMS_CYCLECOUNT_ITEMAPPROVEDs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT_PENDINGITEMAPPROVAL> WMS_CYCLECOUNT_PENDINGITEMAPPROVALs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT_SCHEDULE> WMS_CYCLECOUNT_SCHEDULEs { get; set; }

        public virtual DbSet<WMS_CYCLECOUNT_SETTING> WMS_CYCLECOUNT_SETTINGs { get; set; }

        public virtual DbSet<WMS_DEVICE_LEDGER> WMS_DEVICE_LEDGERs { get; set; }

        public virtual DbSet<WMS_DEVICE_ZONE_MAPPING> WMS_DEVICE_ZONE_MAPPINGs { get; set; }

        public virtual DbSet<WMS_DOC_REGISTER> WMS_DOC_REGISTERs { get; set; }

        public virtual DbSet<WMS_DOC_SERIES_BKP> WMS_DOC_SERIES_BKPs { get; set; }

        public virtual DbSet<WMS_DOC_Series> WMS_DOC_SERIEs { get; set; }

        public virtual DbSet<WMS_ERRORSUMMARY> WMS_ERRORSUMMARies { get; set; }

        public virtual DbSet<WMS_ITEM> WMS_ITEMs { get; set; }

        public virtual DbSet<WMS_ITEMEXPIRY_CAPTURE> WMS_ITEMEXPIRY_CAPTUREs { get; set; }

        public virtual DbSet<WMS_ITEMLOT> WMS_ITEMLOTs { get; set; }

        public virtual DbSet<WMS_ITEM_DIMENTION> WMS_ITEM_DIMENTIONs { get; set; }

        public virtual DbSet<WMS_ITEM_EXPIRY> WMS_ITEM_EXPIRies { get; set; }

        public virtual DbSet<WMS_ITEM_UID> WMS_ITEM_UIDs { get; set; }

        public virtual DbSet<WMS_LOCATION> WMS_LOCATIONs { get; set; }

        public virtual DbSet<WMS_LOCATIONTYPE> WMS_LOCATIONTYPEs { get; set; }

        public virtual DbSet<WMS_LOGDETAIL> WMS_LOGDETAILs { get; set; }

        public virtual DbSet<WMS_MOBILE_DEVICE> WMS_MOBILE_DEVICEs { get; set; }

        public virtual DbSet<WMS_MOVE_1> WMS_MOVE_1s { get; set; }

        public virtual DbSet<WMS_MOVE_2> WMS_MOVE_2s { get; set; }

        public virtual DbSet<WMS_MOVE_2_LOG> WMS_MOVE_2_LOGs { get; set; }

        public virtual DbSet<WMS_MOVE_3> WMS_MOVE_3s { get; set; }

        public virtual DbSet<WMS_MOVE_BINTOBIN> WMS_MOVE_BINTOBINs { get; set; }

        public virtual DbSet<WMS_MOVE_HEAD> WMS_MOVE_HEADs { get; set; }

        public virtual DbSet<WMS_MOVE_PICKPUT_LOG> WMS_MOVE_PICKPUT_LOGs { get; set; }

        public virtual DbSet<WMS_PAGEMASTER> WMS_PAGEMASTERs { get; set; }

        public virtual DbSet<WMS_PICKED_BATCH> WMS_PICKED_BATCHEs { get; set; }

        public virtual DbSet<WMS_PICKING> WMS_PICKINGs { get; set; }

        public virtual DbSet<WMS_PICKING_HEAD> WMS_PICKING_HEADs { get; set; }

        public virtual DbSet<WMS_PICKING_RETURNCANCEL> WMS_PICKING_RETURNCANCELs { get; set; }

        public virtual DbSet<WMS_PICKING_TRANSACTIONLOG> WMS_PICKING_TRANSACTIONLOGs { get; set; }

        public virtual DbSet<WMS_PICKSTART> WMS_PICKSTARTs { get; set; }

        public virtual DbSet<WMS_PNA_BIN> WMS_PNA_BINs { get; set; }

        public virtual DbSet<WMS_PNA_ITEM> WMS_PNA_ITEMs { get; set; }

        public virtual DbSet<WMS_PNA_PICKING> WMS_PNA_PICKINGs { get; set; }

        public virtual DbSet<WMS_PUTAWAY> WMS_PUTAWAYs { get; set; }

        public virtual DbSet<WMS_PUTAWAY_HEAD> WMS_PUTAWAY_HEADs { get; set; }

        public virtual DbSet<WMS_PUTAWAY_RETURNCANCEL> WMS_PUTAWAY_RETURNCANCELs { get; set; }

        public virtual DbSet<WMS_PUTAWAY_SCAN> WMS_PUTAWAY_SCANs { get; set; }

        public virtual DbSet<WMS_REPLENISHMENT_HEAD> WMS_REPLENISHMENT_HEADs { get; set; }

        public virtual DbSet<WMS_RESYNC_PICKING> WMS_RESYNC_PICKINGs { get; set; }

        public virtual DbSet<WMS_RETURNCANCEL> WMS_RETURNCANCELs { get; set; }

        public virtual DbSet<WMS_ROLE_PAGEMAPPING> WMS_ROLE_PAGEMAPPINGs { get; set; }

        public virtual DbSet<WMS_ROLL_EDITOR> WMS_ROLL_EDITORs { get; set; }

        public virtual DbSet<WMS_SETUP> WMS_SETUPs { get; set; }

        public virtual DbSet<WMS_SORTING_DETAIL> WMS_SORTING_DETAILs { get; set; }

        public virtual DbSet<WMS_STATUSMASTER> WMS_STATUSMASTERs { get; set; }

        public virtual DbSet<WMS_STOCKCOUNT> WMS_STOCKCOUNTs { get; set; }

        public virtual DbSet<WMS_STOCKCOUNT_UID> WMS_STOCKCOUNT_UIDs { get; set; }

        public virtual DbSet<WMS_STORE_EDITOR> WMS_STORE_EDITORs { get; set; }

        public virtual DbSet<WMS_SUBCLASS_EDITOR> WMS_SUBCLASS_EDITORs { get; set; }

        public virtual DbSet<WMS_SUBROLL_EDITOR> WMS_SUBROLL_EDITORs { get; set; }

        public virtual DbSet<WMS_TOTEHEAD> WMS_TOTEHEADs { get; set; }

        public virtual DbSet<WMS_TOTEHISTORY> WMS_TOTEHISTORies { get; set; }

        public virtual DbSet<WMS_TOTEITEM> WMS_TOTEITEMs { get; set; }

        public virtual DbSet<WMS_USER_EDITOR> WMS_USER_EDITORs { get; set; }

        public virtual DbSet<WMS_USER_TASK> WMS_USER_TASKs { get; set; }

        public virtual DbSet<WMS_USER_TOKEN> WMS_USER_TOKENs { get; set; }

        public virtual DbSet<WMS_ZONE_EDITOR> WMS_ZONE_EDITORs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=192.168.37.145;Initial Catalog=NAVWMS;Persist Security Info=True;User ID=wms;Password=wms@123;Encrypt=False;Trust Server Certificate=True;Command Timeout=300");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AS");

            modelBuilder.Entity<ARC_MOVE_1_2019>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_MOVE_2_2019>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_MOVE_3_2019>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING>(entity =>
            {
                entity.HasKey(e => e.SYNCID).HasName("PK_ARC_PICKING_2");

                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING_APR20>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING_DEC19>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.FORCECLOSE).HasDefaultValueSql("((0))");
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PNA).HasDefaultValueSql("((2))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ARC_PICKING_FEB20>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING_JAN20>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING_MAR20>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_PICKING_NOV19>(entity =>
            {
                entity.HasKey(e => e.ARCID).HasName("PK_ARC_PICKING_1");

                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PNA).HasDefaultValueSql("((2))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ARC_PICKING_RETURNCANCEL>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_WMS_PICKING_RETURNCANCEL_ID");
            });

            modelBuilder.Entity<ARC_PNA_BIN>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ARC_PUTAWAY>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ARC_PUTAWAY_RETURNCANCEL>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_WMS_PUTAWAY_RETURNCANCEL_ID");
            });

            modelBuilder.Entity<ARC_PUTAWAY_SCAN>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ARC_SORTING_DETAIL>(entity =>
            {
                entity.HasKey(e => e.ARCID).HasName("PK_ARC_SORTING_DETAIL_1");

                entity.HasIndex(e => e.BATCHID, "IDX_ARC_SORTINGDETAIL_BATCHID").HasFillFactor(85);

                entity.HasIndex(e => e.ITEMID, "IDX_ARC_SORTINGDETAIL_ITEMID").HasFillFactor(85);

                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_SORTING_DETAIL2019>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_SORTING_DETAIL201901>(entity =>
            {
                entity.HasKey(e => e.ARCID).HasName("PK_ARC_SORTING_DETAIL_201901");

                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ARC_STOCKCOUNT>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.SCANQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.SYSQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.TRNQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BILAL_LOCATION>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__BILAL_LO__3214EC277EBB41F9");
            });

            modelBuilder.Entity<BKP_ARC_SORTING_DETAIL>(entity =>
            {
                entity.Property(e => e.ARCID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BKP_SORTING_DETAIL>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TBL_TEST_TEMP>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TESTPICKING>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_BIN>(entity =>
            {
                entity.HasIndex(e => e.BINNO, "IX_WMS_BIN")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.FLAG).HasDefaultValueSql("((0))");
                entity.Property(e => e.ISTOOFFLINE).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_BIN_ZONE_MAPPING>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__WMS_BIN___3214EC27B28E5584");
            });

            modelBuilder.Entity<WMS_CANCELLED_ITEM>(entity =>
            {
                entity.HasIndex(e => e.REFORDERNO, "IDX_WMS_CANCELITEMS_ORDERNO").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_CC_REQUEST>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_CC_SCAN>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_CC_SCAN");

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.PNA).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_COMMON_DEVICELEDGER>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_CYCLECOUNT>(entity =>
            {
                entity.Property(e => e.ARCHIVE).HasDefaultValueSql("((1))");
                entity.Property(e => e.CCSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.SEDSTATUS).HasDefaultValueSql("((1))");
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_CYCLECOUNT_DISCREPANCY_REQUEST>(entity =>
            {
                entity.HasIndex(e => e.BINNO, "IDX_WMS_CYCLECOUNT_DISCREPANCY_BINNO").HasFillFactor(85);

                entity.HasIndex(e => new { e.DOCUMENTNO, e.BINNO, e.ITEMNO, e.LOTNO }, "IX_WMS_CYCLECOUNT_DISCREPANCY_REQUEST")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_CYCLECOUNT_ITEMAPPROVED>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_ITEMAPPROVED_SRNO");

                entity.HasIndex(e => new { e.DOCNO, e.SUBDOCNO, e.BINNO, e.ITEMNO }, "IX_CYCLECOUNT_ITEMAPPROVAL")
                    .IsUnique()
                    .HasFillFactor(85);
            });

            modelBuilder.Entity<WMS_CYCLECOUNT_PENDINGITEMAPPROVAL>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_CCPENDINGITEMAPPROVAL_SRNO");

                entity.HasIndex(e => new { e.DOCNO, e.SUBDOCNO, e.BINNO, e.ITEMNO }, "IX_CCPENDINGITEMAPPROVAL")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.HasIndex(e => e.ITEMNO, "IX_WMS_CYCLECOUNT_PENDINGITEMAPPROVAL").HasFillFactor(85);
            });

            modelBuilder.Entity<WMS_CYCLECOUNT_SCHEDULE>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_SRNO");

                entity.HasIndex(e => new { e.DOCNO, e.SUBDOCNO }, "IDX_WMS_CYCLECOUNT_SCHEDULE_DOCSUBNO")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.HasIndex(e => new { e.STATUS, e.STATUSID }, "IX_CC_SCHEDULE_STATUS").HasFillFactor(85);
            });

            modelBuilder.Entity<WMS_CYCLECOUNT_SETTING>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.RECINSERTED).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WMS_DEVICE_LEDGER>(entity =>
            {
                entity.HasIndex(e => new { e.ZONEID, e.ITEMNO }, "<Name of Missing Index, sysname,>").HasFillFactor(85);

                entity.HasIndex(e => e.ITEMID, "ClusteredIndex-20200703-035821")
                    .IsClustered()
                    .HasFillFactor(85);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_DEVICE_ZONE_MAPPING>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_DOC_REGISTER>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_DOC_SERIES_BKP>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_DOC_Series>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_ERRORSUMMARY>(entity =>
            {
                entity.Property(e => e.MODCODE).ValueGeneratedNever();
            });

            modelBuilder.Entity<WMS_ITEM>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_ITEMEXPIRY_CAPTURE>(entity =>
            {
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_ITEMLOT>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_ITEM_DIMENTION>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_ITEM_UID>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_WMS_ITEM_SRNO");
            });

            modelBuilder.Entity<WMS_LOCATION>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.Property(e => e.INSERTEDON).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WMS_LOCATIONTYPE>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_LOGDETAIL>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__WMS_LOGD__3214EC271D9C526A");
            });

            modelBuilder.Entity<WMS_MOBILE_DEVICE>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_WMS_DEVICES");

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.STATUS).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_1>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.ARCHIVE).HasDefaultValueSql("((0))");
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_2>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.ISTOOFFLINE).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_2_LOG>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_MOVE_3>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.ISTOOFFLINE).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_BINTOBIN>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_HEAD>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.PICKUSERID).HasDefaultValueSql("((0))");
                entity.Property(e => e.PUTUSERID).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_MOVE_PICKPUT_LOG>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__WMS_MOVE__3214EC275446BA69");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_PICKED_BATCH>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_PICKING>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_WMS_PICKING_1");

                entity.HasIndex(e => new { e.PICKNO, e.WAREHOUSENO, e.PICKSTATUS, e.MYDEVICEID, e.BARCODE, e.SRNO }, "IDX_PICKING_1").HasFillFactor(85);

                entity.HasIndex(e => new { e.SYNCID, e.SRNO }, "IDX_PICKING_4").HasFillFactor(85);

                entity.HasIndex(e => new { e.PICKNO, e.WAREHOUSENO, e.MYDEVICEID }, "IDX_PICKING_5").HasFillFactor(85);

                entity.HasIndex(e => new { e.PICKNO, e.WAREHOUSENO, e.TRANSDATE, e.MYDEVICEID, e.SRNO, e.PICKSTATUS }, "IDX_PICKING_6").HasFillFactor(85);

                entity.HasIndex(e => new { e.SYNCID, e.WAREHOUSENO }, "IX_WMS_PICKING")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.HasIndex(e => e.ITEMNO, "IX_WMS_PICKING_1").HasFillFactor(85);

                entity.HasIndex(e => e.ITEMNO, "ix_miss").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.FORCECLOSE).HasDefaultValueSql("((0))");
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.ITEMCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PNA).HasDefaultValueSql("((2))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PICKING_HEAD>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.PNA).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PICKING_RETURNCANCEL>(entity =>
            {
                entity.Property(e => e.DOCSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.ITEMSRNO).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.PNA).HasDefaultValueSql("((2))");
                entity.Property(e => e.QTY1).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PICKING_TRANSACTIONLOG>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_PICKSTART>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_PNA_BIN>(entity =>
            {
                entity.HasIndex(e => e.STATUS, "<Name of Missing Index, sysname,>").HasFillFactor(85);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PNA_ITEM>(entity =>
            {
                entity.HasIndex(e => e.REFORDERNO, "IDX_WMS_PNAITEMS_ORDERNO").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_PNA_PICKING>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_WMS_PNAPICK");

                entity.HasIndex(e => new { e.INTSTATUS, e.PICKSTATUS }, "<Name of Missing Index, sysname,>").HasFillFactor(85);

                entity.HasIndex(e => new { e.SYNCID, e.PNA, e.PICKSTATUS, e.PNACNT }, "ixc").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.PICKCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.PNA).HasDefaultValueSql("((2))");
                entity.Property(e => e.PNACNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.STAGE).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PUTAWAY>(entity =>
            {
                entity.HasKey(e => e.SRNO).HasName("PK_PUTAWAY");

                entity.HasIndex(e => new { e.PUTNO, e.USERID, e.SRNO }, "IDX_PUTAWAY_1").HasFillFactor(85);

                entity.HasIndex(e => new { e.SYNCID, e.USERID, e.SRNO }, "IDX_PUTAWAY_2").HasFillFactor(85);

                entity.HasIndex(e => new { e.PUTNO, e.USERID, e.BARCODE, e.SRNO, e.DOCNO }, "IDX_PUTAWAY_3").HasFillFactor(85);

                entity.HasIndex(e => new { e.USERID, e.BARCODE, e.PUTNO }, "IDX_PUTAWAY_4").HasFillFactor(85);

                entity.HasIndex(e => new { e.SYNCID, e.WAREHOUSENO }, "IX_WMS_PUTAWAY")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.SETTLEDQTY).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PUTAWAY_HEAD>(entity =>
            {
                entity.HasIndex(e => new { e.DOCNO, e.SUBDOCNO, e.SRNO }, "IDX_PUTAWAYHEAD_2").HasFillFactor(85);

                entity.HasIndex(e => e.SUBDOCNO, "IDX_PUTAWAYHEAD_3").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.SETTLEDQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PUTAWAY_RETURNCANCEL>(entity =>
            {
                entity.HasIndex(e => e.ITEMID, "IX_WMS_PUTAWAY_RETURNCANCEL")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.Property(e => e.DOCSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY1).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY2).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_PUTAWAY_SCAN>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_REPLENISHMENT_HEAD>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_RESYNC_PICKING>(entity =>
            {
                entity.HasIndex(e => e.SRNO, "IX_WMS_RESYNC_PICKING").HasFillFactor(85);

                entity.HasIndex(e => e.SYNCID, "IX_WMS_RESYNC_PICKING_1")
                    .IsUnique()
                    .HasFillFactor(85);

                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.RETRYCOUNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_RETURNCANCEL>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.ITEMCNT).HasDefaultValueSql("((0))");
                entity.Property(e => e.ITEMSRNO).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<WMS_SETUP>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_STOCKCOUNT>(entity =>
            {
                entity.HasIndex(e => e.MINDATE, "IX_WMS_STOCKCOUNT_1").HasFillFactor(85);

                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.INTSTATUS).HasDefaultValueSql("((0))");
                entity.Property(e => e.QTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.SCANQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.SYSQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.TRNQTY).HasDefaultValueSql("((0))");
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_STOCKCOUNT_UID>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_STORE_EDITOR>(entity =>
            {
                entity.Property(e => e.APPSCANLIMIT).HasDefaultValueSql("((0))");
                entity.Property(e => e.APPSERVICEINTERVAL).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_TOTEHEAD>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.Property(e => e.INSERTEDON).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WMS_USER_TASK>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WMS_USER_TOKEN>(entity =>
            {
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.USERPLATFORM).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WMS_ZONE_EDITOR>(entity =>
            {
                entity.Property(e => e.RECINSERTED).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.SRNO).ValueGeneratedOnAdd();
                entity.Property(e => e.ZONESTATUS).HasDefaultValueSql("((1))");
            });

        }

    }
}