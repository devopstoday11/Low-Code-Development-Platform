namespace RO.Access3
{
	using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data;
	using System.Data.OleDb;
	using System.Drawing;
	using System.Text;
	using RO.Common3;
    using RO.Common3.Data;
	using RO.SystemFramewk;

	public abstract class AdminAccessBase : Encryption, IDisposable
    {
        public abstract string AddData(Int32 ScreenId, bool bDeferError, LoginUsr LUser, UsrImpr LImpr, UsrCurr LCurr, DataSet ds, string dbConnectionString, string dbPassword, CurrPrj CPrj, CurrSrc CSrc, bool noTrans = false);
        public abstract string AddDbDoc(string MasterId, string TblName, string DocName, string MimeType, long DocSize, byte[] dc, string dbConnectionString, string dbPassword, LoginUsr lu);
        public abstract int CountScrCri(string ScreenCriId, string MultiDesignDb, string dbConnectionString, string dbPassword);
        public abstract bool DelData(Int32 ScreenId, bool bDeferError, LoginUsr LUser, UsrImpr LImpr, UsrCurr LCurr, DataSet ds, string dbConnectionString, string dbPassword, CurrPrj CPrj, CurrSrc CSrc, bool noTrans = false);
        public abstract string DelDoc(string MasterId, string DocId, string UsrId, string DdlKeyTableName, string TableName, string ColumnName, string pMKey, string dbConnectionString, string dbPassword);
        public abstract void DelDshFld(string DshFldId, string dbConnectionString, string dbPassword);
        public abstract void DelDshFldDtl(string DshFldDtlId, string dbConnectionString, string dbPassword);
        public abstract void DelLastCriteria(Int32 screenId, Int32 reportId, Int32 usrId, string dbConnectionString, string dbPassword);
        public abstract void Dispose();
        public abstract DataTable GetAuthCol(Int32 ScreenId, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetAuthExp(Int32 ScreenId, Int16 CultureId, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetAuthRow(Int32 ScreenId, string RowAuthoritys, string dbConnectionString, string dbPassword);
        public abstract DataTable GetButtonHlp(Int32 screenId, Int32 reportId, Int32 wizardId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetClientRule(Int32 screenId, Int32 reportId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetCronJob(int? jobId, string jobLink, string dbConnectionString, string dbPassword);
        public abstract byte GetCult(string lang);
        public abstract DataTable GetDbDoc(string DocId, string TblName, string dbConnectionString, string dbPassword);
        public abstract DataTable GetDbImg(string DocId, string TblName, string KeyName, string ColName, string dbConnectionString, string dbPassword);
        public abstract DataTable GetDdl(Int32 screenId, string procedureName, bool bAddNew, bool bAll, int topN, string keyId, string dbConnectionString, string dbPassword, string filterTxt, UsrImpr ui, UsrCurr uc);
        public abstract string GetDesignVersion(string ns, string dbConnectionString, string dbPassword);
        public abstract string GetDocId(string MasterId, string TblName, string DocName, string UsrId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetDtlById(Int32 screenId, string procedureName, string keyId, string dbConnectionString, string dbPassword, Int32 screenFilterId, UsrImpr ui, UsrCurr uc);
        public abstract DataTable GetExp(Int32 screenId, string procedureName, string useGlobalFilter, string dbConnectionString, string dbPassword, Int32 screenFilterId, DataView dvCri, UsrImpr ui, UsrCurr uc, DataSet ds);
        public abstract DataTable GetFxRate(string FrCurrency, string ToCurrency);
        public abstract DataTable GetGlobalFilter(Int32 usrId, Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetHomeTabs(Int32 UsrId, Int32 CompanyId, Int32 ProjectId, byte SystemId);
        public abstract DataTable GetIn(Int32 reportId, string procedureName, int TotalCnt, string RequiredValid, bool bAll, string keyId, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetIn(Int32 reportId, string procedureName, bool bAddNew, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetInfoByCol(Int32 ScreenId, string ColumnName, string dbConnectionString, string dbPassword);
        public abstract string GetLabel(Int16 CultureId, string LabelCat, string LabelKey, string CompanyId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetLabels(Int16 CultureId, string LabelCat, string CompanyId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetLang(Int16 CultureId);
        public abstract DataTable GetLastCriteria(Int32 screenId, Int32 reportId, Int32 usrId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetLastPageInfo(Int32 screenId, Int32 usrId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetLis(Int32 screenId, string procedureName, bool bAddNew, string useGlobalFilter, int topN, string dbConnectionString, string dbPassword, Int32 screenFilterId, string key, string filterTxt, DataView dvCri, UsrImpr ui, UsrCurr uc, DataSet ds);
        public abstract string GetMaintMsg();
        public abstract DataTable GetMsg(int MsgId, Int16 CultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetMstById(string procedureName, string keyId1, string dbConnectionString, string dbPassword);
        public abstract DataTable GetMstById(string procedureName, string keyId1, string keyId2, string dbConnectionString, string dbPassword);
        public abstract DataTable GetPrinterList(string UsrGroups, string Members);
        public abstract DataTable GetReportCriHlp(Int32 reportId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetReportHlp(Int32 reportId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetReportItem(Int32 ReportId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetReportSct();
        public abstract DataTable GetRptDt(Int32 reportId, string procedureName, UsrImpr ui, UsrCurr uc, DataSet ds, DataView dvCri, string dbConnectionString, string dbPassword, bool bUpd, bool bXls, bool bVal);
        public abstract string GetRptPwd(string pwd);
        public abstract string GetSchemaScrImp(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract string GetSchemaWizImp(Int32 wizardId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScrCriteria(string screenId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenCriHlp(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenFilter(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenHlp(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenIn(string screenId, string procedureName, int TotalCnt, string RequiredValid, int topN, string FilterTxt, bool bAll, string keyId, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenLabel(Int32 ScreenId, Int16 CultureId, UsrImpr ui, UsrCurr uc, string dbConnectionString, string dbPassword);
        public abstract DataTable GetScreenTab(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract string GetScrImpTmpl(Int32 screenId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract string GetWizImpTmpl(Int32 wizardId, Int16 cultureId, string dbConnectionString, string dbPassword);
        public abstract Dictionary<string, List<string>> HasOutstandRegen(string ns, string dbConnectionString, string dbPassword);
        public abstract List<string> HasOutstandReleaseContent(string ns, string dbConnectionString, string dbPassword);
        public abstract int ImportRows(Int32 wizardId, string procedureName, bool bOverwrite, Int32 usrId, DataSet ds, int iStart, string fileName, string dbConnectionString, string dbPassword, CurrPrj CPrj, CurrSrc CSrc, bool noTrans);
        public abstract void IniLastCriteria(Int32 screenId, Int32 reportId, Int32 usrId, string dbConnectionString, string dbPassword);
        public abstract bool IsMDesignDb(string TblName);
        public abstract bool IsRegenNeeded(string ProgramName, Int32 ScreenId, Int32 ReportId, Int32 WizardId, string dbConnectionString, string dbPassword);
        public abstract bool IsValidOvride(Credential cr, Int32 usrId);
        public abstract void LogUsage(Int32 UsrId, string UsageNote, string EntityTitle, Int32 ScreenId, Int32 ReportId, Int32 WizardId, string Miscellaneous, string dbConnectionString, string dbPassword);
        public abstract void MkGetScreenIn(string screenId, string screenCriId, string procedureName, string appDatabase, string sysDatabase, string multiDesignDb, string dbConnectionString, string dbPassword, bool reGen);
        public abstract void MkWfStatus(string ScreenObjId, string MasterTable, string appDatabase, string sysDatabase, string dbConnectionString, string dbPassword);
        public abstract DataTable RunWrRule(int screenId, string procedureName, string dbConnectionString, string dbPassword, string parameterXML, UsrImpr ui, UsrCurr uc, bool noTrans);
        public abstract string SetCult(int UsrId, Int16 CultureId);
        public abstract void UpdCronJob(int jobId, DateTime? lastRun, DateTime? nextRun, string dbConnectionString, string dbPassword);
        public abstract void UpdCronJobStatus(int jobId, string Error, string dbConnectionString, string dbPassword);
        public abstract bool UpdData(Int32 ScreenId, bool bDeferError, LoginUsr LUser, UsrImpr LImpr, UsrCurr LCurr, DataSet ds, string dbConnectionString, string dbPassword, CurrPrj CPrj, CurrSrc CSrc, bool noTrans = false);
        public abstract void UpdDbDoc(string DocId, string TblName, string DocName, string MimeType, long DocSize, byte[] dc, string dbConnectionString, string dbPassword, LoginUsr lu);
        public abstract void UpdDbImg(string DocId, string TblName, string KeyName, string ColName, byte[] dc, string dbConnectionString, string dbPassword);
        public abstract string UpdDshFld(string PublicAccess, string DshFldId, string DshFldName, Int32 usrId, string dbConnectionString, string dbPassword);
        public abstract void UpdFxRate(string FrCurrency, string ToCurrency, string ToFxRate);
        public abstract void UpdLastCriteria(Int32 screenId, Int32 reportId, Int32 usrId, Int32 criId, string lastCriteria, string dbConnectionString, string dbPassword);
        public abstract void UpdLastPageInfo(Int32 screenId, Int32 usrId, string lastPageInfo, string dbConnectionString, string dbPassword);
        public abstract bool UpdRptDt(Int32 reportId, string procedureName, Int32 usrId, DataSet ds, DataView dvCri, string dbConnectionString, string dbPassword);
        public abstract void UpdScrCriteria(string screenId, string programName, DataView dvCri, Int32 usrId, bool isCriVisible, DataSet ds, string dbConnectionString, string dbPassword);
    }
}