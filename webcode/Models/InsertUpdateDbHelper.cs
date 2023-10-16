using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
  public class InsertUpdateDbHelper
  {
    Repository.SqlHelper SqlCon = new Repository.SqlHelper();
    public async Task<DataTable> UserAuthentication(UserCredentialsModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@loginid", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Username;

      sqlparam[1] = new SqlParameter("@Password", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Password;

      sqlparam[2] = new SqlParameter("@ipAddress", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.IPaddress;

      dt = SqlCon.RunSpReturnDataTable("usp_Login_Member", sqlparam);
      return dt;
    }

    public DataTable UserOTPAuthentication(UserCredentialsModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[2];

      sqlparam[0] = new SqlParameter("@UserId", SqlDbType.Int);
      sqlparam[0].Value = obj.UserId;

      sqlparam[1] = new SqlParameter("@Otpcode", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Otpcode;

      dt = SqlCon.RunSpReturnDataTable("usp_OtpValidation", sqlparam);
      return dt;
    }

    public int MemberRegistration(MemberRegistrationModel obj)
    {

      SqlParameter[] sqlparam = new SqlParameter[7];

      sqlparam[0] = new SqlParameter("@fName", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Firstname;

      sqlparam[1] = new SqlParameter("@lName", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Lastname;

      sqlparam[2] = new SqlParameter("@mobile", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.Mobileno;

      sqlparam[3] = new SqlParameter("@email", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.Emailaddress;

      sqlparam[4] = new SqlParameter("@IntroLoginId", SqlDbType.NVarChar);
      sqlparam[4].Value = obj.Sponsorcode;

      sqlparam[5] = new SqlParameter("@introRegNo", SqlDbType.NVarChar);
      sqlparam[5].Value = obj.SponsorId;

      //sqlparam[6] = new SqlParameter("@Country", SqlDbType.Int);
      //sqlparam[6].Value = obj.Countryid;

      sqlparam[6] = new SqlParameter("@intResult", SqlDbType.Int);
      sqlparam[6].Direction = ParameterDirection.Output;

      int res = SqlCon.RunSpReturn("[sp_InsertNetworkB]", sqlparam);
      res = Convert.ToInt32(sqlparam[6].Value);
      return res;
    }

    public DataTable MemberDetails(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[2];

      sqlparam[0] = new SqlParameter("@LoginId", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.LoginId;

      sqlparam[1] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[1].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberDetails]", sqlparam);
      return dt;
    }

    public DataTable MemberDetailsDashboardHeader(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberDetailsDashboardHeader]", sqlparam);
      return dt;
    }

    public int MemberActivation(MemberActivationModel obj)
    {

      SqlParameter[] sqlparam = new SqlParameter[7];

      sqlparam[0] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@downlineRegno", SqlDbType.Int);
      sqlparam[1].Value = obj.childRegno;

      sqlparam[2] = new SqlParameter("@paymentmode", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.PaymentMode;

      sqlparam[3] = new SqlParameter("@buyingType", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.BuyingType;

      sqlparam[4] = new SqlParameter("@kitid", SqlDbType.Int);
      sqlparam[4].Value = obj.kitId;

      sqlparam[5] = new SqlParameter("@Amount", SqlDbType.Decimal);
      sqlparam[5].Value = obj.Amount;

      sqlparam[6] = new SqlParameter("@intResult", SqlDbType.Int);
      sqlparam[6].Direction = ParameterDirection.Output;

      int res = SqlCon.RunSpReturn("[sp_Recharge]", sqlparam);
      res = Convert.ToInt32(sqlparam[6].Value);
      return res;
    }

    public DataTable MemberWalletRecharge(MemberWalletRechargeModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[12];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@trtype", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.TransactionType;

      sqlparam[2] = new SqlParameter("@trname", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.TransactionName;

      sqlparam[3] = new SqlParameter("@dhanuamount", SqlDbType.Decimal);
      sqlparam[3].Value = obj.dhanuamount;

      sqlparam[4] = new SqlParameter("@usdtamount", SqlDbType.Decimal);
      sqlparam[4].Value = obj.usdtamount;

      sqlparam[5] = new SqlParameter("@trstatus", SqlDbType.Int);
      sqlparam[5].Value = obj.TransactionStatus;

      sqlparam[6] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[6].Value = obj.Remarks;

      sqlparam[7] = new SqlParameter("@trreferenceno", SqlDbType.NVarChar);
      sqlparam[7].Value = obj.TransactionReference;

      sqlparam[8] = new SqlParameter("@receiptUrlDhanu", SqlDbType.NVarChar);
      sqlparam[8].Value = obj.receiptUrlDhanu;

      sqlparam[9] = new SqlParameter("@receiptUrlUsdt", SqlDbType.NVarChar);
      sqlparam[9].Value = obj.receiptUrlUsdt;

      sqlparam[10] = new SqlParameter("@tpusdtamount", SqlDbType.Decimal);
      sqlparam[10].Value = obj.tpusdtamount;

      sqlparam[11] = new SqlParameter("@receiptUrltpUsdt", SqlDbType.NVarChar);
      sqlparam[11].Value = obj.receiptUrltpUsdt;

      dt = SqlCon.RunSpReturnDataTable("[usp_WalletFundRecharge]", sqlparam);
      return dt;
    }

    public DataTable UpdateCoinRate(int coin, decimal amount)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[2];

      sqlparam[0] = new SqlParameter("@WalletId", SqlDbType.Int);
      sqlparam[0].Value = coin;

      sqlparam[1] = new SqlParameter("@CoinINR", SqlDbType.Money);
      sqlparam[1].Value = amount;

      dt = SqlCon.RunSpReturnDataTable("[usp_UpdateCoinRate]", sqlparam);
      return dt;
    }

    public DataTable MemberWalletTransfer(MemberWalletRechargeModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[6];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@childregno", SqlDbType.Int);
      sqlparam[1].Value = obj.childregno;

      sqlparam[2] = new SqlParameter("@usdtamount", SqlDbType.Decimal);
      sqlparam[2].Value = obj.usdtamount;

      sqlparam[3] = new SqlParameter("@dhanuamount", SqlDbType.Decimal);
      sqlparam[3].Value = obj.dhanuamount;

      sqlparam[4] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[4].Value = obj.Remarks;

      sqlparam[5] = new SqlParameter("@tpusdtamount", SqlDbType.Decimal);
      sqlparam[5].Value = obj.tpusdtamount;

      dt = SqlCon.RunSpReturnDataTable("[usp_wallettransfer]", sqlparam);
      return dt;
    }

    public DataTable GetMasters(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mastername", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Mastername;

      dt = SqlCon.RunSpReturnDataTable("[usp_GetMasters]", sqlparam);
      return dt;
    }

    public DataTable GetWalletBalance(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_GetWalletBalance]", sqlparam);
      return dt;
    }

    public DataTable GetWalletBalanceFund(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_GetWalletBalanceDhanuFund]", sqlparam);
      return dt;
    }

    public DataTable GetMemberReports(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[7];

      sqlparam[0] = new SqlParameter("@datefrom", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.dateFrom;

      sqlparam[1] = new SqlParameter("@dateupto", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.dateUpto;

      sqlparam[2] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[2].Value = obj.regno;

      sqlparam[3] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[3].Value = obj.WalletId;

      sqlparam[4] = new SqlParameter("@mastername", SqlDbType.NVarChar);
      sqlparam[4].Value = obj.Mastername;

      sqlparam[5] = new SqlParameter("@levelId", SqlDbType.Int);
      sqlparam[5].Value = obj.LevelId;

      sqlparam[6] = new SqlParameter("@rankId", SqlDbType.Int);
      sqlparam[6].Value = obj.RankId;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberReports]", sqlparam);

      return dt;
    }

    public DataTable GetMemberDashboard(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberDashboard]", sqlparam);
      return dt;
    }

    public DataTable GetMemberMatrixTree(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_MatrixTreeView]", sqlparam);
      return dt;
    }

    public DataTable MemberChangePassword(int regno, string oldpassword, string newpassword)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = regno;

      sqlparam[1] = new SqlParameter("@oldpassword", SqlDbType.NVarChar);
      sqlparam[1].Value = oldpassword;

      sqlparam[2] = new SqlParameter("@newpassword", SqlDbType.NVarChar);
      sqlparam[2].Value = newpassword;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberChangePassword]", sqlparam);
      return dt;
    }

    public DataTable MemberProfile(MemberProfileModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[15];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@Firstname", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Firstname;

      sqlparam[2] = new SqlParameter("@Lastname", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.Lastname;

      sqlparam[3] = new SqlParameter("@Dateofbirth", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.Dateofbirth;

      sqlparam[4] = new SqlParameter("@Gender", SqlDbType.Bit);
      sqlparam[4].Value = obj.Gender;

      sqlparam[5] = new SqlParameter("@Nomineename", SqlDbType.NVarChar);
      sqlparam[5].Value = obj.Nomineename;

      sqlparam[6] = new SqlParameter("@Nomineerelation", SqlDbType.NVarChar);
      sqlparam[6].Value = obj.Nomineerelation;

      sqlparam[7] = new SqlParameter("@Address", SqlDbType.NVarChar);
      sqlparam[7].Value = obj.Address;

      sqlparam[8] = new SqlParameter("@Countryid", SqlDbType.Int);
      sqlparam[8].Value = obj.Countryid;

      sqlparam[9] = new SqlParameter("@Statename", SqlDbType.NVarChar);
      sqlparam[9].Value = obj.Statename;

      sqlparam[10] = new SqlParameter("@Cityname", SqlDbType.NVarChar);
      sqlparam[10].Value = obj.Cityname;

      sqlparam[11] = new SqlParameter("@Pincode", SqlDbType.NVarChar);
      sqlparam[11].Value = obj.Pincode;

      sqlparam[12] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[12].Value = obj.processname;

      sqlparam[13] = new SqlParameter("@Mobile", SqlDbType.NVarChar);
      sqlparam[13].Value = obj.Mobile;

      sqlparam[14] = new SqlParameter("@Email", SqlDbType.NVarChar);
      sqlparam[14].Value = obj.Email;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberProfile]", sqlparam);
      return dt;
    }

    public double GetCoinRate(int walletid)
    {
      SqlParameter[] sqlparam = new SqlParameter[2];

      sqlparam[0] = new SqlParameter("@WalletId", SqlDbType.Int);
      sqlparam[0].Value = walletid;

      sqlparam[1] = new SqlParameter("@CoinRate", SqlDbType.Decimal);
      sqlparam[1].Direction = ParameterDirection.Output;

      object res = SqlCon.RunSpReturnScalar("usp_CurrentCoinRate", sqlparam);
      double coinrate = Convert.ToDouble(sqlparam[1].Value);
      return coinrate;
    }

    public DataSet GetWithdrawalEligibility(int regno)
    {
      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.BigInt);
      sqlparam[0].Value = regno;

      DataSet dsres = SqlCon.RunSpReturnDs("usp_WithdrawReport", sqlparam);

      return dsres;
    }

    public DataTable GetDhanuWithdrawBalance(long regno)
    {
      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.BigInt);
      sqlparam[0].Value = regno;

      DataTable dtres = SqlCon.RunSpReturnDataTable("usp_GetDhanuWithdrawBalance", sqlparam);

      return dtres;
    }

    public DataTable GetUSDTWithdrawBalance(long regno)
    {
      SqlParameter[] sqlparam = new SqlParameter[1];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.BigInt);
      sqlparam[0].Value = regno;

      DataTable dtres = SqlCon.RunSpReturnDataTable("usp_GetUSDTWithdrawBalance", sqlparam);

      return dtres;
    }

    public DataTable MemberExchangeAddress(MemberExchangeAddressRequestParamModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[6];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.BigInt);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[1].Value = obj.walletid;

      sqlparam[2] = new SqlParameter("@exchangeid", SqlDbType.Int);
      sqlparam[2].Value = obj.exchangeid;

      sqlparam[3] = new SqlParameter("@e_address", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.e_address;

      sqlparam[4] = new SqlParameter("@EAddressId", SqlDbType.Int);
      sqlparam[4].Value = obj.EAddressId;

      sqlparam[5] = new SqlParameter("@process_name", SqlDbType.NVarChar);
      sqlparam[5].Value = obj.process_name;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageMemberExchangeAddress]", sqlparam);
      return dt;
    }

    public DataTable MemberWithdrawal(MemberWithdrawalRequestModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[10];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.BigInt);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[1].Value = obj.walletid;

      sqlparam[2] = new SqlParameter("@exchangeid", SqlDbType.Int);
      sqlparam[2].Value = obj.exchangeid;

      sqlparam[3] = new SqlParameter("@e_address", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.e_address;

      sqlparam[4] = new SqlParameter("@EAddressId", SqlDbType.Int);
      sqlparam[4].Value = obj.EAddressId;

      sqlparam[5] = new SqlParameter("@process_name", SqlDbType.NVarChar);
      sqlparam[5].Value = obj.process_name;

      sqlparam[6] = new SqlParameter("@status", SqlDbType.Int);
      sqlparam[6].Value = obj.status;

      sqlparam[7] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[7].Value = obj.remarks;

      sqlparam[8] = new SqlParameter("@RequestId", SqlDbType.Int);
      sqlparam[8].Value = obj.RequestId;

      sqlparam[9] = new SqlParameter("@coin", SqlDbType.Decimal);
      sqlparam[9].Value = obj.coin;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageWithdrawal]", sqlparam);
      return dt;
    }

    public DataTable GetCountryList()
    {
      DataSet ds = SqlCon.RunSqlReturnDs("select cid, countryname from country where cactive =1 order by countryname");
      DataTable dt = ds.Tables[0];
      return dt;
    }

    public DataTable GetExchangeList()
    {
      DataSet ds = SqlCon.RunSqlReturnDs("select ExchangeId, ExchangeName from ExchangeMaster where ActiveStatus =1 order by ExchangeName");
      DataTable dt = ds.Tables[0];
      return dt;
    }

    public DataTable GetRankList()
    {
      DataSet ds = SqlCon.RunSqlReturnDs("select rlevel =0, designation ='Investor' union select rlevel, designation from Reward_Master where active =1 order by rlevel");
      DataTable dt = ds.Tables[0];
      return dt;
    }

    public DataTable GetDhanuCoinReportFromDhanuNetwork(long mregno)
    {
      Repository.DhanuSqlHelper DhanuSqlCon = new Repository.DhanuSqlHelper();
      DataSet ds = DhanuSqlCon.RunSqlReturnDs("select TransactionDate = Convert(varchar(20), TransDate, 100), TransactionType =(case crdb when 'C' then 'Credit' when 'D' then 'Debit' end), Transtype =(case isnull(ma.uregno, 0) when 0 then ma.transType else (ma.transType+' - '+mm.LoginID) end) , DhanuInr, DhanuCredit, DhanuDebit from Member_Account ma left join Member_Master mm on ma.uregno =mm.regno where ma.regno =" + mregno.ToString() + " and trStatus =1 order by TransDate");
      DataTable dt = ds.Tables[0];
      return dt;
    }

    public decimal GetDhanuMinWithdrawalAmount()
    {
      decimal amount = Convert.ToDecimal(SqlCon.RunSqlReturnScalar("select LIMITS from Settings where caption ='DhanuWithdrawalMinBalance' and Active =1 ").ToString());
      return amount;
    }

    public decimal GetUSDTMinWithdrawalAmount()
    {
      decimal amount = Convert.ToDecimal(SqlCon.RunSqlReturnScalar("select LIMITS from Settings where caption ='USDTWithdrawalMinBalance' and Active =1 ").ToString());
      return amount;
    }

    public DataTable ManageTradingPoolTree(TradingPoolModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[6];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.Regno;

      sqlparam[1] = new SqlParameter("@introregno", SqlDbType.Int);
      sqlparam[1].Value = obj.IntroRegno;

      sqlparam[2] = new SqlParameter("@requestid", SqlDbType.Int);
      sqlparam[2].Value = obj.RequestId;

      sqlparam[3] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.ProcessName;

      sqlparam[4] = new SqlParameter("@status", SqlDbType.Int);
      sqlparam[4].Value = obj.Status;

      sqlparam[5] = new SqlParameter("@remark", SqlDbType.NVarChar);
      sqlparam[5].Value = obj.Remark;

      dt = SqlCon.RunSpReturnDataTable("[usp_manage_member_tradingpool_request]", sqlparam);
      return dt;
    }

    public DataTable ManageSecurityPin(SecurityPinModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[4];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.Regno;

      sqlparam[1] = new SqlParameter("@securitypin", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.SecurityPin;

      sqlparam[2] = new SqlParameter("@oldsecuritypin", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.OldSecurityPin;

      sqlparam[3] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.ProcessName;

      dt = SqlCon.RunSpReturnDataTable("[usp_MemberSecurityPin]", sqlparam);
      return dt;
    }

    public DataTable LuckyDrawRegistration(LuckyDrawModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[5];

      sqlparam[0] = new SqlParameter("@fullname", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Fullname;

      sqlparam[1] = new SqlParameter("@email", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Email;

      sqlparam[2] = new SqlParameter("@mobile", SqlDbType.NVarChar);
      sqlparam[2].Value = obj.Mobile;

      sqlparam[3] = new SqlParameter("@loginid", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.LoginId;

      sqlparam[4] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[4].Value = obj.Regno;

      dt = SqlCon.RunSpReturnDataTable("[usp_LuckdrawRegister]", sqlparam);
      return dt;
    }

    public DataTable ManageLuckyDraw(LuckyDrawModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[2];

      sqlparam[0] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Processname;

      sqlparam[1] = new SqlParameter("@giftid", SqlDbType.Int);
      sqlparam[1].Value = obj.GiftId;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageLuckydraw]", sqlparam);
      return dt;
    }

    public DataTable MemberUsdtTransfer(MemberWalletRechargeModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[4];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = obj.regno;

      sqlparam[1] = new SqlParameter("@childregno", SqlDbType.Int);
      sqlparam[1].Value = obj.childregno;

      sqlparam[2] = new SqlParameter("@usdtcoin", SqlDbType.Decimal);
      sqlparam[2].Value = obj.usdtamount;

      sqlparam[3] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[3].Value = obj.Remarks;

      dt = SqlCon.RunSpReturnDataTable("[usp_usdttransferFromDhanuToTradingPool]", sqlparam);
      return dt;
    }

    #region Admin Procedures

    public DataTable UserAuthenticationAdmin(UserCredentialsModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@username", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.Username;

      sqlparam[1] = new SqlParameter("@Password", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.Password;

      dt = SqlCon.RunSpReturnDataTable("usp_Login_Admin", sqlparam);
      return dt;
    }

    public DataTable GetAdminReports(RequestParameterModel obj)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[5];

      sqlparam[0] = new SqlParameter("@datefrom", SqlDbType.NVarChar);
      sqlparam[0].Value = obj.dateFrom;

      sqlparam[1] = new SqlParameter("@dateupto", SqlDbType.NVarChar);
      sqlparam[1].Value = obj.dateUpto;

      sqlparam[2] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[2].Value = obj.regno;

      sqlparam[3] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[3].Value = obj.WalletId;

      sqlparam[4] = new SqlParameter("@mastername", SqlDbType.NVarChar);
      sqlparam[4].Value = obj.Mastername;

      dt = SqlCon.RunSpReturnDataTable("[usp_adminReports]", sqlparam);

      return dt;
    }

    public DataTable ManageOtp(int Regno, string Processname, string OTP)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[0].Value = Regno;

      sqlparam[1] = new SqlParameter("@otp", SqlDbType.NVarChar);
      sqlparam[1].Value = OTP;

      sqlparam[2] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[2].Value = Processname;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageEmailOTP]", sqlparam);

      return dt;
    }

    public DataTable ManageOtpMobile(int Regno, string Processname, string OTP)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@regno", SqlDbType.Int);
      sqlparam[0].Value = Regno;

      sqlparam[1] = new SqlParameter("@otp", SqlDbType.NVarChar);
      sqlparam[1].Value = OTP;

      sqlparam[2] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[2].Value = Processname;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageMobileOTP]", sqlparam);

      return dt;
    }

    public DataTable ManageDhanuxDetails(int Regno, string Processname, string UID, int kycLevel)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[4];

      sqlparam[0] = new SqlParameter("@mregno", SqlDbType.Int);
      sqlparam[0].Value = Regno;

      sqlparam[1] = new SqlParameter("@uid", SqlDbType.NVarChar);
      sqlparam[1].Value = UID;

      sqlparam[2] = new SqlParameter("@kycLevel", SqlDbType.Int);
      sqlparam[2].Value = kycLevel;

      sqlparam[3] = new SqlParameter("@processname", SqlDbType.NVarChar);
      sqlparam[3].Value = Processname;

      dt = SqlCon.RunSpReturnDataTable("[usp_ManageDhanuxDetails]", sqlparam);

      return dt;
    }

    public DataTable GetLiveCoinRate()
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      dt = SqlCon.RunSpReturnDataTable("[usp_GetLiveCoinRate]", sqlparam);

      return dt;
    }

    public DataTable AddFundInWallet(string loginid, decimal amount, int walletid, string Remark)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[4];

      sqlparam[0] = new SqlParameter("@loginid", SqlDbType.NVarChar);
      sqlparam[0].Value = loginid;

      sqlparam[1] = new SqlParameter("@amount", SqlDbType.Decimal);
      sqlparam[1].Value = amount;

      sqlparam[2] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[2].Value = walletid;

      sqlparam[3] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[3].Value = Remark;

      dt = SqlCon.RunSpReturnDataTable("[usp_adminDepositFund]", sqlparam);

      return dt;
    }

    public DataTable DeductFundFromWallet(string loginid, decimal amount, int walletid, string Remark)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[4];

      sqlparam[0] = new SqlParameter("@loginid", SqlDbType.NVarChar);
      sqlparam[0].Value = loginid;

      sqlparam[1] = new SqlParameter("@amount", SqlDbType.Decimal);
      sqlparam[1].Value = amount;

      sqlparam[2] = new SqlParameter("@walletid", SqlDbType.Int);
      sqlparam[2].Value = walletid;

      sqlparam[3] = new SqlParameter("@remarks", SqlDbType.NVarChar);
      sqlparam[3].Value = Remark;

      dt = SqlCon.RunSpReturnDataTable("[usp_adminDeductFund]", sqlparam);

      return dt;
    }

    public DataTable BulkEmail(string process, int id, int status)
    {
      DataTable dt = null;

      SqlParameter[] sqlparam = new SqlParameter[3];

      sqlparam[0] = new SqlParameter("@process", SqlDbType.NVarChar);
      sqlparam[0].Value = process;

      sqlparam[1] = new SqlParameter("@Id", SqlDbType.Int);
      sqlparam[1].Value = id;

      sqlparam[2] = new SqlParameter("@Status", SqlDbType.Int);
      sqlparam[2].Value = status;

      dt = SqlCon.RunSpReturnDataTable("[Usp_EmailData]", sqlparam);

      return dt;
    }
    #endregion

  }
}
