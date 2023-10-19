using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using webcode.Models;
using webcode.Repository;

namespace webcode.Controllers
{
  public class HomeController : Controller
  {


    InsertUpdateFn fnIU = new InsertUpdateFn();
    private readonly ILogger<HomeController> _logger;
    private IHttpContextAccessor _accessor;
    public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
    {
      _logger = logger;
      _accessor = accessor;
    }

    public IActionResult Index()
    {



      /*
      Dictionary<string, string> data = new Dictionary<string, string>();
      data.Add("Email", "pankaj_aggarwal@qwertycode.in");
      data.Add("Password", "123456");
      data.Add("Name", "Pankaj");
      data.Add("EmailName", "FORGETPASSWORD");
      data.Add("Subject", "Baap Network - Forget Password");
      string jsondata = JsonConvert.SerializeObject(data);
      ApiUtility oApiUtility = new ApiUtility();
      HttpResponseMessage response = oApiUtility.PostApi("account/SendMailBaapNetwork", jsondata);
      */
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    public IActionResult Contact()
    {
      return View();
    }

    public IActionResult Products()
    {
      return View();
    }
        public IActionResult Plan()
        {
            return View();
        }

        public IActionResult Disclaimer()
    {
      return View();
    }

    public IActionResult Terms()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    public IActionResult Registration(string rid)
    {
      
      //Response.Redirect("https://play.google.com/store/apps/details?id=com.mobilebaapnetwork");
      
      ViewData["_referralcode"] = rid;

      //DataTable dtCountry = fnIU.GetCountryList();
      //ViewData["_country"] = dtCountry;

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Registration(IFormCollection form)
    {
      try
      {
        string fname = form["fname"].ToString();
        string lname = form["lname"].ToString();
        string mobile = form["mobile"].ToString();
        string email = form["email"].ToString();
        string referralcode = form["referralcode"].ToString();
        string referralregno = form["referralregno"].ToString();
        //string country = form["country"].ToString();

        MemberRegistrationModel obj = new MemberRegistrationModel();

        obj.Firstname = fname;
        obj.Lastname = lname;
        obj.Mobileno = mobile;
        obj.Emailaddress = email;
        obj.Sponsorcode = referralcode;
        //obj.Countryid = Convert.ToInt32(country);

        //var resV= await fnIU.MemberRegistration(obj);
        int res = await fnIU.MemberRegistration(obj);

        if (res > 0)
        {
          TempData["RegNo"] = res.ToString();
          return RedirectToAction("SuccessRegistration", "Home");
        }
        else if (res == -1)
        {
          ViewData["_ErrorMessage"] = "This email address already registered with us. Please login. !!";
          return View();
        }
        else if (res == -2)
        {
          ViewData["_ErrorMessage"] = "This mobile no already registered with us. Please login. !!";
          return View();
        }
        else
        {
          ViewData["_ErrorMessage"] = "There are some input request error. Please check and try again. !!";
          return View();
        }
      }
      catch (Exception exe)
      {
        return View();
      }

    }

    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(IFormCollection form)
    {
      try
      {
        string username = form["username"];
        string password = form["password"];
        string ipaddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();

        UserCredentialsModel obj = new UserCredentialsModel();
        obj.Username = username;
        obj.Password = password;
        obj.IPaddress = ipaddress;

        var res = await fnIU.UserAuthentication(obj);
        int regno = res;//fnIU.UserAuthentication(obj);

        if (regno > 0)
        {

          try
          {
            RequestParameterModel oRequestParameterModel = new RequestParameterModel();
            oRequestParameterModel.regno = regno;
            DataTable dtInfo = fnIU.MemberDetails(oRequestParameterModel);

            if (dtInfo.Rows.Count > 0)
            {
              Dictionary<string, string> data = new Dictionary<string, string>();
              data.Add("email", dtInfo.Rows[0]["Email"].ToString());

              string jsondata = JsonConvert.SerializeObject(data);

              using (HttpClient client = new HttpClient())
              {
                HttpContent inputContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await Task.Run(() => client.PostAsync("https://www.dhanux.com/api/v2/barong/identity/sessions/m_user", inputContent).Result);
                if (response.StatusCode.ToString() == "Created")
                {
                  CheckUserResponse oResponseModel = JsonConvert.DeserializeObject<CheckUserResponse>(response.Content.ReadAsStringAsync().Result);

                  if (oResponseModel.message == "true")
                  {
                    DataTable dtRes = fnIU.ManageDhanuxDetails(regno, "login", oResponseModel.result.uid, oResponseModel.result.level);                    
                  }
                }

              }
            }
          }
          catch (Exception exe)
          { }

          HttpContext.Session.SetString("MaxRegno", regno.ToString());
          return RedirectToAction("Index", "Member");
        }
        else
        {
          ViewData["_ErrorMessage"] = "Invalid username or password. Please try again. !!";
          return View();
        }
      }
      catch (Exception exe)
      {
        return View();
      }

    }

    public async Task<IActionResult> SuccessRegistration()
    {
      try
      {
        if (TempData["RegNo"] != null)
        {
          RequestParameterModel obj = new RequestParameterModel();
          obj.regno = Convert.ToInt32(TempData["RegNo"]);

          DataTable dt = await fnIU.MemberDetailsAsync(obj);

          MemberDetailModel objres = new MemberDetailModel();

          objres.regno = Convert.ToInt32(dt.Rows[0]["Regno"].ToString());
          objres.LoginId = dt.Rows[0]["LoginId"].ToString();
          objres.Fullname = dt.Rows[0]["Fullname"].ToString();
          objres.Password = dt.Rows[0]["Password"].ToString();
          objres.Mobileno = dt.Rows[0]["Mobileno"].ToString();
          objres.Emailid = dt.Rows[0]["Email"].ToString();

          ViewData["_memberdetails"] = objres;

          string verificationlink = "http://baapnetwork.com/email-verification/" + dt.Rows[0]["Regno"].ToString() + "/" + dt.Rows[0]["Memcode"].ToString();

          try
          {
            /*
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Email", objres.Emailid);
            data.Add("Password", objres.Password);
            data.Add("Name", objres.Fullname);
            data.Add("LoginId", objres.LoginId);
            data.Add("EmailName", "REGISTRATION");
            data.Add("Subject", "Baap Network - Registration");
            string jsondata = JsonConvert.SerializeObject(data);
            ApiUtility oApiUtility = new ApiUtility();
            HttpResponseMessage response = await oApiUtility.PostApiAsync("account/SendMailBaapNetwork", jsondata);
            */

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("senderEmail", objres.Emailid);
            data.Add("password", objres.Password);
            data.Add("userName", objres.Fullname);
            data.Add("loginID", objres.LoginId);
            //data.Add("EmailName", "REGISTRATION");
            data.Add("subject", "BAAP - Registration");
            data.Add("link", verificationlink);

            string jsondata = JsonConvert.SerializeObject(data);
            ApiUtility oApiUtility = new ApiUtility();
            HttpResponseMessage response = await oApiUtility.PostApiAsync("http://mailapi.baapnetwork.com/sendemail", jsondata);
          }
          catch { }

        }
        else
        {
          return RedirectToAction("Registration", "Home");
        }
      }
      catch (Exception exe)
      {

      }

      return View();
    }

    public IActionResult EmailVerification(string regno, string otpcode)
    {
      try
      {
        string OTP = otpcode;
        int lngregno = Convert.ToInt32(regno);

        DataTable dtOtp = fnIU.ManageOtp(lngregno, "verifyemail", OTP);

        if (dtOtp.Rows.Count > 0)
        {
          if (dtOtp.Rows[0]["ErrorCode"].ToString() == "0")
          {
            //result = "success";
          }
          else
          {
            //result = "failed";
          }
        }
        else
        {
          //result = "failed";
        }

      }
      catch (Exception exe)
      {
        //result = "failed";
      }

      return View();
    }

    public IActionResult ForgetPassword()
    {
      return View();
    }

    [HttpPost]
    public IActionResult ForgetPassword(IFormCollection form)
    {
      try
      {
        string LoginId = form["LoginId"];

        RequestParameterModel obj = new RequestParameterModel();
        obj.LoginId = LoginId;

        DataTable dt = fnIU.MemberDetails(obj);
        if (dt.Rows.Count > 0)
        {
          MemberDetailModel objres = new MemberDetailModel();

          objres.regno = Convert.ToInt32(dt.Rows[0]["Regno"].ToString());
          objres.LoginId = dt.Rows[0]["LoginId"].ToString();
          objres.Fullname = dt.Rows[0]["Fullname"].ToString();
          objres.Password = dt.Rows[0]["Password"].ToString();
          objres.Mobileno = dt.Rows[0]["Mobileno"].ToString();
          objres.Emailid = dt.Rows[0]["Email"].ToString();

          string bodyContent = "Dear " + objres.Fullname + ",<br/><br/> Your login password is " + objres.Password + ".<br/><br/><br/><br/><br/>Team <br/>BAAP NEWORK";

          Dictionary<string, string> data = new Dictionary<string, string>();
          data.Add("EmailToId", objres.Emailid);
          data.Add("EmailToName", objres.Fullname);
          data.Add("EmailSubject", "Baap Network - Forget Password");
          data.Add("EmailBody", bodyContent);

          string jsondata = JsonConvert.SerializeObject(data);
          using (HttpClient client = new HttpClient())
          {
            HttpContent inputContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("https://stageapi.baapnetwork.com/api/send-email", inputContent).Result;
          }

          ViewData["_SuccessMessage"] = "Password sent on your registered e-mail address. Please check.!!";
        }
        else
        {
          ViewData["_ErrorMessage"] = "Invalid user name. Please check and try again.!!";
        }
      }
      catch
      {
        ViewData["_ErrorMessage"] = "Some system error. Please check and try again.!!";
      }

      return View();
    }

    public IActionResult LuckyDrawRegistration()
    {
      return View();
    }

    [HttpPost]
    public IActionResult LuckyDrawRegistration(IFormCollection form)
    {
      string Fullname = form["fullname"];
      string Mobile = form["mobile"];
      string Email = form["email"];
      string Loginid = form["Loginid"];
      string Regno = form["regno"];
      if (string.IsNullOrEmpty(Regno))
      {
        Regno = "0";
      }

      LuckyDrawModel obj = new LuckyDrawModel();
      obj.Fullname = Fullname;
      obj.Mobile = Mobile;
      obj.Email = Email;
      obj.LoginId = Loginid;
      obj.Regno = Convert.ToInt32(Regno);

      DataTable dt = fnIU.LuckyDrawRegistration(obj);
      if (dt.Rows.Count > 0)
      {
        if(dt.Rows[0]["ErrorCode"].ToString() != "0")
        {
          ViewData["_ErrorMessage"] = dt.Rows[0]["ErrorMessage"].ToString();
        }
        else
        {
          try
          {
            string EmailBodyContent = @"<!DOCTYPE html>
<html lang='en'>
  <head>
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <title>Welcome to Baap Network</title>
  </head>
  <body style='width:600px;margin:0 auto;font-family:Arial, sans-serif;box-sizing:border-box;'>
    <table cellpadding='0' cellspacing='0' border='0' width='100%' style='margin:0 auto;text-align:center;background:black;max-width:600px;border-radius:2px;position:relative;'>
      <tr style='width:100%;border:none;'>
        <td>
          <table cellpadding='0' cellspacing='0' border='0' style='width:100%;text-align:center;background:black;border-radius:2px;position:relative;'>
            <tr style='width:100%;border:none;'>
              <td>
                <table border='0' cellspacing='0' cellpadding='0' style='text-align:center;background:black;width:100%;border-radius:2px;position:relative;'>
                  <tr style='width:100%;border:none;background:#161617 !important;'>
                    <td style='width: 70px;'>
                      <p style='margin:0;text-align:center;'>
                        <a href='https://baapnetwork.com/'><img src='https://baapnetwork.com/assets/images/logo.png' alt='Side_logo' style='width:50px;margin-top:5px;'></a>
                      </p>
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
            <tr style='width:100%;border:none;'>
                <td>
                  <p style='color: #e7dede;font-weight: 500;text-align: center;font-size: 24px;'><span style='color: #FCC539'>BAAP Network </span>Lucky Draw</p>
                </td>
              </tr>
            <tr style='width:100%;border:none;'>
                <td>
                  <p style='color: #00A478;font-weight: 500;text-align: center;font-size: 24px;'>Registered Successfully</p>
                </td>
              </tr>
            <tr style='width:100%;border:none;'>
                <td>
                    <div style='padding: 10px;box-sizing: border-box;background-color: #FCC539;max-width: 300px;margin: 20px auto;height: 300px;border-radius: 12.5px;box-shadow: 0px 6.30769px 6.30769px rgba(0, 0, 0, 0.02);;'>
                    <div style='border:2px dashed #38383A;border-radius: 12.5px;height: 99%;'>
                        <div style='height: calc(257px - 90px)'>
                           <div>
                            <img src='https://baapnetwork.com/assets/images/logo.png' style='margin: auto;display: block;width:68px;margin-top: 18px;' alt='logo'/>
                            <p style='font-size:17px;font-weight: 600;color: #000000;margin-top: 45px;'>Your Unique Code</p>
                           </div>
                        </div>
                        <div style='border-top: 2px dashed #38383A;height: 90px;text-align: center;'><h3 style='font-size: 40px;margin: 0;line-height: 90px;'>" + dt.Rows[0]["UniqueCode"].ToString() + @"</h3></div>
                    </div>
                    </div>
                </td>
              </tr>
            <tr style='width:100%;border:none;background:#161617 !important;'>
              <td>
                <p style='display:inline-block;margin-bottom:8px;'>
                  <strong style='color:#fff;margin-right:10px;line-height:33px;float:left;'>Follow us : </strong>
                  <a href='https://www.facebook.com/baapnetwork' target='_blank' style='color:#eac00f;font-size:17px;border:1px solid #eac00f;border-radius:50%;margin-left:3px;line-height:33px;position:relative;width:30px;display:inline-block;height:30px;'><img src='https://baapnetwork.com/emailtemplate/fb.png'></a>
                  <a href='https://twitter.com/baapnetwork' target='_blank' style='color:#eac00f;font-size:17px;border:1px solid #eac00f;border-radius:50%;margin-left:3px;line-height:33px;position:relative;width:30px;display:inline-block;height:30px;'><img src='https://baapnetwork.com/emailtemplate/twitter.png'></a>
                  <a href='https://www.instagram.com/baapnetwork/' target='_blank' style='color:#eac00f;font-size:17px;border:1px solid #eac00f;border-radius:50%;margin-left:3px;line-height:33px;position:relative;width:30px;display:inline-block;height:30px;'><img src='https://baapnetwork.com/emailtemplate/instagram.png'></a>
                  <a href='https://www.linkedin.com/company/baapnetwork' target='_blank' style='color:#eac00f;font-size:17px;border:1px solid #eac00f;border-radius:50%;margin-left:3px;line-height:33px;position:relative;width:30px;display:inline-block;height:30px;'><img src='https://baapnetwork.com/emailtemplate/linkedin.png'/></a>
                </p>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
  </body>
</html>";
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("EmailToId", Email);
            data.Add("EmailToName", Fullname);
            data.Add("EmailSubject", "BAAP NETWORK - Lucky Draw Registration");
            data.Add("EmailBody", EmailBodyContent);

            string jsondata = JsonConvert.SerializeObject(data);
            using (HttpClient client = new HttpClient())
            {
              HttpContent inputContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
              HttpResponseMessage response = client.PostAsync("https://stageapi.baapnetwork.com/api/send-email", inputContent).Result;
            }
          }
          catch(Exception ex)
          {

          }
          

          string UniqueCode = dt.Rows[0]["UniqueCode"].ToString();
          TempData["UniqueCode"] = UniqueCode;
          return RedirectToAction("LuckyDrawSuccessfully", "Home");
        }
      }
      return View();
    }

    public IActionResult Blog()
    {
      return View();
    }

    public IActionResult BlogContent1()
    {
      return View();
    }

    public IActionResult BlogContent2()
    {
      return View();
    }

    #region Json function
    public JsonResult GetMemberDetails(string LoginId)
    {
      RequestParameterModel obj = new RequestParameterModel();
      obj.LoginId = LoginId;

      DataTable dt = fnIU.MemberDetails(obj);
      string result = dt.Rows[0]["regno"].ToString() + "$" + dt.Rows[0]["Fullname"].ToString() + "$" + dt.Rows[0]["Email"].ToString() + "$" + dt.Rows[0]["Mobile"].ToString();
      return Json(result);
    }

    public JsonResult SendOtpEmail(string email, string name)
    {
      string result = string.Empty;
      try
      {
        string OTP = string.Empty;
        Random generator = new Random();
        String r = generator.Next(0, 1000000).ToString("D6");
        OTP = r;
        ViewData["OtpCode"] = OTP;

        Dictionary<string, string> data = new Dictionary<string, string>();
        data.Add("Email", email);
        data.Add("Otp", OTP);
        data.Add("Name", name);
        data.Add("EmailName", "OTP");
        data.Add("Subject", "Baap Network - OTP");
        string jsondata = JsonConvert.SerializeObject(data);
        ApiUtility oApiUtility = new ApiUtility();
        HttpResponseMessage response = oApiUtility.PostApi("account/SendMailBaapNetwork", jsondata);
        result = OTP;


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
    #endregion
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult LuckyDrawSuccessfully()
    {
      if (TempData["UniqueCode"] != null)
      {
        ViewData["UniqueCode"] = TempData["UniqueCode"].ToString();
      }
      else
      {
        ViewData["UniqueCode"] = "000000";
      }
      return View();
    }

    public IActionResult OpenLuckyDraw()
    {
      LuckyDrawModel obj = new LuckyDrawModel();
      obj.Processname = "registration_list_lucky_draw";

      DataTable dt = fnIU.ManageLuckyDraw(obj);
      ViewData["_report"] = dt;
      return View();
    }

    public IActionResult PlayLuckydraw()
    {
      PlayLuckyDrawDetails();
      ViewData["GiftId"] = 0;
      return View();
    }
    [HttpPost]
    public IActionResult PlayLuckydraw(IFormCollection form)
    {
      string btnSubmit = form["start"];
      int GiftId = 0;
      if (btnSubmit == "car")
      {
        GiftId = 1;
      }
      else if (btnSubmit == "bike")
      {
        GiftId = 2;
      }
      else if (btnSubmit == "mobile")
      {
        GiftId = 3;
      }
      else if (btnSubmit == "coin")
      {
        GiftId = 4;
      }
      else if (btnSubmit == "microwave")
      {
        GiftId = 5;
      }
      else if (btnSubmit == "induction")
      {
        GiftId = 6;
      }
      else if (btnSubmit == "bag")
      {
        GiftId = 7;
      }

      ViewData["GiftId"] = GiftId;

      LuckyDrawModel obj = new LuckyDrawModel();
      obj.Processname = "start_lucky_draw";
      obj.GiftId = GiftId;
      DataTable dt = fnIU.ManageLuckyDraw(obj);

      PlayLuckyDrawDetails();
      return View();
    }

    public async Task<IActionResult> SendBulkEmail()
    {
      DataTable dtEmail = await fnIU.BulkEmail("GET_EMAIL", 0, 0);
      if (dtEmail.Rows.Count > 0)
      {
        for (int i = 0; i < dtEmail.Rows.Count; i++)
        {
          try
          {
            string bodyContent = @"Hey " + dtEmail.Rows[i]["Name"].ToString().ToUpper() + ",<br/><br/> It's been a long time since we interacted, " +
            "but just wanted to drop you a line and thank you for always having faith in BAAP network. You know how much BAAP Network means to us " +
            "and rest assured, our team will always make sure it's the best for all of us.<br/><br/>Now the time has come for Dhanu to go to his next " +
            "stage in the world of crypto, don't forget that our platform is now on blockchain technology with jumbo chain! And we're continuously " +
            "integrating more features across all channels.<br/><br/>There is some important information which is being delivered to you through this " +
            "email.<br/><br/>1.	To invest on BAAP network from 1st January 2023, 75% Dhanu and 25% USDT will or 100% USDT have to be given." +
            "<br/>2.	The sale of Dhanu is available through BAAP Network only till 31st March 2023, after that Dhanu will be buy and sell through exchanges" +
            " only.<br/>3.	By March 31, it will be mandatory for everyone to enter their blockchain address on their Baap Network ID, otherwise the coins " +
            "will not be able to be transferred your exchange address. After this, no address will be taken off-line. Only one address will be updated on " +
            "one email.<br/>4.	Baap Network will not be responsible for any loss of Dhanu token due to wrong blockchain address, fake or wrong email." +
            "<br/>5.	All your Dhanu Tokens will be swapped to native coin of jumbo chain when the blockchain arrives. Details will be sent to you by mail." +
            "<br/><br/>Let's meet up soon!<br/><br/><br/><br/>Thanks<br/>BAAP Management";

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("EmailToId", dtEmail.Rows[i]["Email"].ToString());
            data.Add("EmailToName", dtEmail.Rows[i]["Name"].ToString().ToUpper());
            data.Add("EmailSubject", "BAAP Network-Important information");
            data.Add("EmailBody", bodyContent);

            string jsondata = JsonConvert.SerializeObject(data);
            using (HttpClient client = new HttpClient())
            {
              HttpContent inputContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
              HttpResponseMessage response = client.PostAsync("https://stageapi.baapnetwork.com/api/send-email", inputContent).Result;
              DataTable res = await fnIU.BulkEmail("UPDATE_STATUS", Convert.ToInt32(dtEmail.Rows[i]["Id"].ToString()), 1);
            }
          }
          catch (Exception exe)
          {
            DataTable res = await fnIU.BulkEmail("UPDATE_STATUS", Convert.ToInt32(dtEmail.Rows[i]["Id"].ToString()), 2);
          }
        }
      }
      return View();
    }
    protected void PlayLuckyDrawDetails()
    {
      LuckyDrawModel obj = new LuckyDrawModel();
      obj.Processname = "lucky_draw_reward_list";

      DataTable dt = fnIU.ManageLuckyDraw(obj);
      if (dt.Rows.Count > 0)
      {
        if (dt.Rows[0]["GiftId"].ToString() == "1")
        {
          ViewData["AltoCarStatus"] = dt.Rows[0]["Status"].ToString();
          if (dt.Rows[0]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj1 = new LuckyDrawModel();
            obj1.Processname = "winner_list_lucky_draw";
            obj1.GiftId = 1;

            DataTable dt1 = fnIU.ManageLuckyDraw(obj1);
            if (dt1.Rows.Count > 0)
            {
              ViewData["_report_altocar"] = dt1;
            }
          }
        }

        if (dt.Rows[1]["GiftId"].ToString() == "2")
        {
          ViewData["ActiveBikeStatus"] = dt.Rows[1]["Status"].ToString();
          if (dt.Rows[1]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj2 = new LuckyDrawModel();
            obj2.Processname = "winner_list_lucky_draw";
            obj2.GiftId = 2;

            DataTable dt2 = fnIU.ManageLuckyDraw(obj2);
            if (dt2.Rows.Count > 0)
            {
              ViewData["_report_activabike"] = dt2;
            }
          }
        }

        if (dt.Rows[2]["GiftId"].ToString() == "3")
        {
          ViewData["MobileStatus"] = dt.Rows[2]["Status"].ToString();
          if (dt.Rows[2]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj3 = new LuckyDrawModel();
            obj3.Processname = "winner_list_lucky_draw";
            obj3.GiftId = 3;

            DataTable dt3 = fnIU.ManageLuckyDraw(obj3);
            if (dt3.Rows.Count > 0)
            {
              ViewData["_report_mobile"] = dt3;
            }
          }
        }

        if (dt.Rows[3]["GiftId"].ToString() == "4")
        {
          ViewData["GoldCoinStatus"] = dt.Rows[3]["Status"].ToString();
          if (dt.Rows[3]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj4 = new LuckyDrawModel();
            obj4.Processname = "winner_list_lucky_draw";
            obj4.GiftId = 4;

            DataTable dt4 = fnIU.ManageLuckyDraw(obj4);
            if (dt4.Rows.Count > 0)
            {
              ViewData["_report_goldcoin"] = dt4;
            }
          }
        }

        if (dt.Rows[4]["GiftId"].ToString() == "5")
        {
          ViewData["MicrowaveStatus"] = dt.Rows[4]["Status"].ToString();
          if (dt.Rows[4]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj5 = new LuckyDrawModel();
            obj5.Processname = "winner_list_lucky_draw";
            obj5.GiftId = 5;

            DataTable dt5 = fnIU.ManageLuckyDraw(obj5);
            if (dt5.Rows.Count > 0)
            {
              ViewData["_report_microwave"] = dt5;
            }
          }
        }

        if (dt.Rows[5]["GiftId"].ToString() == "6")
        {
          ViewData["InductionStatus"] = dt.Rows[5]["Status"].ToString();
          if (dt.Rows[5]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj6 = new LuckyDrawModel();
            obj6.Processname = "winner_list_lucky_draw";
            obj6.GiftId = 6;

            DataTable dt6 = fnIU.ManageLuckyDraw(obj6);
            if (dt6.Rows.Count > 0)
            {
              ViewData["_report_induction"] = dt6;
            }
          }
        }

        if (dt.Rows[6]["GiftId"].ToString() == "7")
        {
          ViewData["BagStatus"] = dt.Rows[6]["Status"].ToString();
          if (dt.Rows[6]["Status"].ToString() == "1")
          {
            LuckyDrawModel obj7 = new LuckyDrawModel();
            obj7.Processname = "winner_list_lucky_draw";
            obj7.GiftId = 7;

            DataTable dt7 = fnIU.ManageLuckyDraw(obj7);
            if (dt7.Rows.Count > 0)
            {
              ViewData["_report_bag"] = dt7;
            }
          }
        }
      }
    }
  }
}
