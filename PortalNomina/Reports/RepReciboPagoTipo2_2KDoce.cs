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
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
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
    private XRLine xrLine6;
    private XRLine xrLine9;
    private XRLine xrLine8;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepReciboPagoTipo2_2KDoce));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
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
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.fechaDesde = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechaHasta = new DevExpress.XtraReports.Parameters.Parameter();
            this.codEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            this.numRecibo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText9 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText10 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).BeginInit();
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
            this.DS_NOMI.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            customSqlQuery1});
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
            this.TopMargin.HeightF = 70F;
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
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.00001F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(429.3348F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(429.3348F, 6.00001F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(380.6652F, 23F);
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
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(198.9583F, 22.24997F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(401.6667F, 26.27767F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Recibo de Pago";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(810F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // tableCell8
            // 
            this.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cod_emp]")});
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailData1";
            this.tableCell8.StylePriority.UseBorders = false;
            this.tableCell8.Weight = 0.12452350323016827D;
            // 
            // tableCell9
            // 
            this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombre_completo]")});
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailData1";
            this.tableCell9.Weight = 0.42778702478201885D;
            // 
            // tableCell10
            // 
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[reci_num]")});
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailData1";
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell10.Weight = 0.10820447522977902D;
            // 
            // tableCell11
            // 
            this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[auxi_cha]")});
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailData1";
            this.tableCell11.Weight = 0.12035943842028327D;
            // 
            // tableCell12
            // 
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[auxi_num]")});
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailData1";
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell12.TextFormatString = "{0:C2}";
            this.tableCell12.Weight = 0.11337279141067239D;
            // 
            // tableCell13
            // 
            this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[co_conce]")});
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailData1";
            this.tableCell13.Weight = 0.15376474177343247D;
            // 
            // tableCell14
            // 
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_conce]")});
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailData1";
            this.tableCell14.Weight = 0.19814184205395544D;
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
            this.PageHeader.HeightF = 106.1667F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(808.3333F, 2F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(2.916622F, 71.44427F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(804.1666F, 2.083328F);
            // 
            // xrLine3
            // 
            this.xrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(807.0833F, 1.999998F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(2.083313F, 104.1667F);
            // 
            // xrLine4
            // 
            this.xrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 1.999998F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(2.083333F, 104.1667F);
            // 
            // xrRichText1
            // 
            this.xrRichText1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(13F, 77.16667F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(56.25F, 20.91665F);
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_emis]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(69.24997F, 77.16667F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[reci_num]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(725F, 77.16667F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(74.99994F, 20.91665F);
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrRichText2
            // 
            this.xrRichText2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(637.5F, 77.16667F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(87.5F, 20.91665F);
            this.xrRichText2.StylePriority.UseFont = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(212.5834F, 77.16667F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(62.49998F, 20.91665F);
            this.xrRichText3.StylePriority.UseFont = false;
            // 
            // xrRichText4
            // 
            this.xrRichText4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(424.3348F, 77.16667F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(62.5F, 20.91665F);
            this.xrRichText4.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_ini]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(275.0833F, 77.16667F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextFormatString = "{0:d}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fec_fin]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(486.8348F, 77.16667F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 20.91665F);
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "{0:d}";
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(2.916687F, 104.0833F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(804.1666F, 2.083328F);
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cod_emp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Level = 1;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
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
            this.xrLine8,
            this.xrLine7,
            this.xrLine6});
            this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("reci_num", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand2.HeightF = 87.16668F;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Level = 1;
            this.groupFooterBand1.Name = "groupFooterBand1";
            // 
            // groupFooterBand2
            // 
            this.groupFooterBand2.Name = "groupFooterBand2";
            // 
            // xrLine6
            // 
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 6F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(808.3333F, 2F);
            // 
            // xrLine7
            // 
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0.666687F, 85.16668F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(808.3333F, 2F);
            // 
            // xrLine8
            // 
            this.xrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0.8333206F, 7.999992F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(2.083333F, 77.16669F);
            // 
            // xrLine9
            // 
            this.xrLine9.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(807.0833F, 7.999992F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(2.083313F, 77.16669F);
            // 
            // xrRichText5
            // 
            this.xrRichText5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(12.99998F, 15.99998F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(86.45834F, 20.91665F);
            this.xrRichText5.StylePriority.UseFont = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cod_emp]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(99.45831F, 15.99998F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(69.79167F, 20.91665F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombre_completo]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(169.25F, 15.99998F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(189.7519F, 20.91665F);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrRichText6
            // 
            this.xrRichText6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(375.0001F, 15.99998F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(64.75143F, 20.91665F);
            this.xrRichText6.StylePriority.UseFont = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ci]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(439.7515F, 15.99998F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(84.37503F, 20.91665F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha_ing]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(662.5F, 15.99998F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(137.4999F, 20.91665F);
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextFormatString = "{0:d}";
            // 
            // xrRichText7
            // 
            this.xrRichText7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(536.4691F, 15.99998F);
            this.xrRichText7.Name = "xrRichText7";
            this.xrRichText7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
            this.xrRichText7.SizeF = new System.Drawing.SizeF(126.0309F, 20.91665F);
            this.xrRichText7.StylePriority.UseFont = false;
            // 
            // xrRichText8
            // 
            this.xrRichText8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(13.00001F, 53.25003F);
            this.xrRichText8.Name = "xrRichText8";
            this.xrRichText8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
            this.xrRichText8.SizeF = new System.Drawing.SizeF(121.875F, 20.91665F);
            this.xrRichText8.StylePriority.UseFont = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SueldoMensVar]")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(134.875F, 53.25003F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(119.375F, 20.91665F);
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrRichText9
            // 
            this.xrRichText9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText9.LocationFloat = new DevExpress.Utils.PointFloat(275.0833F, 53.25003F);
            this.xrRichText9.Name = "xrRichText9";
            this.xrRichText9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText9.SerializableRtfString = resources.GetString("xrRichText9.SerializableRtfString");
            this.xrRichText9.SizeF = new System.Drawing.SizeF(110.4167F, 20.91665F);
            this.xrRichText9.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_depart]")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(385.5F, 53.25003F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(138.6265F, 20.91665F);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrRichText10
            // 
            this.xrRichText10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText10.LocationFloat = new DevExpress.Utils.PointFloat(536.469F, 53.25003F);
            this.xrRichText10.Name = "xrRichText10";
            this.xrRichText10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText10.SerializableRtfString = resources.GetString("xrRichText10.SerializableRtfString");
            this.xrRichText10.SizeF = new System.Drawing.SizeF(50.36584F, 20.91665F);
            this.xrRichText10.StylePriority.UseFont = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[co_cargo]")});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(586.8348F, 53.25003F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(75.66516F, 20.91665F);
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[des_cargo]")});
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(662.5F, 53.25003F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(137.4999F, 20.91665F);
            this.xrLabel12.Text = "xrLabel12";
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
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DS_NOMI});
            this.DataMember = "RepReciboPagoTipo2_2KDoce";
            this.DataSource = this.DS_NOMI;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 70, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.fechaDesde,
            this.fechaHasta,
            this.codEmpleado,
            this.numRecibo});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RepReciboPagoTipo2_2KDoce_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).EndInit();
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
