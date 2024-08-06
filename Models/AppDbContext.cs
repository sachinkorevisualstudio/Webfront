using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Webfront.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BillNgstMonth> BillNgstMonths { get; set; }

    public virtual DbSet<Chalannoserial> Chalannoserials { get; set; }

    public virtual DbSet<Cheque> Cheques { get; set; }

    public virtual DbSet<Codetabledispatch> Codetabledispatches { get; set; }

    public virtual DbSet<DcJune> DcJunes { get; set; }

    public virtual DbSet<Gsb> Gsbs { get; set; }

    public virtual DbSet<GstDatum> GstData { get; set; }

    public virtual DbSet<Nanaavtade> Nanaavtades { get; set; }

    public virtual DbSet<NonGstPrtywiseYenebaki> NonGstPrtywiseYenebakis { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NotesQ> NotesQs { get; set; }

    public virtual DbSet<Paidamount> Paidamounts { get; set; }

    public virtual DbSet<PartynameJamaNave> PartynameJamaNaves { get; set; }

    public virtual DbSet<Partysummry> Partysummries { get; set; }

    public virtual DbSet<PartywiseGroupingMaterial> PartywiseGroupingMaterials { get; set; }

    public virtual DbSet<QComboPartynameJamaNave> QComboPartynameJamaNaves { get; set; }

    public virtual DbSet<QCreditPartylistNongst> QCreditPartylistNongsts { get; set; }

    public virtual DbSet<QMaterialSahyadriFind> QMaterialSahyadriFinds { get; set; }

    public virtual DbSet<QSiteCombo> QSiteCombos { get; set; }

    public virtual DbSet<QSumtotalJamanaveTextbox> QSumtotalJamanaveTextboxes { get; set; }

    public virtual DbSet<QVehicalCombo> QVehicalCombos { get; set; }

    public virtual DbSet<Qjama> Qjamas { get; set; }

    public virtual DbSet<Query2> Query2s { get; set; }

    public virtual DbSet<Qusername> Qusernames { get; set; }

    public virtual DbSet<Select> Selects { get; set; }

    public virtual DbSet<SelectMaterialPartyAndDateRange> SelectMaterialPartyAndDateRanges { get; set; }

    public virtual DbSet<SiteMirajRailwayDatemmdd> SiteMirajRailwayDatemmdds { get; set; }

    public virtual DbSet<TblDispatch> TblDispatches { get; set; }

    public virtual DbSet<TblPartyYeneBaki> TblPartyYeneBakis { get; set; }

    public virtual DbSet<TblRateChartPartywise> TblRateChartPartywises { get; set; }

    public virtual DbSet<Tblpartynamelist> Tblpartynamelists { get; set; }

    public virtual DbSet<TblpartynamelistQuery> TblpartynamelistQueries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<WhHorizontal> WhHorizontals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|disc-24-25.accdb;Jet OLEDB:Database Password=OFFICE;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BillNgstMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BILL_NGST_month");

            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.SumBill)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("sum_bill");
        });

        modelBuilder.Entity<Chalannoserial>(entity =>
        {
            entity.HasKey(e => e.Gstchalanno).HasName("PrimaryKey");

            entity.ToTable("chalannoserial");

            entity.Property(e => e.Gstchalanno)
                .ValueGeneratedNever()
                .HasColumnName("gstchalanno");
            entity.Property(e => e.Nongstchalanno)
                .HasDefaultValueSql("0")
                .HasColumnName("nongstchalanno");
        });

        modelBuilder.Entity<Cheque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("cheques");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Chequeno)
                .HasMaxLength(255)
                .HasColumnName("chequeno");
            entity.Property(e => e.Datex)
                .HasDefaultValueSql("=Date()")
                .HasColumnName("datex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
        });

        modelBuilder.Entity<Codetabledispatch>(entity =>
        {
            entity.HasKey(e => e.Chalanno).HasName("PrimaryKey");

            entity.ToTable("codetabledispatch");

            entity.HasIndex(e => e.AmountReceived, "amount_paid");

            entity.Property(e => e.Chalanno)
                .ValueGeneratedNever()
                .HasColumnName("chalanno");
            entity.Property(e => e.Amount1)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount1");
            entity.Property(e => e.AmountReceived)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("amount_Received");
            entity.Property(e => e.Amountwith5Gst)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("amountwith5GST");
            entity.Property(e => e.Amt10mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_10MM");
            entity.Property(e => e.Amt20mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_20MM");
            entity.Property(e => e.Amt26mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_26MM");
            entity.Property(e => e.Amt40mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_40MM");
            entity.Property(e => e.Amt60mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_60MM");
            entity.Property(e => e.Amt8b6)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_8b6");
            entity.Property(e => e.AmtDust)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_DUST");
            entity.Property(e => e.AmtGsb)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_GSB");
            entity.Property(e => e.AmtMsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_MSAND");
            entity.Property(e => e.AmtWashPlSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_WASH_PL_SAND");
            entity.Property(e => e.AmtWashSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amt_WASH_SAND");
            entity.Property(e => e.AmtWmm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amt_WMM");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Gstcustomer)
                .HasMaxLength(255)
                .HasColumnName("gstcustomer");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(255)
                .HasColumnName("payment_mode");
            entity.Property(e => e.PaymentPartyType)
                .HasMaxLength(255)
                .HasColumnName("payment_party_type");
            entity.Property(e => e.Rate10Mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate10MM");
            entity.Property(e => e.Rate20Mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate20MM");
            entity.Property(e => e.Rate26Mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate26MM");
            entity.Property(e => e.Rate40Mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate40MM");
            entity.Property(e => e.Rate60Mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate60MM");
            entity.Property(e => e.Rate8b6)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate8b6");
            entity.Property(e => e.RateDust)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateDUST");
            entity.Property(e => e.RateGsb)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateGSB");
            entity.Property(e => e.RateMsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateMSAND");
            entity.Property(e => e.RateWashPlSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateWASH_PL_SAND");
            entity.Property(e => e.RateWashSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateWASH_SAND");
            entity.Property(e => e.RateWmm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rateWMM");
            entity.Property(e => e.RegOrStock)
                .HasMaxLength(255)
                .HasDefaultValueSql("\"Regular\"")
                .HasColumnName("reg_or_stock");
            entity.Property(e => e.RemainingAsDiscountRs)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("remaining_as_discountRs");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
            entity.Property(e => e.T10mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_10MM");
            entity.Property(e => e.T20mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_20MM");
            entity.Property(e => e.T26mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_26MM");
            entity.Property(e => e.T40mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_40MM");
            entity.Property(e => e.T60mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_60MM");
            entity.Property(e => e.T8b6)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_8b6");
            entity.Property(e => e.TDust)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_DUST");
            entity.Property(e => e.TGsb)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_GSB");
            entity.Property(e => e.TMsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_MSAND");
            entity.Property(e => e.TWashPlSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_WASH_PL_SAND");
            entity.Property(e => e.TWashSand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_WASH_SAND");
            entity.Property(e => e.TWmm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("t_WMM");
            entity.Property(e => e.TransportCharge)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("transport_charge");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
        });

        modelBuilder.Entity<DcJune>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("dc-june");

            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
        });

        modelBuilder.Entity<Gsb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("gsb");

            entity.Property(e => e.Amt).HasColumnName("amt");
            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Qtynew).HasColumnName("qtynew");
            entity.Property(e => e.Ton)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("ton");
        });

        modelBuilder.Entity<GstDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("gst data");

            entity.Property(e => e.Amount1)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount1");
            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Drivername)
                .HasMaxLength(255)
                .HasColumnName("drivername");
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("GST_amount");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Payablebillwithdiscount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("payablebillwithdiscount");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RateApplied)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_applied");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
            entity.Property(e => e.Yearnamex)
                .HasMaxLength(255)
                .HasColumnName("yearnamex");
        });

        modelBuilder.Entity<Nanaavtade>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("nanaavtade");

            entity.Property(e => e.Amount1)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount1");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
        });

        modelBuilder.Entity<NonGstPrtywiseYenebaki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NON_GST_prtywise_yenebaki");

            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.SumBill)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("sum_bill");
            entity.Property(e => e.TotalJama)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("total_jama");
            entity.Property(e => e.Yenebaki)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("yenebaki");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("NOTES");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Datex).HasColumnName("DATEX");
            entity.Property(e => e.Note1)
                .HasMaxLength(255)
                .HasColumnName("NOTE");
        });

        modelBuilder.Entity<NotesQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NOTES_Q");

            entity.Property(e => e.Datex).HasColumnName("DATEX");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("NOTE");
        });

        modelBuilder.Entity<Paidamount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("PAIDAMOUNT");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Paid, "PAID");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Datex).HasColumnName("DATEX");
            entity.Property(e => e.Otherdetail)
                .HasMaxLength(255)
                .HasColumnName("OTHERDETAIL");
            entity.Property(e => e.Paid)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("PAID");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("PARTYNAME");
        });

        modelBuilder.Entity<PartynameJamaNave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partyname_jama_nave");

            entity.HasIndex(e => e.Partyname, "partyname_creditpartyname");

            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.JamaCash)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("jama_cash");
            entity.Property(e => e.JamaOnline)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("jama_online");
            entity.Property(e => e.Nave)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("nave");
            entity.Property(e => e.Partyname).HasColumnName("partyname");
            entity.Property(e => e.Totalyene)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalyene");
        });

        modelBuilder.Entity<Partysummry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("partysummry");

            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Payablebillwithdiscount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("payablebillwithdiscount");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RateApplied)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_applied");
            entity.Property(e => e.RateFromchart)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_fromchart");
            entity.Property(e => e.TransportCharge)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("transport_charge");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
        });

        modelBuilder.Entity<PartywiseGroupingMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("partywise grouping_material");

            entity.Property(e => e.Expr1004).HasColumnType("decimal(28, 3)");
            entity.Property(e => e.Expr1005).HasColumnType("decimal(28, 3)");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
        });

        modelBuilder.Entity<QComboPartynameJamaNave>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Q_combo_partyname_jama_nave");

            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
        });

        modelBuilder.Entity<QCreditPartylistNongst>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Q_credit_partylist_nongst");

            entity.Property(e => e.GstCustomer)
                .HasMaxLength(255)
                .HasColumnName("gst_customer");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
        });

        modelBuilder.Entity<QMaterialSahyadriFind>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("q_material_sahyadri_find");

            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Expr1005).HasColumnType("decimal(28, 3)");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.RateFromchart)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_fromchart");
            entity.Property(e => e.Yearnamex)
                .HasMaxLength(255)
                .HasColumnName("yearnamex");
        });

        modelBuilder.Entity<QSiteCombo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Q_site_combo");

            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
        });

        modelBuilder.Entity<QSumtotalJamanaveTextbox>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Q_sumtotal_jamanave_textboxes");

            entity.Property(e => e.Paidunpaid).HasColumnName("paidunpaid");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Yenebaki)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("yenebaki");
        });

        modelBuilder.Entity<QVehicalCombo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Q_vehical_combo");

            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
        });

        modelBuilder.Entity<Qjama>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Qjama");

            entity.Property(e => e.Datex).HasColumnName("DATEX");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("id");
            entity.Property(e => e.Monthname).HasColumnName("MONTHNAME");
            entity.Property(e => e.Otherdetail)
                .HasMaxLength(255)
                .HasColumnName("OTHERDETAIL");
            entity.Property(e => e.Paid)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("PAID");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("PARTYNAME");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Query2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Query2");

            entity.Property(e => e.TotalJama)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("total_jama");
            entity.Property(e => e.Totalbill)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("totalbill");
            entity.Property(e => e.Yenebaki)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("yenebaki");
        });

        modelBuilder.Entity<Qusername>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Qusername");

            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Select>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("select");

            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Discountpercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("discountpercent");
            entity.Property(e => e.Payablebillwithdiscount)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("payablebillwithdiscount");
        });

        modelBuilder.Entity<SelectMaterialPartyAndDateRange>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("select material party and date range");

            entity.Property(e => e.Bill)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("bill");
            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RateApplied)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_applied");
        });

        modelBuilder.Entity<SiteMirajRailwayDatemmdd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SITE MIRAJ RAILWAY DATEMMDD");

            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("DATEX");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
        });

        modelBuilder.Entity<TblDispatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("tblDispatch");

            entity.HasIndex(e => e.Partyname, "Dispatchentrypartyname");

            entity.HasIndex(e => e.TotalAmountBill, "amount_paid");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Monthnumber, "monthnum");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("id");
            entity.Property(e => e.Amount1)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("amount1");
            entity.Property(e => e.CashPaymentRs)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("cash_paymentRS");
            entity.Property(e => e.Chalanno)
                .HasMaxLength(255)
                .HasColumnName("chalanno");
            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Discountpercent)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("discountpercent");
            entity.Property(e => e.Drivername)
                .HasMaxLength(255)
                .HasColumnName("drivername");
            entity.Property(e => e.GstAmount)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("GST_amount");
            entity.Property(e => e.Gstcustomer)
                .HasMaxLength(255)
                .HasColumnName("gstcustomer");
            entity.Property(e => e.JamaAmt)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("jama_amt");
            entity.Property(e => e.Material)
                .HasMaxLength(255)
                .HasColumnName("material");
            entity.Property(e => e.Monthnamex)
                .HasMaxLength(25)
                .HasColumnName("monthnamex");
            entity.Property(e => e.Monthnumber)
                .HasDefaultValueSql("0")
                .HasColumnName("monthnumber");
            entity.Property(e => e.OnlinePaymentRs)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("online_paymentRS");
            entity.Property(e => e.Partyname).HasColumnName("partyname");
            entity.Property(e => e.Payablebillwithdiscount)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("payablebillwithdiscount");
            entity.Property(e => e.Qty)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RateApplied)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_applied");
            entity.Property(e => e.RateFromchart)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_fromchart");
            entity.Property(e => e.RegOrStock)
                .HasMaxLength(255)
                .HasDefaultValueSql("\"Regular\"")
                .HasColumnName("reg_or_stock");
            entity.Property(e => e.Royalty)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("royalty");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
            entity.Property(e => e.Summary)
                .HasMaxLength(255)
                .HasColumnName("summary");
            entity.Property(e => e.Supervisorname)
                .HasMaxLength(255)
                .HasColumnName("supervisorname");
            entity.Property(e => e.Timex)
                .HasMaxLength(255)
                .HasColumnName("timex");
            entity.Property(e => e.Ton)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("ton");
            entity.Property(e => e.TotalAmountBill)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Total_amount_bill");
            entity.Property(e => e.TransportCharge)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("transport_charge");
            entity.Property(e => e.Trip)
                .HasMaxLength(255)
                .HasColumnName("trip");
            entity.Property(e => e.Txtpartynamesearched)
                .HasMaxLength(255)
                .HasColumnName("txtpartynamesearched");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
            entity.Property(e => e.Yearnamex)
                .HasMaxLength(255)
                .HasColumnName("yearnamex");
        });

        modelBuilder.Entity<TblPartyYeneBaki>(entity =>
        {
            entity.HasKey(e => e.Partyname).HasName("PrimaryKey");

            entity.ToTable("tbl_party_yene_baki");

            entity.Property(e => e.Partyname).HasColumnName("partyname");
            entity.Property(e => e.Yenebaki)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("yenebaki");
        });

        modelBuilder.Entity<TblRateChartPartywise>(entity =>
        {
            entity.HasKey(e => e.Partyname).HasName("PrimaryKey");

            entity.ToTable("tblRateChart_partywise");

            entity.HasIndex(e => e.Indexnum, "indexnum");

            entity.Property(e => e.Partyname).HasColumnName("partyname");
            entity.Property(e => e.Indexnum)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("indexnum");
            entity.Property(e => e.Rate10mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_10MM");
            entity.Property(e => e.Rate20mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_20MM");
            entity.Property(e => e.Rate26mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_26MM");
            entity.Property(e => e.Rate40mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_40MM");
            entity.Property(e => e.Rate60mm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_60MM");
            entity.Property(e => e.Rate8by6)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_8BY6");
            entity.Property(e => e.RateDust)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_DUST");
            entity.Property(e => e.RateGsb)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_GSB");
            entity.Property(e => e.RateMsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_MSAND");
            entity.Property(e => e.RateRoboSand)
                .HasDefaultValueSql("0")
                .HasColumnName("rate_robo_sand");
            entity.Property(e => e.RateSander)
                .HasDefaultValueSql("0")
                .HasColumnName("rate_sander");
            entity.Property(e => e.RateStone)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_STONE");
            entity.Property(e => e.RateWmm)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_WMM");
            entity.Property(e => e.RateWpsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_WPSAND");
            entity.Property(e => e.RateWsand)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("rate_WSAND");
        });

        modelBuilder.Entity<Tblpartynamelist>(entity =>
        {
            entity.HasKey(e => e.Partyname).HasName("PrimaryKey");

            entity.ToTable("tblpartynamelist");

            entity.Property(e => e.Partyname).HasColumnName("partyname");
            entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
            entity.Property(e => e.GstCustomer)
                .HasMaxLength(255)
                .HasColumnName("gst_customer");
            entity.Property(e => e.Transcharge)
                .HasDefaultValueSql("0")
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TRANSCHARGE");
        });

        modelBuilder.Entity<TblpartynamelistQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tblpartynamelist Query");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PrimaryKey");

            entity.ToTable("user");

            entity.Property(e => e.Username).HasColumnName("username");
            entity.Property(e => e.Namesurname)
                .HasMaxLength(255)
                .HasColumnName("namesurname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vehicle");

            entity.Property(e => e.Datex).HasColumnName("datex");
            entity.Property(e => e.Partyname)
                .HasMaxLength(255)
                .HasColumnName("partyname");
            entity.Property(e => e.Site)
                .HasMaxLength(255)
                .HasColumnName("site");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(255)
                .HasColumnName("vehicleno");
        });

        modelBuilder.Entity<WhHorizontal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wh-horizontal");

            entity.Property(e => e.Expr1000).HasMaxLength(255);
            entity.Property(e => e.Expr1001).HasMaxLength(255);
            entity.Property(e => e.Expr1002).HasMaxLength(255);
            entity.Property(e => e.Expr1003).HasMaxLength(255);
            entity.Property(e => e.Expr1004).HasMaxLength(255);
            entity.Property(e => e.Expr1005).HasColumnType("decimal(28, 3)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
