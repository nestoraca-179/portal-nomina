using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

/// <summary>
/// Summary description for RepReciboPagoTipo2_2KDoce
/// </summary>
public class RepReciboPagoTipo2_2KDoce : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.DataAccess.Sql.SqlDataSource DS_NOMI;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private DetailBand Detail;
    private DevExpress.XtraReports.Parameters.Parameter fechaDesde;
    private DevExpress.XtraReports.Parameters.Parameter fechaHasta;
    private DevExpress.XtraReports.Parameters.Parameter codEmpleado;
    private DevExpress.XtraReports.Parameters.Parameter numRecibo;
    private PageHeaderBand PageHeader;
    private XRLine xrLine2;
    private XRLine xrLine1;
    private XRLine xrLine4;
    private XRLine xrLine3;
    private XRLabel xrLabel1;
    private XRRichText xrRichText1;
    private XRRichText xrRichText2;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRRichText xrRichText4;
    private XRRichText xrRichText3;
    private XRLine xrLine5;
    private GroupHeaderBand groupHeaderBand1;
    private GroupHeaderBand groupHeaderBand2;
    private GroupFooterBand groupFooterBand1;
    private GroupFooterBand groupFooterBand2;
    private XRLine xrLine7;
    private XRLine xrLine9;
    private XRRichText xrRichText5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRRichText xrRichText6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRRichText xrRichText7;
    private XRLabel xrLabel9;
    private XRRichText xrRichText8;
    private XRLabel xrLabel10;
    private XRRichText xrRichText9;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRRichText xrRichText10;
    private XRLine xrLine10;
    private XRRichText xrRichText11;
    private XRLine xrLine6;
    private XRRichText xrRichText13;
    private XRRichText xrRichText12;
    private XRRichText xrRichText14;
    private XRRichText xrRichText15;
    private XRRichText xrRichText16;
    private XRLine xrLine14;
    private XRLine xrLine13;
    private XRLine xrLine12;
    private XRLine xrLine11;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel16;
    private XRLabel xrLabel15;
    private CalculatedField totalAsignaciones;
    private CalculatedField totalDeducciones;
    private XRLabel xrLabel18;
    private XRLabel xrLabel17;
    private CalculatedField asignacion;
    private CalculatedField deduccion;
    private XRLine xrLine8;
    private XRLine xrLine16;
    private XRRichText xrRichText17;
    private XRLabel xrLabel20;
    private XRLabel xrLabel19;
    private XRLabel xrLabel21;
    private XRLabel xrLabel23;
    private XRLabel xrLabel22;
    private XRRichText xrRichText19;
    private XRRichText xrRichText18;
    private XRLine xrLine20;
    private XRLine xrLine19;
    private XRLine xrLine18;
    private XRLine xrLine17;
    private XRLine xrLine24;
    private XRLine xrLine23;
    private XRLine xrLine22;
    private XRLine xrLine21;
    private XRLine xrLine25;
    private XRRichText xrRichText20;
    private XRLine xrLine26;
    private XRLine xrLine27;
    private XRLine xrLine32;
    private XRLine xrLine31;
    private XRLine xrLine30;
    private XRLine xrLine29;
    private XRLine xrLine28;
    private XRLine xrLine15;
    private XRLine xrLine38;
    private XRLine xrLine37;
    private XRLine xrLine36;
    private XRLine xrLine35;
    private XRLine xrLine34;
    private XRLine xrLine33;
    public DevExpress.XtraReports.Parameters.Parameter DB;
    private XRLabel xrLabel27;
    private XRLabel xrLabel26;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepReciboPagoTipo2_2KDoce()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepReciboPagoTipo2_2KDoce));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.DS_NOMI = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine32 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine31 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine30 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine29 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine28 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine26 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine27 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.fechaDesde = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechaHasta = new DevExpress.XtraReports.Parameters.Parameter();
            this.codEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            this.numRecibo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine15 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine14 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText16 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText15 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText14 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText13 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText12 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText11 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText10 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText9 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine38 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine37 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine36 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine35 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine34 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine33 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine25 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText20 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine24 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine23 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine22 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine21 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText19 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText18 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine20 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine19 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine18 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine17 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText17 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine16 = new DevExpress.XtraReports.UI.XRLine();
            this.totalAsignaciones = new DevExpress.XtraReports.UI.CalculatedField();
            this.totalDeducciones = new DevExpress.XtraReports.UI.CalculatedField();
            this.asignacion = new DevExpress.XtraReports.UI.CalculatedField();
            this.deduccion = new DevExpress.XtraReports.UI.CalculatedField();
            this.DB = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DS_NOMI
            // 
            this.DS_NOMI.ConnectionName = "DB_NOMI";
            this.DS_NOMI.Name = "DS_NOMI";
            storedProcQuery1.Name = "RepReciboPagoTipo2_2KDoce";
            queryParameter1.Name = "@sdFec_Emis_d";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?fechaDesde", typeof(System.DateTime));
            queryParameter2.Name = "@sdFec_Emis_h";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?fechaHasta", typeof(System.DateTime));
            queryParameter3.Name = "@sCod_Emp_d";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?codEmpleado", typeof(string));
            queryParameter4.Name = "@sCod_Emp_h";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?codEmpleado", typeof(string));
            queryParameter5.Name = "@iReci_Num_d";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?numRecibo", typeof(int));
            queryParameter6.Name = "@iReci_Num_h";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?numRecibo", typeof(int));
            queryParameter7.Name = "@sCo_Depart";
            queryParameter7.Type = typeof(string);
            queryParameter8.Name = "@sCo_Cont";
            queryParameter8.Type = typeof(string);
            queryParameter9.Name = "@sCo_DepartGen_d";
            queryParameter9.Type = typeof(string);
            queryParameter10.Name = "@sCo_DepartGen_h";
            queryParameter10.Type = typeof(string);
            queryParameter11.Name = "@sCo_ContGen_d";
            queryParameter11.Type = typeof(string);
            queryParameter12.Name = "@sCo_ContGen_h";
            queryParameter12.Type = typeof(string);
            queryParameter13.Name = "@sCampOrderBy";
            queryParameter13.Type = typeof(string);
            queryParameter14.Name = "@sDir";
            queryParameter14.Type = typeof(string);
            queryParameter15.Name = "@bHeaderRep";
            queryParameter15.Type = typeof(bool);
            queryParameter15.ValueInfo = "False";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.Parameters.Add(queryParameter9);
            storedProcQuery1.Parameters.Add(queryParameter10);
            storedProcQuery1.Parameters.Add(queryParameter11);
            storedProcQuery1.Parameters.Add(queryParameter12);
            storedProcQuery1.Parameters.Add(queryParameter13);
            storedProcQuery1.Parameters.Add(queryParameter14);
            storedProcQuery1.Parameters.Add(queryParameter15);
            storedProcQuery1.StoredProcName = "RepReciboPagoTipo2_2KDoce";
            customSqlQuery1.Name = "Empleados";
            customSqlQuery1.Sql = "select cod_emp, nombre_completo from snemple\r\norder by apellidos";
            customSqlQuery2.Name = "Master";
            queryParameter16.Name = "DB";
            queryParameter16.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter16.Value = new DevExpress.DataAccess.Expression("?DB", typeof(string));
            customSqlQuery2.Parameters.Add(queryParameter16);
            customSqlQuery2.Sql = "select * from MasterProfitPro.dbo.MpEmpresa\r\nwhere cod_empresa = @DB";
            this.DS_NOMI.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            customSqlQuery1,
            customSqlQuery2});
            this.DS_NOMI.ResultSchemaSerializable = resources.GetString("DS_NOMI.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 13.75F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(405F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(405F, 9.999974F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(405.0001F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Página {0} de {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(249.7704F, 87.20825F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(300.625F, 26.27767F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Recibo de Pago";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine32,
            this.xrLine31,
            this.xrLine30,
            this.xrLine29,
            this.xrLine28,
            this.xrLine26,
            this.xrLine27,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13});
            this.Detail.HeightF = 25.70057F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrLine32
            // 
            this.xrLine32.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine32.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine32.LocationFloat = new DevExpress.Utils.PointFloat(807.8198F, 0F);
            this.xrLine32.Name = "xrLine32";
            this.xrLine32.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine31
            // 
            this.xrLine31.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine31.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine31.LocationFloat = new DevExpress.Utils.PointFloat(692.3615F, 0F);
            this.xrLine31.Name = "xrLine31";
            this.xrLine31.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine30
            // 
            this.xrLine30.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine30.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine30.LocationFloat = new DevExpress.Utils.PointFloat(586.7379F, 0F);
            this.xrLine30.Name = "xrLine30";
            this.xrLine30.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine29
            // 
            this.xrLine29.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine29.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine29.LocationFloat = new DevExpress.Utils.PointFloat(484.6546F, 0F);
            this.xrLine29.Name = "xrLine29";
            this.xrLine29.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine28
            // 
            this.xrLine28.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine28.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine28.LocationFloat = new DevExpress.Utils.PointFloat(370.143F, 0F);
            this.xrLine28.Name = "xrLine28";
            this.xrLine28.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine26
            // 
            this.xrLine26.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine26.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine26.Name = "xrLine26";
            this.xrLine26.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLine27
            // 
            this.xrLine27.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine27.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine27.LocationFloat = new DevExpress.Utils.PointFloat(86.22635F, 0F);
            this.xrLine27.Name = "xrLine27";
            this.xrLine27.SizeF = new System.Drawing.SizeF(2.180229F, 25.70057F);
            // 
            // xrLabel18
            // 
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[deduccion]")});
            this.xrLabel18.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(594.2753F, 0.9999781F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(91.93262F, 23F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "xrLabel18";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel18.TextFormatString = "{0:n2}";
            // 
            // xrLabel17
            // 
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[asignacion]")});
            this.xrLabel17.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(490.8348F, 0.9999781F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(91.23364F, 23F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel17.TextFormatString = "{0:n2}";
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[auxi_cha]")});
            this.xrLabel16.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(424.1264F, 0.9999781F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(52.87366F, 23F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "xrLabel16";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[auxi_num]")});
            this.xrLabel15.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(377.0001F, 0.9999781F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(42.30765F, 23F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel15.TextFormatString = "{0:n2}";
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_conce]")});
            this.xrLabel14.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(94.30968F, 0.9999781F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(270F, 23F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "xrLabel14";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[co_conce]")});
            this.xrLabel13.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(13.00002F, 0.9999781F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(67.94024F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Description = "Desde";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Type = typeof(System.DateTime);
            // 
            // fechaHasta
            // 
            this.fechaHasta.Description = "Hasta";
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Type = typeof(System.DateTime);
            // 
            // codEmpleado
            // 
            this.codEmpleado.Description = "Trabajador";
            dynamicListLookUpSettings1.DataMember = "Empleados";
            dynamicListLookUpSettings1.DataSource = this.DS_NOMI;
            dynamicListLookUpSettings1.DisplayMember = "nombre_completo";
            dynamicListLookUpSettings1.ValueMember = "cod_emp";
            this.codEmpleado.LookUpSettings = dynamicListLookUpSettings1;
            this.codEmpleado.Name = "codEmpleado";
            // 
            // numRecibo
            // 
            this.numRecibo.AllowNull = true;
            this.numRecibo.Name = "numRecibo";
            this.numRecibo.Type = typeof(int);
            this.numRecibo.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLine5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrRichText4,
            this.xrRichText3,
            this.xrRichText2,
            this.xrLabel2,
            this.xrLabel1,
            this.xrRichText1,
            this.xrLine4,
            this.xrLine3,
            this.xrLine2,
            this.xrLine1,
            this.label1});
            this.PageHeader.HeightF = 170F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(2.916687F, 167.9167F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(804.1666F, 2.083328F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_fin]")});
            this.xrLabel4.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(486.8348F, 141F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel4.TextFormatString = "{0:d}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_ini]")});
            this.xrLabel3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(275.0833F, 141F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel3.TextFormatString = "{0:d}";
            // 
            // xrRichText4
            // 
            this.xrRichText4.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(424.3348F, 141F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(62.5F, 20.91665F);
            this.xrRichText4.StylePriority.UseFont = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(212.5834F, 141F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(62.49998F, 20.91665F);
            this.xrRichText3.StylePriority.UseFont = false;
            // 
            // xrRichText2
            // 
            this.xrRichText2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(637.5F, 141F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(87.5F, 20.91665F);
            this.xrRichText2.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[reci_num]")});
            this.xrLabel2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(725F, 141F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(74.99994F, 20.91665F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_emis]")});
            this.xrLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(69.24997F, 141F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrRichText1
            // 
            this.xrRichText1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(13F, 141F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(56.25F, 20.91665F);
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrLine4
            // 
            this.xrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 1.999998F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(2.083333F, 165.9167F);
            // 
            // xrLine3
            // 
            this.xrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(807.0833F, 1.999998F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(2.083313F, 165.9167F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(2.916622F, 135.2776F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(804.1666F, 2.083328F);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(808.3333F, 2F);
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cod_emp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.KeepTogether = true;
            this.groupHeaderBand1.Level = 1;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine15,
            this.xrLine8,
            this.xrLine14,
            this.xrLine13,
            this.xrLine12,
            this.xrLine11,
            this.xrRichText16,
            this.xrRichText15,
            this.xrRichText14,
            this.xrRichText13,
            this.xrRichText12,
            this.xrLine10,
            this.xrRichText11,
            this.xrLabel12,
            this.xrLabel11,
            this.xrRichText10,
            this.xrLabel10,
            this.xrRichText9,
            this.xrLabel9,
            this.xrRichText8,
            this.xrRichText7,
            this.xrLabel8,
            this.xrLabel7,
            this.xrRichText6,
            this.xrLabel6,
            this.xrLabel5,
            this.xrRichText5,
            this.xrLine9,
            this.xrLine7,
            this.xrLine6});
            this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("reci_num", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand2.HeightF = 125.0502F;
            this.groupHeaderBand2.KeepTogether = true;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            this.groupHeaderBand2.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry;
            // 
            // xrLine15
            // 
            this.xrLine15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine15.LocationFloat = new DevExpress.Utils.PointFloat(692.3615F, 87.2169F);
            this.xrLine15.Name = "xrLine15";
            this.xrLine15.SizeF = new System.Drawing.SizeF(2.083374F, 35.78311F);
            // 
            // xrLine8
            // 
            this.xrLine8.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.99999F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(2.083327F, 117F);
            // 
            // xrLine14
            // 
            this.xrLine14.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine14.LocationFloat = new DevExpress.Utils.PointFloat(586.8347F, 87.21688F);
            this.xrLine14.Name = "xrLine14";
            this.xrLine14.SizeF = new System.Drawing.SizeF(2.083374F, 35.78311F);
            // 
            // xrLine13
            // 
            this.xrLine13.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(484.7515F, 87.21688F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(2.083313F, 35.78313F);
            // 
            // xrLine12
            // 
            this.xrLine12.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(370.3097F, 87.21688F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(2.083344F, 35.78313F);
            // 
            // xrLine11
            // 
            this.xrLine11.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(86.22635F, 87.21688F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(2.083351F, 35.78311F);
            // 
            // xrRichText16
            // 
            this.xrRichText16.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText16.LocationFloat = new DevExpress.Utils.PointFloat(377.0001F, 93.16667F);
            this.xrRichText16.Name = "xrRichText16";
            this.xrRichText16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText16.SerializableRtfString = resources.GetString("xrRichText16.SerializableRtfString");
            this.xrRichText16.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrRichText16.StylePriority.UseFont = false;
            // 
            // xrRichText15
            // 
            this.xrRichText15.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText15.LocationFloat = new DevExpress.Utils.PointFloat(490.8348F, 93.16667F);
            this.xrRichText15.Name = "xrRichText15";
            this.xrRichText15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText15.SerializableRtfString = resources.GetString("xrRichText15.SerializableRtfString");
            this.xrRichText15.SizeF = new System.Drawing.SizeF(91.23358F, 20.91665F);
            this.xrRichText15.StylePriority.UseFont = false;
            // 
            // xrRichText14
            // 
            this.xrRichText14.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText14.LocationFloat = new DevExpress.Utils.PointFloat(594.2753F, 93.16667F);
            this.xrRichText14.Name = "xrRichText14";
            this.xrRichText14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText14.SerializableRtfString = resources.GetString("xrRichText14.SerializableRtfString");
            this.xrRichText14.SizeF = new System.Drawing.SizeF(91.93256F, 20.91665F);
            this.xrRichText14.StylePriority.UseFont = false;
            // 
            // xrRichText13
            // 
            this.xrRichText13.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText13.LocationFloat = new DevExpress.Utils.PointFloat(700.5417F, 93.16667F);
            this.xrRichText13.Name = "xrRichText13";
            this.xrRichText13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText13.SerializableRtfString = resources.GetString("xrRichText13.SerializableRtfString");
            this.xrRichText13.SizeF = new System.Drawing.SizeF(98.95825F, 20.91665F);
            this.xrRichText13.StylePriority.UseFont = false;
            // 
            // xrRichText12
            // 
            this.xrRichText12.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText12.LocationFloat = new DevExpress.Utils.PointFloat(94.30968F, 93.16667F);
            this.xrRichText12.Name = "xrRichText12";
            this.xrRichText12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText12.SerializableRtfString = resources.GetString("xrRichText12.SerializableRtfString");
            this.xrRichText12.SizeF = new System.Drawing.SizeF(270F, 20.91665F);
            this.xrRichText12.StylePriority.UseFont = false;
            // 
            // xrLine10
            // 
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 123F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(810F, 2.050201F);
            // 
            // xrRichText11
            // 
            this.xrRichText11.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText11.LocationFloat = new DevExpress.Utils.PointFloat(12.99998F, 93.16667F);
            this.xrRichText11.Name = "xrRichText11";
            this.xrRichText11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText11.SerializableRtfString = resources.GetString("xrRichText11.SerializableRtfString");
            this.xrRichText11.SizeF = new System.Drawing.SizeF(67.9403F, 20.91665F);
            this.xrRichText11.StylePriority.UseFont = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_cargo]")});
            this.xrLabel12.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(605.2272F, 53.25003F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(194.7728F, 20.91665F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "xrLabel12";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[co_cargo]")});
            this.xrLabel11.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(550.3952F, 53.25003F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(54.83197F, 20.91665F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "xrLabel11";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrRichText10
            // 
            this.xrRichText10.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText10.LocationFloat = new DevExpress.Utils.PointFloat(500.0295F, 53.25003F);
            this.xrRichText10.Name = "xrRichText10";
            this.xrRichText10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText10.SerializableRtfString = resources.GetString("xrRichText10.SerializableRtfString");
            this.xrRichText10.SizeF = new System.Drawing.SizeF(50.36584F, 20.91665F);
            this.xrRichText10.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_depart]")});
            this.xrLabel10.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(290.1668F, 53.25003F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(194.4879F, 20.91665F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "xrLabel10";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrRichText9
            // 
            this.xrRichText9.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText9.LocationFloat = new DevExpress.Utils.PointFloat(200.5834F, 53.25003F);
            this.xrRichText9.Name = "xrRichText9";
            this.xrRichText9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText9.SerializableRtfString = resources.GetString("xrRichText9.SerializableRtfString");
            this.xrRichText9.SizeF = new System.Drawing.SizeF(89.58333F, 20.91665F);
            this.xrRichText9.StylePriority.UseFont = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SueldoMensVar]")});
            this.xrLabel9.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(116.125F, 53.25003F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(71.45837F, 20.91665F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel9.TextFormatString = "{0:n2}";
            // 
            // xrRichText8
            // 
            this.xrRichText8.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(12.99998F, 53.25003F);
            this.xrRichText8.Name = "xrRichText8";
            this.xrRichText8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
            this.xrRichText8.SizeF = new System.Drawing.SizeF(103.125F, 20.91665F);
            this.xrRichText8.StylePriority.UseFont = false;
            // 
            // xrRichText7
            // 
            this.xrRichText7.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(586.7379F, 15.99998F);
            this.xrRichText7.Name = "xrRichText7";
            this.xrRichText7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
            this.xrRichText7.SizeF = new System.Drawing.SizeF(105.1976F, 20.91665F);
            this.xrRichText7.StylePriority.UseFont = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha_ing]")});
            this.xrLabel8.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(692.3615F, 15.99998F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(107.6384F, 20.91665F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel8.TextFormatString = "{0:d}";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ci]")});
            this.xrLabel7.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(484.6546F, 15.99998F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(84.37503F, 20.91665F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrRichText6
            // 
            this.xrRichText6.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(419.9032F, 15.99998F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(64.75143F, 20.91665F);
            this.xrRichText6.StylePriority.UseFont = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombre_completo]")});
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(139.0416F, 15.99998F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(265.9584F, 20.91665F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cod_emp]")});
            this.xrLabel5.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(80.94025F, 15.99998F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(58.10136F, 20.91665F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrRichText5
            // 
            this.xrRichText5.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(12.99998F, 15.99998F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(67.9403F, 20.91665F);
            this.xrRichText5.StylePriority.UseFont = false;
            // 
            // xrLine9
            // 
            this.xrLine9.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLine9.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(807.9167F, 5.999992F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(2.083313F, 117F);
            // 
            // xrLine7
            // 
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(2.083325F, 85.16668F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(805.8334F, 2.050201F);
            // 
            // xrLine6
            // 
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(2.083327F, 5.955583F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(805.8334F, 2.050199F);
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.KeepTogether = true;
            this.groupFooterBand1.Level = 1;
            this.groupFooterBand1.Name = "groupFooterBand1";
            // 
            // groupFooterBand2
            // 
            this.groupFooterBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine38,
            this.xrLine37,
            this.xrLine36,
            this.xrLine35,
            this.xrLine34,
            this.xrLine33,
            this.xrLine25,
            this.xrRichText20,
            this.xrLine24,
            this.xrLine23,
            this.xrLine22,
            this.xrLine21,
            this.xrLabel23,
            this.xrLabel22,
            this.xrRichText19,
            this.xrRichText18,
            this.xrLine20,
            this.xrLine19,
            this.xrLine18,
            this.xrLine17,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrRichText17,
            this.xrLine16});
            this.groupFooterBand2.HeightF = 100.6635F;
            this.groupFooterBand2.KeepTogether = true;
            this.groupFooterBand2.Name = "groupFooterBand2";
            // 
            // xrLine38
            // 
            this.xrLine38.LocationFloat = new DevExpress.Utils.PointFloat(370.3097F, 31.99999F);
            this.xrLine38.Name = "xrLine38";
            this.xrLine38.SizeF = new System.Drawing.SizeF(439.6903F, 2.058701F);
            // 
            // xrLine37
            // 
            this.xrLine37.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine37.LocationFloat = new DevExpress.Utils.PointFloat(370.143F, 2.058699F);
            this.xrLine37.Name = "xrLine37";
            this.xrLine37.SizeF = new System.Drawing.SizeF(2.180237F, 29.9413F);
            // 
            // xrLine36
            // 
            this.xrLine36.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine36.LocationFloat = new DevExpress.Utils.PointFloat(484.6546F, 2.058699F);
            this.xrLine36.Name = "xrLine36";
            this.xrLine36.SizeF = new System.Drawing.SizeF(2.180237F, 29.9413F);
            // 
            // xrLine35
            // 
            this.xrLine35.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine35.LocationFloat = new DevExpress.Utils.PointFloat(586.8347F, 2.058702F);
            this.xrLine35.Name = "xrLine35";
            this.xrLine35.SizeF = new System.Drawing.SizeF(2.180237F, 29.9413F);
            // 
            // xrLine34
            // 
            this.xrLine34.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine34.LocationFloat = new DevExpress.Utils.PointFloat(692.2646F, 2.058699F);
            this.xrLine34.Name = "xrLine34";
            this.xrLine34.SizeF = new System.Drawing.SizeF(2.180237F, 29.9413F);
            // 
            // xrLine33
            // 
            this.xrLine33.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine33.LocationFloat = new DevExpress.Utils.PointFloat(807.8198F, 0F);
            this.xrLine33.Name = "xrLine33";
            this.xrLine33.SizeF = new System.Drawing.SizeF(2.180237F, 32F);
            // 
            // xrLine25
            // 
            this.xrLine25.LocationFloat = new DevExpress.Utils.PointFloat(121.6667F, 86.62421F);
            this.xrLine25.Name = "xrLine25";
            this.xrLine25.SizeF = new System.Drawing.SizeF(227.0833F, 2.083336F);
            // 
            // xrRichText20
            // 
            this.xrRichText20.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText20.LocationFloat = new DevExpress.Utils.PointFloat(13.00001F, 65.83255F);
            this.xrRichText20.Name = "xrRichText20";
            this.xrRichText20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText20.SerializableRtfString = resources.GetString("xrRichText20.SerializableRtfString");
            this.xrRichText20.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrRichText20.StylePriority.UseFont = false;
            // 
            // xrLine24
            // 
            this.xrLine24.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine24.LocationFloat = new DevExpress.Utils.PointFloat(1.430511E-05F, 9.083344F);
            this.xrLine24.Name = "xrLine24";
            this.xrLine24.SizeF = new System.Drawing.SizeF(2.083313F, 88.66586F);
            // 
            // xrLine23
            // 
            this.xrLine23.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine23.LocationFloat = new DevExpress.Utils.PointFloat(357.9167F, 9.083335F);
            this.xrLine23.Name = "xrLine23";
            this.xrLine23.SizeF = new System.Drawing.SizeF(2.083313F, 88.66586F);
            // 
            // xrLine22
            // 
            this.xrLine22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 97.74921F);
            this.xrLine22.Name = "xrLine22";
            this.xrLine22.SizeF = new System.Drawing.SizeF(360F, 2.083333F);
            // 
            // xrLine21
            // 
            this.xrLine21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.000001F);
            this.xrLine21.Name = "xrLine21";
            this.xrLine21.SizeF = new System.Drawing.SizeF(360F, 2.083333F);
            // 
            // xrLabel23
            // 
            this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_ban]")});
            this.xrLabel23.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(461.25F, 44.45832F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(338.2499F, 20.91665F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "xrLabel23";
            // 
            // xrLabel22
            // 
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cta_banc1]")});
            this.xrLabel22.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(461.25F, 72.83255F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(338.2499F, 20.91666F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "xrLabel22";
            // 
            // xrRichText19
            // 
            this.xrRichText19.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText19.LocationFloat = new DevExpress.Utils.PointFloat(379.0002F, 72.83255F);
            this.xrRichText19.Name = "xrRichText19";
            this.xrRichText19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText19.SerializableRtfString = resources.GetString("xrRichText19.SerializableRtfString");
            this.xrRichText19.SizeF = new System.Drawing.SizeF(70.83334F, 20.91665F);
            this.xrRichText19.StylePriority.UseFont = false;
            // 
            // xrRichText18
            // 
            this.xrRichText18.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText18.LocationFloat = new DevExpress.Utils.PointFloat(379.0002F, 44.45832F);
            this.xrRichText18.Name = "xrRichText18";
            this.xrRichText18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText18.SerializableRtfString = resources.GetString("xrRichText18.SerializableRtfString");
            this.xrRichText18.SizeF = new System.Drawing.SizeF(70.83334F, 20.91665F);
            this.xrRichText18.StylePriority.UseFont = false;
            // 
            // xrLine20
            // 
            this.xrLine20.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine20.LocationFloat = new DevExpress.Utils.PointFloat(807.9167F, 39.74921F);
            this.xrLine20.Name = "xrLine20";
            this.xrLine20.SizeF = new System.Drawing.SizeF(2.083313F, 57.99999F);
            // 
            // xrLine19
            // 
            this.xrLine19.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine19.LocationFloat = new DevExpress.Utils.PointFloat(369.3931F, 39.74921F);
            this.xrLine19.Name = "xrLine19";
            this.xrLine19.SizeF = new System.Drawing.SizeF(2.083313F, 57.99999F);
            // 
            // xrLine18
            // 
            this.xrLine18.LocationFloat = new DevExpress.Utils.PointFloat(370.143F, 97.74921F);
            this.xrLine18.Name = "xrLine18";
            this.xrLine18.SizeF = new System.Drawing.SizeF(438.857F, 2.083336F);
            // 
            // xrLine17
            // 
            this.xrLine17.LocationFloat = new DevExpress.Utils.PointFloat(370.3096F, 37.66587F);
            this.xrLine17.Name = "xrLine17";
            this.xrLine17.SizeF = new System.Drawing.SizeF(438.857F, 2.083336F);
            // 
            // xrLabel21
            // 
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Column31]")});
            this.xrLabel21.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(700.5417F, 7.000001F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(98.95825F, 20.91665F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel21.Summary = xrSummary1;
            this.xrLabel21.Text = "xrLabel21";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel21.TextFormatString = "{0:n2}";
            // 
            // xrLabel20
            // 
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([deduccion])")});
            this.xrLabel20.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(594.2753F, 7.000001F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(91.93256F, 20.91665F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel20.Summary = xrSummary2;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel20.TextFormatString = "{0:n2}";
            // 
            // xrLabel19
            // 
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([asignacion])")});
            this.xrLabel19.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(490.8348F, 7.000001F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(91.23367F, 20.91665F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel19.Summary = xrSummary3;
            this.xrLabel19.Text = "xrLabel19";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel19.TextFormatString = "{0:n2}";
            // 
            // xrRichText17
            // 
            this.xrRichText17.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText17.LocationFloat = new DevExpress.Utils.PointFloat(377.0001F, 7.000007F);
            this.xrRichText17.Name = "xrRichText17";
            this.xrRichText17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText17.SerializableRtfString = resources.GetString("xrRichText17.SerializableRtfString");
            this.xrRichText17.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrRichText17.StylePriority.UseFont = false;
            // 
            // xrLine16
            // 
            this.xrLine16.LocationFloat = new DevExpress.Utils.PointFloat(0.8332922F, 0F);
            this.xrLine16.Name = "xrLine16";
            this.xrLine16.SizeF = new System.Drawing.SizeF(806.9865F, 2.058699F);
            // 
            // totalAsignaciones
            // 
            this.totalAsignaciones.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.totalAsignaciones.Expression = "[][[tipo] == 1].Sum([monto])";
            this.totalAsignaciones.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.totalAsignaciones.Name = "totalAsignaciones";
            // 
            // totalDeducciones
            // 
            this.totalDeducciones.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.totalDeducciones.Expression = "[][[tipo] == 2 Or [tipo] == 3].Sum(([monto] * -1))";
            this.totalDeducciones.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.totalDeducciones.Name = "totalDeducciones";
            // 
            // asignacion
            // 
            this.asignacion.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.asignacion.Expression = "Iif([tipo] == 1, [monto], 0)";
            this.asignacion.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.asignacion.Name = "asignacion";
            // 
            // deduccion
            // 
            this.deduccion.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.deduccion.Expression = "Iif([tipo] == 2 Or [tipo] == 3, [monto] * -1, 0)";
            this.deduccion.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.deduccion.Name = "deduccion";
            // 
            // DB
            // 
            this.DB.AllowNull = true;
            this.DB.Description = "DB";
            this.DB.Name = "DB";
            this.DB.ValueInfo = "DEMON";
            this.DB.Visible = false;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(13.00001F, 13.00001F);
            this.xrLabel24.Multiline = true;
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(199.5833F, 21.95834F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.Text = "Profit Plus Nómina";
            // 
            // xrLabel25
            // 
            this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Master].[desc_empresa]")});
            this.xrLabel25.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(12.99998F, 34.95835F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(335.75F, 23F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = "xrLabel25";
            // 
            // xrLabel26
            // 
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Master].[rif]")});
            this.xrLabel26.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(51.54165F, 57.95835F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(161.0417F, 23F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "xrLabel26";
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(13.00001F, 57.95835F);
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(38.54163F, 23F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "RIF:";
            // 
            // RepReciboPagoTipo2_2KDoce
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.PageHeader,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.groupFooterBand1,
            this.groupFooterBand2});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.totalAsignaciones,
            this.totalDeducciones,
            this.asignacion,
            this.deduccion});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DS_NOMI});
            this.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.DataSource = this.DS_NOMI;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 14, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.fechaDesde,
            this.fechaHasta,
            this.codEmpleado,
            this.numRecibo,
            this.DB});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RepReciboPagoTipo2_2KDoce_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void RepReciboPagoTipo2_2KDoce_DataSourceDemanded(object sender, EventArgs e)
    {
        XtraReport report = (XtraReport)sender;
        var parameters = report.Parameters;

        foreach (var param in parameters)
        {
            if (param.Value != null)
            {
                if (param.Value.ToString() == "")
                {
                    param.Value = DBNull.Value;
                }
            }
        }
    }
}
