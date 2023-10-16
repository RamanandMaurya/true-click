using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using webcode.Models;

namespace webcode.Controllers
{
  public class HOController : Controller
  {
    InsertUpdateFn fnIU = new InsertUpdateFn();
    public IActionResult Index()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      return View();
    }

    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(IFormCollection form)
    {
      string username = form["username"];
      string password = form["password"];
      //string ipaddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();

      UserCredentialsModel obj = new UserCredentialsModel();
      obj.Username = username;
      obj.Password = password;

      int regno = fnIU.UserAuthenticationAdmin(obj);

      if (regno > 0)
      {
        HttpContext.Session.SetString("UserId", regno.ToString());
        return RedirectToAction("Index", "HO");
      }
      else
      {
        ViewData["_ErrorMessage"] = "Invalid username or password. Please try again. !!";
        return View();
      }
    }

    public IActionResult FundRechargeRequestReport()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "Fund_Recharge_Request_Report";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult WalletRecharge(int Id)
    {
      if (!AuthenticateUserLogin())
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
      /*
      double _dhanucointrate = 0.17500000;//fnIU.GetCoinRate(1);
      ViewData["_dhanucoinrate"] = _dhanucointrate.ToString();

      double _usdtcointrate = fnIU.GetCoinRate(2);
      ViewData["_usdtcoinrate"] = _usdtcointrate.ToString();
      */
      RequestParameterModel obj = new RequestParameterModel();
      obj.Mastername = "fund_recharge_request_detail";
      obj.regno = Id;

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_details"] = dt;

      return View();
    }

    [HttpPost]
    public IActionResult WalletRecharge(IFormCollection form)
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      string referenceno = form["referenceno"];
      decimal dhanuamount = Convert.ToDecimal(form["dhanuamount"]);
      decimal usdtamount = Convert.ToDecimal(form["usdtamount"]);
      decimal tpusdtamount = Convert.ToDecimal(form["tpusdtamount"]);
      string remark = form["remark"];
      int status = Convert.ToInt32(form["status"]);
      int regno = Convert.ToInt32(form["HFregno"]);

      MemberWalletRechargeModel obj = new MemberWalletRechargeModel();

      obj.regno = regno;
      obj.dhanuamount = dhanuamount;
      obj.usdtamount = usdtamount;
      obj.tpusdtamount = tpusdtamount;
      obj.Remarks = remark;
      obj.TransactionReference = referenceno;
      obj.TransactionType = "C";
      obj.TransactionName = "walletrecharge";
      obj.TransactionStatus = status;//--For Testing keep value 1 otherwise it will be 0

      DataTable dt = fnIU.MemberWalletRecharge(obj);

      if (dt.Rows.Count > 0)
      {
        if (dt.Rows[0]["ErrorCode"].ToString() == "0")
        {
          TempData["_SuccessMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
          return Redirect("~/Ho/Success");
        }
        else
        {
          ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
        }
      }

      return View();
    }

    public IActionResult RewardReport()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "reward_report";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult FundApprovalReport()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "Fund_Approval_Report";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult BaapNetworkDhanuReport()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "dhanucoin_baapnetwork";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult DhanuNetworkDhanuReport()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "dhanucoin_dhanunetwork";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult FasttrackSilverCoinAcheiver()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "fasttrack_reward_silvercoin";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult FasttrackGoldCoinAcheiver()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      RequestParameterModel obj = new RequestParameterModel();

      obj.Mastername = "fasttrack_reward_goldcoin";

      DataTable dt = fnIU.GetAdminReports(obj);
      ViewData["_report"] = dt;

