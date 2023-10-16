using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
  public class InsertUpdateFn
  {
    InsertUpdateDbHelper dbIU = new InsertUpdateDbHelper();

    public string MatrixTreeContent = "";
    public async Task<int> UserAuthentication(UserCredentialsModel obj)
    {
      int UserId = 0;
      DataTable dt = await dbIU.UserAuthentication(obj);
      if (dt != null)
      {
        if (dt.Rows.Count > 0)
        {
          UserId = Convert.ToInt32(dt.Rows[0]["regno"].ToString());
        }
      }


      return UserId;
    }

    public async Task<int> MemberRegistration(MemberRegistrationModel obj)
    {
      int res = await Task.Run(() => dbIU.MemberRegistration(obj));
      return res;
    }

    public DataTable MemberDetails(RequestParameterModel obj)
    {
      DataTable dt = dbIU.MemberDetails(obj);
      return dt;
    }

    public async Task<DataTable> MemberDetailsAsync(RequestParameterModel obj)
    {
      DataTable dt = await Task.Run(() => dbIU.MemberDetails(obj));
      return dt;
    }

    public async Task<DataTable> MemberDetailsDashboardHeader(RequestParameterModel obj)
    {
      DataTable dt = await Task.Run(() => dbIU.MemberDetailsDashboardHeader(obj));
      return dt;
    }

    public int MemberActivation(MemberActivationModel obj)
    {
      int res = dbIU.MemberActivation(obj);
      return res;
    }

    public DataTable MemberWalletRecharge(MemberWalletRechargeModel obj)
    {
      DataTable dt = dbIU.MemberWalletRecharge(obj);
      return dt;
    }

    public DataTable UpdateCoinRate(int coin, decimal amount)
    {
      DataTable dt = dbIU.UpdateCoinRate(coin, amount);
      return dt;
    }

    public DataTable MemberWalletTransfer(MemberWalletRechargeModel obj)
    {
      DataTable dt = dbIU.MemberWalletTransfer(obj);
      return dt;
    }

    public DataTable GetMasters(RequestParameterModel obj)
    {
      DataTable dt = dbIU.GetMasters(obj);
      return dt;
    }

    public DataTable GetWalletBalance(RequestParameterModel obj)
    {
      DataTable balance = dbIU.GetWalletBalance(obj);
      return balance;
    }
    public DataTable GetWalletBalanceFund(RequestParameterModel obj)
    {
      DataTable balance = dbIU.GetWalletBalanceFund(obj);
      return balance;
    }

    public async Task<DataTable> GetMemberReports(RequestParameterModel obj)
    {
      DataTable dtReport = await Task.Run(() => dbIU.GetMemberReports(obj));
      return dtReport;
    }

    public async Task<DataTable> GetMemberDashboard(RequestParameterModel obj)
    {
      DataTable dt = await Task.Run(() => dbIU.GetMemberDashboard(obj));
      return dt;
    }

    public DataTable GetMemberMatrixTree(RequestParameterModel obj)
    {
      DataTable dt = dbIU.GetMemberMatrixTree(obj);
      return dt;
    }

    public string GetMemberMatrixTreeContent(int regno)
    {
      string treecode = "";

      RequestParameterModel obj = new RequestParameterModel();
      obj.regno = regno;
      DataTable dt = GetMemberMatrixTree(obj);

      if (dt.Rows.Count > 0)
      {
        foreach (DataRow dr in dt.Rows)
        {
          string classname = "";
          if (dr["haschild"].ToString() != "0")
          {
            classname = "class ='has-community'";
          }
          treecode += "<ul><li " + classname + " ><span>" + dr["userid"].ToString() + " - " + dr["fullname"].ToString() + "</span>";

          //MatrixTreeContent += treecode;

          if (dr["haschild"].ToString() != "0")
            treecode += GetMemberMatrixTreeContent(Convert.ToInt32(dr["regno"].ToString()));

          treecode += "</li></ul>";
          //MatrixTreeContent += treecode;
        }
      }
      return treecode;
    }

    public DataTable MemberChangePassword(int regno, string oldpassword, string newpassword)
    {
      DataTable dt = dbIU.MemberChangePassword(regno, oldpassword, newpassword);
      return dt;
    }

    public DataTable MemberProfile(MemberProfileModel obj)
    {
      DataTable dt = dbIU.MemberProfile(obj);
      return dt;
    }

    public double GetCoinRate(int walletid)
    {
      double _coinrate = dbIU.GetCoinRate(walletid);
      return _coinrate;
    }

    public DataTable GetCountryList()
    {
      DataTable dt = dbIU.GetCountryList();
      return dt;
    }

    public DataTable GetRankList()
    {
      DataTable dt = dbIU.GetRankList();
      return dt;
    }

    public async Task<DataSet> GetWithdrawalEligibility(int regno)
    {
      DataSet ds = await Task.Run(() => dbIU.GetWithdrawalEligibility(regno));
      return ds;
    }

    public DataTable MemberExchangeAddress(MemberExchangeAddressRequestParamModel obj)
    {
      DataTable dt = dbIU.MemberExchangeAddress(obj);
      return dt;
    }

    public DataTable GetDhanuWithdrawBalance(long mregno)
    {
      DataTable dt = dbIU.GetDhanuWithdrawBalance(mregno);
      return dt;
    }

    public DataTable GetUSDTWithdrawBalance(long mregno)
    {
      DataTable dt = dbIU.GetUSDTWithdrawBalance(mregno);
      return dt;
    }

    public DataTable MemberWithdrawal(MemberWithdrawalRequestModel obj)
    {
      DataTable dt = dbIU.MemberWithdrawal(obj);
      return dt;
    }

    public async Task<DataTable> MemberWithdrawalAsync(MemberWithdrawalRequestModel obj)
    {
      DataTable dt = await Task.Run(() => dbIU.MemberWithdrawal(obj));
      return dt;
    }

    public decimal GetDhanuMinWithdrawalAmount()
    {
      decimal amount = dbIU.GetDhanuMinWithdrawalAmount();
      return amount;
    }

    public decimal GetUSDTMinWithdrawalAmount()
    {
      decimal amount = dbIU.GetUSDTMinWithdrawalAmount();
      return amount;
    }

    public DataTable GetDhanuCoinReportFromDhanuNetwork(long mregno)
    {
      DataTable dt = dbIU.GetDhanuCoinReportFromDhanuNetwork(mregno);
      return dt;
    }

    public DataTable ManageTradingPoolTree(TradingPoolModel obj)
    {
      DataTable dt = dbIU.ManageTradingPoolTree(obj);
      return dt;
    }

    public DataTable ManageSecurityPin(SecurityPinModel obj)
    {
      DataTable dt = dbIU.ManageSecurityPin(obj);
      return dt;
    }

    public DataTable LuckyDrawRegistration(LuckyDrawModel obj)
    {
      DataTable dt = dbIU.LuckyDrawRegistration(obj);
      return dt;
    }

    public DataTable ManageLuckyDraw(LuckyDrawModel obj)
    {
      DataTable dt = dbIU.ManageLuckyDraw(obj);
      return dt;
    }

    public DataTable MemberUsdtTransfer(MemberWalletRechargeModel obj)
    {
      DataTable dt = dbIU.MemberUsdtTransfer(obj);
      return dt;
    }

    #region Admin Functions

    public int UserAuthenticationAdmin(UserCredentialsModel obj)
    {
      int UserId = 0;
      DataTable dt = dbIU.UserAuthenticationAdmin(obj);
      if (dt != null)
      {
        if (dt.Rows.Count > 0)
        {
          UserId = Convert.ToInt32(dt.Rows[0]["UserId"].ToString());
        }
      }
      return UserId;
    }

    public DataTable GetAdminReports(RequestParameterModel obj)
    {
      DataTable dtReport = dbIU.GetAdminReports(obj);
      return dtReport;
    }

    public DataTable ManageOtp(int Regno, string Processname, string OTP)
    {
      DataTable dt = dbIU.ManageOtp(Regno, Processname, OTP);
      return dt;
    }

    public DataTable ManageOtpMobile(int Regno, string Processname, string OTP)
    {
      DataTable dt = dbIU.ManageOtpMobile(Regno, Processname, OTP);
      return dt;
    }

    public DataTable GetLiveCoinRate()
    {
      DataTable dt = dbIU.GetLiveCoinRate();
      return dt;
    }

    public DataTable ManageDhanuxDetails(int Regno, string Processname, string UID, int kycLevel)
    {
      DataTable dt = dbIU.ManageDhanuxDetails(Regno, Processname, UID, kycLevel);
      return dt;
    }

    public DataTable AddFundInWallet(string loginid, decimal amount, int walletid, string Remark)
    {
      DataTable dtReport = dbIU.AddFundInWallet(loginid, amount, walletid, Remark);
      return dtReport;
    }

    public DataTable DeductFundFromWallet(string loginid, decimal amount, int walletid, string Remark)
    {
      DataTable dtReport = dbIU.DeductFundFromWallet(loginid, amount, walletid, Remark);
      return dtReport;
    }

    public async Task<DataTable> BulkEmail(string process, int id, int status)
    {
      DataTable dtReport = await Task.Run(() => dbIU.BulkEmail(process, id, status));
      return dtReport;
    }
    #endregion
  }
}
