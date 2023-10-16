using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using webcode.Models;
using webcode.Repository;

namespace webcode.Controllers
{
  public class MemberController : Controller
  {
    InsertUpdateFn fnIU = new InsertUpdateFn();
    public async Task<IActionResult> Index()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Reward_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        DataTable dt2 = await fnIU.GetMemberDashboard(obj);
        ViewData["_dashboard"] = dt2;

        string ReferralLink = ConfigurationManager.AppSetting["ReferralLink"] + "/" + HttpContext.Session.GetString("MaxUsername");
        ViewData["_referralLink"] = ReferralLink;
        /*
        try
        {
            DataTable dtOtp = fnIU.ManageOtp(3, "generate", "");

            string OTP = string.Empty;
            if (dtOtp.Rows.Count > 0)
            {
                OTP = dtOtp.Rows[0]["OTP"].ToString();
            }

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Email", "pankaj_aggarwal@qwertycode.in");
            data.Add("Otp", OTP);
            data.Add("Name", "Test Pankaj");
            data.Add("EmailName", "OTP");
            data.Add("Subject", "Baap Network - OTP");
            string jsondata = JsonConvert.SerializeObject(data);
            ApiUtility oApiUtility = new ApiUtility();
            HttpResponseMessage response = oApiUtility.PostApi("account/SendMailBaapNetwork", jsondata);


        }
        catch (Exception exe)
        {

        }
        */
        return View();
      }
      catch (Exception ex)
      {
        return View();
      }



    }
    public IActionResult Logout()
    {
      try
      {
        HttpContext.Session.Remove("MaxRegno");
        HttpContext.Session.Clear();
        return Redirect("~/login");
      }
      catch (Exception ex)
      {
        return Redirect("~/login");
      }

    }
    public async Task<IActionResult> WalletRecharge()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtCoin = fnIU.GetLiveCoinRate();

        if (dtCoin.Rows.Count > 0)
        {
          double _dhanucointrate = Convert.ToDouble(dtCoin.Rows[0]["DhanuLiveRate"].ToString());
          ViewData["_dhanucoinrate"] = _dhanucointrate.ToString();

          double _usdtcointrate = Convert.ToDouble(dtCoin.Rows[0]["UsdtLiveRate"].ToString());
          ViewData["_usdtcoinrate"] = _usdtcointrate.ToString();

          double _tpusdtcointrate = Convert.ToDouble(dtCoin.Rows[0]["TpUsdtLiveRate"].ToString());
          ViewData["_tpusdtcoinrate"] = _tpusdtcointrate.ToString();

          double _currencyrate = Convert.ToDouble(dtCoin.Rows[0]["InrExchangeRate"].ToString());
          ViewData["_currencyrate"] = _currencyrate.ToString();
        }


        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> WalletRecharge(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string receiptUrlDhanu = "";
        string receiptUrlUsdt = "";
        string receiptUrltpUsdt = "";
        decimal dhanuamount = 0;
        decimal usdtamount = 0;
        decimal tpusdtamount = 0;
        string remark = form["remark"];
        if (!string.IsNullOrEmpty(form["dhanuamount"]))
          dhanuamount = Convert.ToDecimal(form["dhanuamount"]);
        else
          dhanuamount = 0;

        if (!string.IsNullOrEmpty(form["usdtamount"]))
          usdtamount = Convert.ToDecimal(form["usdtamount"]);
        else
          usdtamount = 0;

        if (!string.IsNullOrEmpty(form["tpusdtamount"]))
          tpusdtamount = Convert.ToDecimal(form["tpusdtamount"]);
        else
          tpusdtamount = 0;

        //string submit = form["submit"];
        IFormFile _receiptImgDhanu = form.Files["fileDhanu"];
        IFormFile _receiptImgUsdt = form.Files["fileUsdt"];
        IFormFile _receiptImgtpUsdt = form.Files["filetpUsdt"];

        try
        {
          if (_receiptImgDhanu != null && _receiptImgDhanu.Length > 0)
          {
            //Getting FileName
            var fileName1 = Path.GetFileName(_receiptImgDhanu.FileName);

            //Assigning Unique Filename (Guid)
            var myUniqueFileName1 = Convert.ToString(Guid.NewGuid());

            //Getting file Extension
            var fileExtension1 = Path.GetExtension(fileName1);

            // concatenating  FileName + FileExtension
            var newFileName1 = String.Concat(myUniqueFileName1, fileExtension1);

            //var fileName = Path.GetFileName(_receiptImg.FileName);
            var filePath1 = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\paymentreceipt", newFileName1);

            using (FileStream fs = System.IO.File.Create(filePath1))
            {
              _receiptImgDhanu.CopyTo(fs);
              fs.Flush();
            }
            //using (var fileStream = new FileStream(filePath, FileMode.Create))
            //{
            //    _receiptImg.CopyTo(fileStream);
            //}

            receiptUrlDhanu = "paymentreceipt/" + newFileName1;
          }


          if (_receiptImgUsdt != null && _receiptImgUsdt.Length > 0)
          {
            //Getting FileName
            var fileName2 = Path.GetFileName(_receiptImgUsdt.FileName);

            //Assigning Unique Filename (Guid)
            var myUniqueFileName2 = Convert.ToString(Guid.NewGuid());

            //Getting file Extension
            var fileExtension2 = Path.GetExtension(fileName2);

            // concatenating  FileName + FileExtension
            var newFileName2 = String.Concat(myUniqueFileName2, fileExtension2);

            //var fileName = Path.GetFileName(_receiptImg.FileName);
            var filePath2 = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\paymentreceipt", newFileName2);

            using (FileStream fs = System.IO.File.Create(filePath2))
            {
              _receiptImgUsdt.CopyTo(fs);
              fs.Flush();
            }

            receiptUrlUsdt = "paymentreceipt/" + newFileName2;
          }

          if (_receiptImgtpUsdt != null && _receiptImgtpUsdt.Length > 0)
          {
            //Getting FileName
            var fileName3 = Path.GetFileName(_receiptImgtpUsdt.FileName);

            //Assigning Unique Filename (Guid)
            var myUniqueFileName3 = Convert.ToString(Guid.NewGuid());

            //Getting file Extension
            var fileExtension3 = Path.GetExtension(fileName3);

            // concatenating  FileName + FileExtension
            var newFileName3 = String.Concat(myUniqueFileName3, fileExtension3);

            //var fileName = Path.GetFileName(_receiptImg.FileName);
            var filePath3 = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\paymentreceipt", newFileName3);

            using (FileStream fs = System.IO.File.Create(filePath3))
            {
              _receiptImgtpUsdt.CopyTo(fs);
              fs.Flush();
            }

            receiptUrltpUsdt = "paymentreceipt/" + newFileName3;
          }
        }
        catch (Exception exec) { }

        MemberWalletRechargeModel obj = new MemberWalletRechargeModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.dhanuamount = dhanuamount;
        obj.usdtamount = usdtamount;
        obj.Remarks = remark;
        obj.TransactionType = "C";
        obj.TransactionName = "walletrecharge";
        obj.TransactionStatus = 0;//--For Testing keep value 1 otherwise it will be 0
        obj.receiptUrlDhanu = receiptUrlDhanu;
        obj.receiptUrlUsdt = receiptUrlUsdt;
        obj.tpusdtamount = tpusdtamount;
        obj.receiptUrltpUsdt = receiptUrltpUsdt;

        DataTable dt = fnIU.MemberWalletRecharge(obj);

        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0]["ErrorCode"].ToString() == "0")
          {

            TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
            return Redirect("~/Member/Success");
          }
          else
          {
            ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> WalletTransfer()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtCoin = fnIU.GetLiveCoinRate();

        if (dtCoin.Rows.Count > 0)
        {
          double _dhanucointrate = Convert.ToDouble(dtCoin.Rows[0]["DhanuLiveRate"].ToString());
          ViewData["_dhanucoinrate"] = _dhanucointrate.ToString();

          double _usdtcointrate = Convert.ToDouble(dtCoin.Rows[0]["UsdtLiveRate"].ToString());
          ViewData["_usdtcoinrate"] = _usdtcointrate.ToString();

          double _tpusdtcointrate = Convert.ToDouble(dtCoin.Rows[0]["TpUsdtLiveRate"].ToString());
          ViewData["_tpusdtcoinrate"] = _tpusdtcointrate.ToString();

          double _currencyrate = Convert.ToDouble(dtCoin.Rows[0]["InrExchangeRate"].ToString());
          ViewData["_currencyrate"] = _currencyrate.ToString();
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj);

        //DataTable dtbalanceFund = fnIU.GetWalletBalanceFund(obj);

        decimal _dhanubalance = Convert.ToDecimal(dtbalance.Rows[0]["dhanubalance"].ToString());
        ViewData["_dhanubalance"] = _dhanubalance.ToString();

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["usdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        decimal _tpusdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["tpusdtbalance"].ToString());
        ViewData["_tpusdtbalance"] = _tpusdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> WalletTransfer(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        decimal dhanuamount = 0;
        decimal usdtamount = 0;
        decimal tpusdtamount = 0;
        string remark = form["remark"];
        string childLoginId = form["investorloginid"];

        if (!String.IsNullOrEmpty(form["dhanuamount"]))
        {
          dhanuamount = Convert.ToDecimal(form["dhanuamount"]);
        }

        if (!String.IsNullOrEmpty(form["usdtamount"]))
        {
          usdtamount = Convert.ToDecimal(form["usdtamount"]);
        }

        if (!String.IsNullOrEmpty(form["tpusdtamount"]))
        {
          tpusdtamount = Convert.ToDecimal(form["tpusdtamount"]);
        }

        RequestParameterModel objC = new RequestParameterModel();
        objC.LoginId = childLoginId;

        DataTable dtC = fnIU.MemberDetails(objC);

        int childregno = Convert.ToInt32(dtC.Rows[0]["regno"].ToString());

        MemberWalletRechargeModel obj = new MemberWalletRechargeModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.childregno = childregno;
        obj.dhanuamount = dhanuamount;
        obj.usdtamount = usdtamount;
        obj.tpusdtamount = tpusdtamount;
        obj.Remarks = remark;

        DataTable dt = fnIU.MemberWalletTransfer(obj);

        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0]["ErrorCode"].ToString() == "0")
          {
            TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
            return Redirect("~/Member/Success");
          }
          else
          {
            ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> FundRechargeRequestReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Fund_Recharge_Request_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> MemberInvestment()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        //HttpContext.Session.SetString("MaxRegno", "3");

        RequestParameterModel obj = new RequestParameterModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj);

        decimal _dhanubalance = Convert.ToDecimal(dtbalance.Rows[0]["dhanubalance"].ToString());
        ViewData["_dhanubalance"] = _dhanubalance.ToString();

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["usdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> MemberInvestment(IFormCollection form)
    {
      try
      {

        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }


        int kitId = Convert.ToInt32(form["investmentType"]);
        decimal amount = Convert.ToDecimal(form["amount"]);
        string BuyingType = form["paymenttype"];

        MemberActivationModel obj = new MemberActivationModel();
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.childRegno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.PaymentMode = "wallet";
        obj.BuyingType = BuyingType;
        obj.kitId = 3;
        obj.Amount = amount;

        int res = fnIU.MemberActivation(obj);

        if (res == 1)
        {
          TempData["_SuccessMessage"] = "Amount invested successfully. !!";
          return Redirect("~/Member/Success");
        }
        else if (res == 2)
        {
          ViewData["_ErrorMessage"] = "Investment failed, due to insufficient fund balance. Please try again after recharge. !!";
        }
        else
        {
          ViewData["_ErrorMessage"] = "Investment failed, due to some error. Please try again. !!";
        }

        RequestParameterModel obj2 = new RequestParameterModel();

        obj2.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj2);

        decimal _dhanubalance = Convert.ToDecimal(dtbalance.Rows[0]["dhanubalance"].ToString());
        ViewData["_dhanubalance"] = _dhanubalance.ToString();

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["usdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> MemberInvestmentTradingPool()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        //HttpContext.Session.SetString("MaxRegno", "3");

        RequestParameterModel obj = new RequestParameterModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj);

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["tpusdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> MemberInvestmentTradingPool(IFormCollection form)
    {
      try
      {

        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }


        int kitId = Convert.ToInt32(form["investmentType"]);
        decimal amount = Convert.ToDecimal(form["amount"]);

        MemberActivationModel obj = new MemberActivationModel();
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.childRegno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.PaymentMode = "wallet";
        obj.kitId = kitId;
        obj.Amount = amount;
        obj.BuyingType = "100_USDT";

        int res = fnIU.MemberActivation(obj);

        if (res == 1)
        {
          TempData["_SuccessMessage"] = "Amount invested successfully. !!";
          return Redirect("~/Member/Success");
        }
        else if (res == 2)
        {
          ViewData["_ErrorMessage"] = "Investment failed, due to insufficient fund balance. Please try again after recharge. !!";
        }
        else
        {
          ViewData["_ErrorMessage"] = "Investment failed, due to some error. Please try again. !!";
        }

        RequestParameterModel obj2 = new RequestParameterModel();

        obj2.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj2);

        decimal _dhanubalance = Convert.ToDecimal(dtbalance.Rows[0]["dhanubalance"].ToString());
        ViewData["_dhanubalance"] = _dhanubalance.ToString();

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["usdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> DirectReferralReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;


        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Direct_Referral_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> DirectReferralReport(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;

        string RankId = "0";
        string Startdate = "";
        string Enddate = "";
        string filterInfo = "";
        string RankName = "";
        if (form.Count > 0)
        {
          Startdate = form["HF_Startdate"].ToString();
          Enddate = form["HF_Enddate"].ToString();
          RankId = form["ddlRank"].ToString();
          RankName = form["HF_RankName"].ToString();

          if (Startdate != "" && Enddate != "")
            filterInfo += "<span class='filtered'>" + Startdate + " - " + Enddate + "</span>";

          if (RankName != "")
            filterInfo += "<span class='filtered'>" + RankName + "</span>";

          ViewData["FilterBasedOn"] = filterInfo;
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Direct_Referral_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.dateFrom = Startdate;
        obj.dateUpto = Enddate;
        obj.RankId = Convert.ToInt32(RankId);

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;
      }
      catch { }

      return View();
    }

    public async Task<IActionResult> MatrixTree()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        ViewData["_regno"] = HttpContext.Session.GetString("MaxRegno");
        ViewData["_matrixTreeCode"] = fnIU.GetMemberMatrixTreeContent(Convert.ToInt32(HttpContext.Session.GetString("MaxRegno")));
        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TeamReferralReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Team_Referral_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }
    [HttpPost]
    public async Task<IActionResult> TeamReferralReport(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;

        string LevelId = "0";
        string RankId = "0";
        string Startdate = "";
        string Enddate = "";
        string filterInfo = "";

        if (form.Count > 0)
        {
          Startdate = form["HF_Startdate"].ToString();
          Enddate = form["HF_Enddate"].ToString();
          LevelId = form["levels"].ToString();
          RankId = form["ddlRank"].ToString();
          string LevelName = form["HF_LevelName"].ToString();
          string RankName = form["HF_RankName"].ToString();

          if (Startdate != "" && Enddate != "")
            filterInfo += "<span class='filtered'>" + Startdate + " - " + Enddate + "</span>";

          if (LevelName != "")
            filterInfo += "<span class='filtered'>" + LevelName + "</span>";

          if (RankName != "")
            filterInfo += "<span class='filtered'>" + RankName + "</span>";

          ViewData["FilterBasedOn"] = filterInfo;
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Team_Referral_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.LevelId = Convert.ToInt32(LevelId);
        obj.dateFrom = Startdate;
        obj.dateUpto = Enddate;
        obj.RankId = Convert.ToInt32(RankId);

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;
      }
      catch { }

      return View();
    }

    public async Task<IActionResult> DhanuWalletReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Wallet_Transaction_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.WalletId = 1;

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> UsdtWalletReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Wallet_Transaction_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.WalletId = 2;

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> InvestmentReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Investment_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> InvestmentCryptoDepositReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "crypto_deposit_report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> LevelIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Level_Income_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> RoiIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "ROI_Income_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> BonusIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Bonus_Income_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> RewardReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Reward_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> ChangePassword()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> ChangePassword(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        int _regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        string _oldpass = form["oldpassword"].ToString();
        string _newpass = form["newpassword"].ToString();
        string _confirmpass = form["confirmpassword"].ToString();

        if (_newpass.Trim() != _confirmpass.Trim())
        {
          ViewData["_ErrorMessage"] = "Entered password and confirm password did not match. !!";
          return View();
        }

        DataTable dt = fnIU.MemberChangePassword(_regno, _oldpass, _newpass);

        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
          else
          {
            ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
        }
        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> Profile()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        MemberProfileModel obj = new MemberProfileModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.processname = "view";

        DataTable dt = fnIU.MemberProfile(obj);

        ViewData["_Profiledetails"] = dt;

        DataTable dtCountry = fnIU.GetCountryList();
        ViewData["_country"] = dtCountry;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> Profile(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string firstname = form["firstname"];
        string lastname = form["lastname"];
        string email = form["email"];
        string dob = form["dob"];
        string mobile = form["mobile"];
        string gender = form["gender"];
        string nomineename = form["nomineename"];
        string nomineerelation = form["nomineerelation"];
        string address = form["address"];
        string country = form["country"];
        string statename = form["statename"];
        string cityname = form["cityname"];
        string pincode = form["pincode"];

        MemberProfileModel obj = new MemberProfileModel();

        obj.processname = "Edit";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.Firstname = firstname;
        obj.Lastname = lastname;
        obj.Email = email;
        obj.Dateofbirth = dob;
        obj.Mobile = mobile;
        obj.Nomineename = nomineename;
        obj.Nomineerelation = nomineerelation;
        obj.Address = address;
        obj.Countryid = Convert.ToInt32(country);
        obj.Statename = statename;
        obj.Cityname = cityname;
        obj.Pincode = pincode;
        obj.Gender = Convert.ToInt32(gender);

        DataTable dt = fnIU.MemberProfile(obj);
        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0]["ErrorCode"].ToString() == "0")
          {
            TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
            return Redirect("~/Member/Success");
          }
          else
          {
            MemberProfileModel obj2 = new MemberProfileModel();

            obj2.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
            obj2.processname = "view";

            DataTable dt2 = fnIU.MemberProfile(obj);

            ViewData["_Profiledetails"] = dt2;

            DataTable dtCountry = fnIU.GetCountryList();
            ViewData["_country"] = dtCountry;

            ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> OtpAuthentication(int id)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.MemberDetails(obj);

        if (dt.Rows.Count > 0)
        {

          DataTable dtOtp = fnIU.ManageOtp(obj.regno, "generate", "");

          string OTP = string.Empty;
          if (dtOtp.Rows.Count > 0)
          {
            OTP = dtOtp.Rows[0]["OTP"].ToString();
          }

          Dictionary<string, string> data = new Dictionary<string, string>();
          data.Add("Email", dt.Rows[0]["Email"].ToString());
          data.Add("Otp", OTP);
          data.Add("Name", dt.Rows[0]["Fullname"].ToString());
          data.Add("EmailName", "OTP");
          data.Add("Subject", "Baap Network - OTP");
          string jsondata = JsonConvert.SerializeObject(data);
          ApiUtility oApiUtility = new ApiUtility();
          HttpResponseMessage response = oApiUtility.PostApi("account/SendMailBaapNetwork", jsondata);
        }


      }
      catch (Exception exe)
      {

      }

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> OtpAuthentication(int id, IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string OTP = form["otp"];
        int regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dtOtp = fnIU.ManageOtp(regno, "verify", OTP);

        if (dtOtp.Rows.Count > 0)
        {
          if (dtOtp.Rows[0]["ErrorCode"].ToString() == "0")
          {
            if (id == 1)
              return Redirect("~/Member/WalletTransfer");
            else if (id == 2)
              return Redirect("~/Member/WithdrawalRequest");
            else if (id == 3)
              return Redirect("~/Member/Profile");
          }
          else
          {
            ViewData["_ErrorMessage"] = dtOtp.Rows[0]["ErrorMessage"].ToString();
          }
        }


      }
      catch (Exception exe)
      {

      }

      return View();
    }

    public async Task<IActionResult> WithdrawalEligible()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        int regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataSet ds = await fnIU.GetWithdrawalEligibility(regno);

        if (ds.Tables.Count > 0)
        {
          ViewData["_details"] = ds.Tables[2];
          ViewData["_dhanureport"] = ds.Tables[0];
          ViewData["_usdtreport"] = ds.Tables[1];
        }
      }
      catch (Exception exe) { }
      return View();
    }

    public async Task<ActionResult> WithdrawalRequest()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        ViewData["wallettype"] = "1";

        decimal minimumamount = fnIU.GetDhanuMinWithdrawalAmount();
        ViewData["MinimumWithdrawAmount"] = minimumamount.ToString();

        long mregno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtRes1 = fnIU.GetDhanuWithdrawBalance(mregno);

        decimal withdrawalBalance = 0;

        if (dtRes1.Rows.Count > 0)
        {
          withdrawalBalance = Convert.ToDecimal(dtRes1.Rows[0]["_dhanuBalanceCoin"].ToString());
        }

        ViewData["withdrawalBalance"] = withdrawalBalance.ToString();

        ViewData["HandlingFees"] = "0";

        DataTable dtCoin = fnIU.GetLiveCoinRate();

        double _dhanucointrate = Convert.ToDouble(dtCoin.Rows[0]["DhanuLiveRate"].ToString());
        ViewData["_dhanucoinrate"] = _dhanucointrate.ToString();

        double _currencyrate = Convert.ToDouble(dtCoin.Rows[0]["InrExchangeRate"].ToString());
        ViewData["_currencyrate"] = _currencyrate.ToString();

        MemberExchangeAddressRequestParamModel objM = new MemberExchangeAddressRequestParamModel();

        objM.regno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno")); ;
        objM.walletid = 1;
        objM.process_name = "address_list";

        DataTable dt = fnIU.MemberExchangeAddress(objM);

        ViewData["AddressList"] = dt;

      }
      catch (Exception exe)
      {

      }
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> WithdrawalRequest(IFormCollection form)
    {
      try
      {

        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        if (form.Count > 0)
        {
          long regno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno"));
          int walletid = 1;
          //decimal amount = Convert.ToDecimal(form["amount"].ToString());
          int exchangeid = 0;//Convert.ToInt32(form["ddlexchange"].ToString());
          string e_address = "";//form["address"].ToString();
          int EAddressId = 0;//Convert.ToInt32(form["ddlexchangeaddress"].ToString());
          string process_name = "new_request";
          string remarks = form["remark"].ToString();
          decimal coin = Convert.ToDecimal(form["dhanucoin"].ToString());

          MemberWithdrawalRequestModel obj = new MemberWithdrawalRequestModel();

          obj.regno = regno;
          obj.walletid = walletid;
          obj.exchangeid = exchangeid;
          obj.e_address = e_address;
          obj.EAddressId = EAddressId;
          //obj.amount = amount;
          obj.process_name = process_name;
          obj.remarks = remarks;
          obj.coin = coin;

          DataTable dt = await fnIU.MemberWithdrawalAsync(obj);

          if (dt.Rows.Count > 0)
          {
            if (dt.Rows[0]["ErrorCode"].ToString() == "0")
            {
              TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
              return Redirect("~/Member/Success");
            }
            else
            {

              ViewData["wallettype"] = "1";

              decimal minimumamount = fnIU.GetDhanuMinWithdrawalAmount();
              ViewData["MinimumWithdrawAmount"] = minimumamount.ToString();

              long mregno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno"));
              DataTable dtRes1 = fnIU.GetDhanuWithdrawBalance(mregno);

              decimal withdrawalBalance = 0;

              if (dtRes1.Rows.Count > 0)
              {
                withdrawalBalance = Convert.ToDecimal(dtRes1.Rows[0]["_dhanuBalanceCoin"].ToString());
              }

              ViewData["withdrawalBalance"] = withdrawalBalance.ToString();

              ViewData["HandlingFees"] = "5";

              DataTable dtCoin = fnIU.GetLiveCoinRate();

              double _dhanucointrate = Convert.ToDouble(dtCoin.Rows[0]["DhanuLiveRate"].ToString());
              ViewData["_dhanucoinrate"] = _dhanucointrate.ToString();

              double _currencyrate = Convert.ToDouble(dtCoin.Rows[0]["InrExchangeRate"].ToString());
              ViewData["_currencyrate"] = _currencyrate.ToString();

              MemberExchangeAddressRequestParamModel objM = new MemberExchangeAddressRequestParamModel();

              objM.regno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno")); ;
              objM.walletid = 1;
              objM.process_name = "address_list";

              DataTable dt2 = fnIU.MemberExchangeAddress(objM);

              ViewData["AddressList"] = dt2;

              ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
            }
          }
        }
        return View();
      }
      catch (Exception exe)
      {
        return View();
      }

    }

    public async Task<IActionResult> WithdrawalRequestList()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        MemberWithdrawalRequestModel obj = new MemberWithdrawalRequestModel();

        obj.process_name = "member_request_list";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.MemberWithdrawal(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolRequest()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> TradingPoolRequest(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string LoginId = form["investorloginid"];

        RequestParameterModel objC = new RequestParameterModel();
        objC.LoginId = LoginId;

        DataTable dtC = fnIU.MemberDetails(objC);

        int childregno = Convert.ToInt32(dtC.Rows[0]["regno"].ToString());

        TradingPoolModel objM = new TradingPoolModel();

        objM.IntroRegno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno")); ;
        objM.Regno = childregno;
        objM.ProcessName = "add_request";

        DataTable dt2 = fnIU.ManageTradingPoolTree(objM);

        if (dt2.Rows.Count > 0)
        {
          if (dt2.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["_SuccessMessage"] = dt2.Rows[0]["ErrorMessage"].ToString();
          }
          else
          {
            ViewData["_ErrorMessage"] = dt2.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolRegistration()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> TradingPoolRegistration(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string LoginId = form["investorloginid"];

        RequestParameterModel objC = new RequestParameterModel();
        objC.LoginId = LoginId;

        DataTable dtC = fnIU.MemberDetails(objC);

        int childregno = Convert.ToInt32(dtC.Rows[0]["regno"].ToString());

        TradingPoolModel objM = new TradingPoolModel();

        objM.IntroRegno = childregno;
        objM.Regno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno")); 
        objM.ProcessName = "registration";

        DataTable dt2 = fnIU.ManageTradingPoolTree(objM);

        if (dt2.Rows.Count > 0)
        {
          if (dt2.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["_SuccessMessage"] = dt2.Rows[0]["ErrorMessage"].ToString();
          }
          else
          {
            ViewData["_ErrorMessage"] = dt2.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolSentRequestList()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        TradingPoolModel obj = new TradingPoolModel();

        obj.ProcessName = "sent_request_list";
        obj.Regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.ManageTradingPoolTree(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolReceivedRequestList()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        TradingPoolModel obj = new TradingPoolModel();

        obj.ProcessName = "received_request_list";
        obj.Regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.ManageTradingPoolTree(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> ProcessTradingPoolRequest(int rid, int status)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        TradingPoolModel obj = new TradingPoolModel();

        obj.ProcessName = "process_request";
        obj.RequestId = rid;
        obj.Status = status;

        DataTable dt = fnIU.ManageTradingPoolTree(obj);
        if (dt.Rows[0]["ErrorCode"].ToString() == "0")
        {
          TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          return Redirect("~/Member/Success");
        }
      }
      catch (Exception exe)
      {

      }
      return View();
    }

    public async Task<IActionResult> ManageSecurityPin()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        SecurityPinModel obj1 = new SecurityPinModel();
        obj1.Regno= Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj1.ProcessName = "pin_status";

        DataTable dt1 = fnIU.ManageSecurityPin(obj1);

        if (dt1.Rows.Count > 0)
        {
          if (dt1.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["SecurityPinStatus"] = "change";
          }
          else
          {
            ViewData["SecurityPinStatus"] = "generate";
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> ManageSecurityPin(IFormCollection form)
    {
      try
      {
        string submitname = form["submit"];
        string pin = string.Empty;
        string oldpin = string.Empty;
        string process = string.Empty;

        SecurityPinModel obj1 = new SecurityPinModel();

        if(submitname== "change")
        {
          pin = form["newpin"];
          oldpin = form["oldpin"];
          process = "change_pin";
        }
        else if(submitname== "generate")
        {
          pin = form["pin"];
          process = "generate_pin";
        }
        else if (submitname == "forgot")
        {
          process = "forgot_pin";
        }

        obj1.Regno= Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj1.ProcessName = process;
        obj1.SecurityPin = pin;
        obj1.OldSecurityPin = oldpin;

        DataTable dt1 = fnIU.ManageSecurityPin(obj1);

        if (dt1.Rows.Count > 0)
        {
          if (dt1.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["_SuccessMessage"] = dt1.Rows[0]["ErrorMessage"].ToString();

            if (submitname == "forgot")
            {
              string[] arr = dt1.Rows[0]["ErrorMessage"].ToString().Split('|');

              string bodyContent = "Dear " + arr[2].ToString() + ",<br/><br/> Your security pin is " + arr[0].ToString();

              Dictionary<string, string> data = new Dictionary<string, string>();
              data.Add("EmailToId", arr[1].ToString());
              data.Add("EmailToName", arr[2].ToString());
              data.Add("EmailSubject", "Baap Network - Forgot Security Pin");
              data.Add("EmailBody", bodyContent);

              string jsondata = JsonConvert.SerializeObject(data);
              using (HttpClient client = new HttpClient())
              {
                HttpContent inputContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("https://stageapi.baapnetwork.com/api/send-email", inputContent).Result;
              }

              ViewData["_SuccessMessage"] = "Your Security Pin has been sent on your registered email id. Please check.";
            }
          }
          else
          {
            ViewData["_ErrorMessage"] = dt1.Rows[0]["ErrorMessage"].ToString();
          }
        }

        SecurityPinModel obj2 = new SecurityPinModel();
        obj2.Regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj2.ProcessName = "pin_status";

        DataTable dt2 = fnIU.ManageSecurityPin(obj1);

        if (dt2.Rows.Count > 0)
        {
          if (dt2.Rows[0]["ErrorCode"].ToString() == "0")
          {
            ViewData["SecurityPinStatus"] = "change";
          }
          else
          {
            ViewData["SecurityPinStatus"] = "generate";
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> PinAuthentication(int id)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

      }
      catch (Exception exe)
      {

      }

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> PinAuthentication(int id, IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        string OTP = form["otp"];
        int regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        SecurityPinModel obj = new SecurityPinModel();
        obj.Regno = regno;
        obj.SecurityPin = OTP;
        obj.ProcessName = "verify_pin_web";

        DataTable dtOtp = fnIU.ManageSecurityPin(obj);

        if (dtOtp.Rows.Count > 0)
        {
          if (dtOtp.Rows[0]["ErrorCode"].ToString() == "0")
          {
            if (id == 1)
              return Redirect("~/Member/WalletTransfer");
            else if (id == 2)
              return Redirect("~/Member/WithdrawalRequest");
            else if (id == 3)
              return Redirect("~/Member/Profile");
            else if (id == 4)
              return Redirect("~/Member/UsdtTransfer");
          }
          else
          {
            ViewData["_ErrorMessage"] = dtOtp.Rows[0]["ErrorMessage"].ToString();
          }
        }


      }
      catch (Exception exe)
      {

      }

      return View();
    }

    public async Task<IActionResult> GetDhanuCoinReportFromDhanuNetwork()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        long mregno = Convert.ToInt64(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.GetDhanuCoinReportFromDhanuNetwork(mregno);

        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }
    public async Task<IActionResult> SuccessFormPost()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        if (TempData["_SuccessMessage"] != null)
        {
          ViewData["_SuccessMessage"] = TempData["_SuccessMessage"];
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<bool> AuthenticateUserLoginAsync()
    {
      bool response = true;

      if (string.IsNullOrEmpty(HttpContext.Session.GetString("MaxRegno")))
      {
        response = false;
      }

      if (HttpContext.Session.GetString("MaxRegno") == "0")
      {
        response = false;
      }

      RequestParameterModel objU = new RequestParameterModel();
      objU.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

      DataTable dtU = await fnIU.MemberDetailsDashboardHeader(objU);

      if (dtU.Rows.Count > 0)
      {
        HttpContext.Session.SetString("MaxUsername", dtU.Rows[0]["LoginId"].ToString());
        ViewData["Designation"] = dtU.Rows[0]["Designation"].ToString();
        ViewData["Fullname"] = dtU.Rows[0]["Fullname"].ToString();
        ViewData["Email"] = dtU.Rows[0]["Email"].ToString();
        ViewData["_dhanurate"] = dtU.Rows[0]["DhanuRate"].ToString();
        ViewData["_usdtrate"] = dtU.Rows[0]["UsdtRate"].ToString();
        ViewData["_currencyname"] = dtU.Rows[0]["CurrencyName"].ToString();
        ViewData["_currencyicon"] = dtU.Rows[0]["CurrencyIconUrl"].ToString();
        ViewData["_CurrencyDhanuRate"] = dtU.Rows[0]["CurrencyDhanuRate"].ToString();
        ViewData["_CurrencyUsdtRate"] = dtU.Rows[0]["CurrencyUsdtRate"].ToString();
      }

      return response;
    }

    #region Json function
    public JsonResult GetMemberMatrixTree(string regno)
    {
      RequestParameterModel obj = new RequestParameterModel();
      obj.regno = Convert.ToInt32(regno);

      DataTable dt = fnIU.GetMemberMatrixTree(obj);
      string result = "";
      foreach (DataRow item in dt.Rows)
      {
        if (!string.IsNullOrEmpty(result))
        {
          result += "$" + item["regno"].ToString() + "^" + item["userid"].ToString() + "^" + item["fullname"].ToString() + "^" + item["haschild"].ToString();
        }
        else
        {
          result += item["regno"].ToString() + "^" + item["userid"].ToString() + "^" + item["fullname"].ToString() + "^" + item["haschild"].ToString();
        }
      }
      return Json(result);
    }

    public JsonResult SendOtpEmail()
    {
      string result = string.Empty;
      try
      {
        RequestParameterModel obj = new RequestParameterModel();
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.MemberDetails(obj);

        if (dt.Rows.Count > 0)
        {

          DataTable dtOtp = fnIU.ManageOtp(obj.regno, "generate", "");

          string OTP = string.Empty;
          if (dtOtp.Rows.Count > 0)
          {
            OTP = dtOtp.Rows[0]["OTP"].ToString();
          }

          Dictionary<string, string> data = new Dictionary<string, string>();
          data.Add("Email", dt.Rows[0]["Email"].ToString());
          data.Add("Otp", OTP);
          data.Add("Name", dt.Rows[0]["Fullname"].ToString());
          data.Add("EmailName", "OTP");
          data.Add("Subject", "Baap Network - OTP");
          string jsondata = JsonConvert.SerializeObject(data);
          ApiUtility oApiUtility = new ApiUtility();
          HttpResponseMessage response = oApiUtility.PostApi("account/SendMailBaapNetwork", jsondata);
          result = "success";
        }


      }
      catch (Exception exe)
      {
        result = "failed";
      }

      return Json(result);
    }


    public JsonResult VerifyOtpEmail(string otpcode)
    {
      string result = string.Empty;
      try
      {
        string OTP = otpcode;
        int regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dtOtp = fnIU.ManageOtp(regno, "verifypromotion", OTP);

        if (dtOtp.Rows.Count > 0)
        {
          if (dtOtp.Rows[0]["ErrorCode"].ToString() == "0")
          {
            result = "success";
          }
          else
          {
            result = "failed";
          }
        }
        else
        {
          result = "failed";
        }

      }
      catch (Exception exe)
      {
        result = "failed";
      }

      return Json(result);
    }


    public JsonResult SendOtpMobile()
    {
      string result = string.Empty;
      try
      {
        RequestParameterModel obj = new RequestParameterModel();
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = fnIU.MemberDetails(obj);

        if (dt.Rows.Count > 0)
        {

          DataTable dtOtp = fnIU.ManageOtpMobile(obj.regno, "generate", "");

          string OTP = string.Empty;
          if (dtOtp.Rows.Count > 0)
          {
            OTP = dtOtp.Rows[0]["OTP"].ToString();
          }

          result = PushSms(dt.Rows[0]["Mobile"].ToString(), OTP);
        }


      }
      catch (Exception exe)
      {
        result = "failed";
      }

      return Json(result);
    }

    public JsonResult VerifyOtpMobile(string otpcode)
    {
      string result = string.Empty;
      try
      {
        string OTP = otpcode;
        int regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dtOtp = fnIU.ManageOtpMobile(regno, "verifypromotion", OTP);

        if (dtOtp.Rows.Count > 0)
        {
          if (dtOtp.Rows[0]["ErrorCode"].ToString() == "0")
          {
            result = "success";
          }
          else
          {
            result = "failed";
          }
        }
        else
        {
          result = "failed";
        }

      }
      catch (Exception exe)
      {
        result = "failed";
      }

      return Json(result);
    }
    #endregion

    public string PushSms(string mobile, string otp)
    {
      string res = string.Empty;
      string result = "";
      WebRequest request = null;
      HttpWebResponse response = null;
      String userid = "dhanux";
      String password = "ec3eabeb6cXX";
      //String url = "http://dovsms.codetrex.in/submitsms.jsp?user=" + userid + "&key=" + password + "&mobile=+91" + mobile + "&message=[Dhanu] Your verification code for Baap Network: " + otp + ". Please don't share.&senderid=DHANUX&accusage=1";
      String url = "http://dovsms.codetrex.in/submitsms.jsp?user=dhanux&key=ec3eabeb6cXX&mobile=+919871783739&message=%5BDhanu%5D%20Your%20verification%20code%20for%20%7B%23var%23%7D%3A%20%7B%23var%23%7D.%20Please%20don%27t%20share.&senderid=DHANUX&accusage=1";

      request = WebRequest.Create(url);

      response = (HttpWebResponse)request.GetResponse();
      Stream stream = response.GetResponseStream();
      Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
      StreamReader reader = new
      System.IO.StreamReader(stream, ec);
      result = reader.ReadToEnd();
      return res = result.ToString();
    }

    public async Task<IActionResult> TradingPoolDirectReferralReport()
    {

      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;


        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "trading_pool_direct_referral_report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolCommunityReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtRank = fnIU.GetRankList();
        ViewData["_rank"] = dtRank;

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "trading_pool_community_report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }
    }

    public async Task<IActionResult> TradingPoolInvestmentReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "trading_pool_investment_report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolFundWalletRequestReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Fund_Recharge_Request_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolWalletReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Wallet_Transaction_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.WalletId = 3;

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolLevelIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Level_Income_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolRoiIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "ROI_Income_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> TradingPoolRewardIncomeReport()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.Mastername = "Reward_Report";
        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));

        DataTable dt = await fnIU.GetMemberReports(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public async Task<IActionResult> UsdtTransfer()
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        DataTable dtCoin = fnIU.GetLiveCoinRate();

        if (dtCoin.Rows.Count > 0)
        {
          double _usdtcointrate = Convert.ToDouble(dtCoin.Rows[0]["UsdtLiveRate"].ToString());
          ViewData["_usdtcoinrate"] = _usdtcointrate.ToString();

          double _currencyrate = Convert.ToDouble(dtCoin.Rows[0]["InrExchangeRate"].ToString());
          ViewData["_currencyrate"] = _currencyrate.ToString();
        }

        RequestParameterModel obj = new RequestParameterModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        DataTable dtbalance = fnIU.GetWalletBalance(obj);

        //DataTable dtbalanceFund = fnIU.GetWalletBalanceFund(obj);

        decimal _usdtbalance = Convert.ToDecimal(dtbalance.Rows[0]["usdtbalance"].ToString());
        ViewData["_usdtbalance"] = _usdtbalance.ToString();

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    [HttpPost]
    public async Task<IActionResult> UsdtTransfer(IFormCollection form)
    {
      try
      {
        if (!await AuthenticateUserLoginAsync())
        {
          return RedirectToAction("Logout");
        }

        decimal usdtcoin = 0;
        string remark = form["remark"];

        if (!String.IsNullOrEmpty(form["usdtcoin"]))
        {
          usdtcoin = Convert.ToDecimal(form["usdtcoin"]);
        }

        MemberWalletRechargeModel obj = new MemberWalletRechargeModel();

        obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.childregno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
        obj.usdtamount = usdtcoin;
        obj.Remarks = remark;

        DataTable dt = fnIU.MemberUsdtTransfer(obj);

        if (dt.Rows.Count > 0)
        {
          if (dt.Rows[0]["ErrorCode"].ToString() == "0")
          {
            TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
            return Redirect("~/Member/Success");
          }
          else
          {
            ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          }
        }

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }


  }
}