      return View();
    }

    public IActionResult WithdrawalRequestList(int status)
    {
      try
      {
        if (!AuthenticateUserLogin())
        {
          return RedirectToAction("Logout");
        }

        MemberWithdrawalRequestModel obj = new MemberWithdrawalRequestModel();

        obj.process_name = "admin_request_list";
        obj.status = status;

        DataTable dt = fnIU.MemberWithdrawal(obj);
        ViewData["_report"] = dt;

        return View();
      }
      catch (Exception ex)
      {
        return View();
      }

    }

    public IActionResult WithdrawalRequestProcess(int rid)
    {
      try
      {
        if (!AuthenticateUserLogin())
        {
          return RedirectToAction("Logout");
        }

        MemberWithdrawalRequestModel obj = new MemberWithdrawalRequestModel();

        obj.process_name = "admin_request_detail";
        obj.RequestId = rid;

        DataTable dt = fnIU.MemberWithdrawal(obj);
        ViewData["_report"] = dt;
      }
      catch (Exception exe)
      {

      }
      return View();
    }

    [HttpPost]
    public IActionResult WithdrawalRequestProcess(int rid, IFormCollection Iform)
    {
      try
      {
        int RequestId = 0;
        int Status = 0;

        if (Iform.Count > 0)
        {
          RequestId = Convert.ToInt32(Iform["RequestId"].ToString());
          Status = Convert.ToInt32(Iform["ddlstatus"].ToString());

          MemberWithdrawalRequestModel obj = new MemberWithdrawalRequestModel();

          obj.process_name = "admin_process_request";
          obj.RequestId = RequestId;
          obj.status = Status;

          DataTable dt = fnIU.MemberWithdrawal(obj);
        }
      }
      catch (Exception exe)
      {

      }
      return View();
    }

    public ActionResult UpdateCoinRate()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      return View();
    }

    [HttpPost]
    public IActionResult UpdateCoinRate(IFormCollection form)
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      decimal amount = Convert.ToDecimal(form["amount"]);
      int coin = Convert.ToInt32(form["coin"]);

      DataTable dt = fnIU.UpdateCoinRate(coin, amount);

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

    public IActionResult Invester()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Invester(IFormCollection form)
    {
      string LoginId = form["InvesterID"];
      RequestParameterModel obj = new RequestParameterModel();
      obj.LoginId = LoginId;

      DataTable dt = fnIU.MemberDetails(obj);
      if (dt.Rows.Count > 0)
      {
        TempData["MaxRegNo"] = dt.Rows[0]["regno"].ToString();
        return RedirectToAction("Profile", "HO");
      }
      else
      {
        ViewData["_ErrorMessage"] = "Invester ID is not valid !!";
      }

      return View();
    }

    public IActionResult Profile()
    {
      long regno = Convert.ToInt64(TempData["MaxRegNo"].ToString());
      HttpContext.Session.SetString("MaxRegno", regno.ToString());
      MemberProfileModel obj = new MemberProfileModel();

      obj.regno = Convert.ToInt32(regno);
      //obj.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
      obj.processname = "view";

      DataTable dt = fnIU.MemberProfile(obj);

      ViewData["_Profiledetails"] = dt;
      return View();

    }

    [HttpPost]
    public IActionResult Profile(IFormCollection form)
    {
      try
      {
        if (!AuthenticateUserLogin())
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

        obj.processname = "admin_edit";
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
            return Redirect("~/HO/Success");
          }
          else
          {
            MemberProfileModel obj2 = new MemberProfileModel();

            obj2.regno = Convert.ToInt32(HttpContext.Session.GetString("MaxRegno"));
            obj2.processname = "view";

            DataTable dt2 = fnIU.MemberProfile(obj2);

            ViewData["_Profiledetails"] = dt2;

            //DataTable dtCountry = fnIU.GetCountryList();
            //ViewData["_country"] = dtCountry;

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

    public IActionResult Logout()
    {
      HttpContext.Session.Remove("UserId");
      HttpContext.Session.Clear();
      return Redirect("~/HO/login");
    }

    public IActionResult SuccessFormPost()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      if (TempData["_SuccessMessage"] != null)
      {
        ViewData["_SuccessMessage"] = TempData["_SuccessMessage"];
      }

      return View();
    }

    public bool AuthenticateUserLogin()
    {
      bool response = true;

      if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
      {
        response = false;
      }

      if (HttpContext.Session.GetString("UserId") == "0")
      {
        response = false;
      }
      return response;
    }

    [HttpPost]
    public ActionResult AddFundInWallet(IFormCollection form)
    {
      try
      {
        if (!AuthenticateUserLogin())
        {
          return RedirectToAction("Logout");
        }

        string loginid = form["InvesterID"];
        decimal amount = Convert.ToDecimal(form["AmmountTransfer"]);
        int walletid = Convert.ToInt32(form["WalletType"]);
        string Remark = form["Remark"];

        DataTable dt = fnIU.AddFundInWallet(loginid, amount, walletid, Remark);
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
      }
      catch (Exception exe)
      {

      }

      return View();
    }

    public IActionResult AddFundInWallet()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      return View();
    }

    [HttpPost]
    public IActionResult DeductFundFromWallet(IFormCollection form)
    {
      try
      {
        if (!AuthenticateUserLogin())
        {
          return RedirectToAction("Logout");
        }
        string loginid = form["InvesterID"];
        decimal amount = Convert.ToDecimal(form["AmmountTransfer"]);
        int walletid = Convert.ToInt32(form["WalletType"]);
        string Remark = form["Remark"];

        DataTable dt = fnIU.DeductFundFromWallet(loginid, amount, walletid, Remark);
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
      }
      catch (Exception exe)
      {

      }
      return View();
    }

    public IActionResult DeductFundFromWallet()
    {
      if (!AuthenticateUserLogin())
      {
        return RedirectToAction("Logout");
      }

      return View();
    }
  }
}
