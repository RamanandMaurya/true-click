using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
  public class InsertUpdateModels
  {
  }

  public class UserCredentialsModel
  {
    public int UsertypeId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Authtoken { get; set; }
    public string Otpcode { get; set; }
    public int UserId { get; set; }
    public string IPaddress { get; set; }
  }
  public class MemberRegistrationModel
  {
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Mobileno { get; set; }
    public string Emailaddress { get; set; }
    public int SponsorId { get; set; }
    public string Sponsorcode { get; set; }
    public string Sponsorside { get; set; }
    public int Countryid { get; set; }
  }
  public class RequestParameterModel
  {
    public string LoginId { get; set; }
    public int regno { get; set; }
    public string Mastername { get; set; }
    public int WalletId { get; set; }
    public string dateFrom { get; set; }
    public string dateUpto { get; set; }
    public int LevelId { get; set; }
    public int RankId { get; set; }
  }
  public class MemberActivationModel
  {
    public int regno { get; set; }
    public int childRegno { get; set; }
    public int kitId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMode { get; set; }
    public string BuyingType { get; set; }
    public string Remarks { get; set; }
  }
  public class MemberWalletRechargeModel
  {
    public int regno { get; set; }
    public int childregno { get; set; }
    public int walletId { get; set; }
    public decimal Amount { get; set; }
    public decimal dhanuamount { get; set; }
    public decimal usdtamount { get; set; }
    public decimal tpusdtamount { get; set; }
    public string TransactionType { get; set; }
    public string TransactionName { get; set; }
    public int TransactionStatus { get; set; }
    public string TransactionReference { get; set; }
    public string Remarks { get; set; }
    public string receiptUrlDhanu { get; set; }
    public string receiptUrlUsdt { get; set; }
    public string receiptUrltpUsdt { get; set; }
  }

  public class MemberDetailModel
  {
    public int regno { get; set; }
    public string LoginId { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Fullname { get; set; }
    public string Password { get; set; }
    public string Mobileno { get; set; }
    public string Emailid { get; set; }
  }

  public class MemberProfileModel
  {
    public int regno { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Dateofbirth { get; set; }
    public int Gender { get; set; }
    public string Nomineename { get; set; }
    public string Nomineerelation { get; set; }
    public string Address { get; set; }
    public string Statename { get; set; }
    public string Cityname { get; set; }
    public string Pincode { get; set; }
    public int Countryid { get; set; }
    public string processname { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
  }

  public class MemberExchangeAddressRequestParamModel
  {
    public long regno { get; set; }
    public int walletid { get; set; }
    public int exchangeid { get; set; }
    public string e_address { get; set; }
    public int status { get; set; }
    public int EAddressId { get; set; }
    public string process_name { get; set; }
  }

  public class MemberWithdrawalRequestModel
  {
    public long regno { get; set; }
    public int walletid { get; set; }
    public int exchangeid { get; set; }
    public string e_address { get; set; }
    public int status { get; set; }
    public int EAddressId { get; set; }
    public string process_name { get; set; }
    public decimal amount { get; set; }
    public decimal coin { get; set; }
    public string remarks { get; set; }
    public int RequestId { get; set; }
  }

  public class TradingPoolModel
  {
    public long Regno { get; set; }
    public long IntroRegno { get; set; }
    public string ProcessName { get; set; }
    public int Status { get; set; }
    public string Remark { get; set; }
    public int RequestId { get; set; }
  }

  public class SecurityPinModel
  {
    public string SecurityPin { get; set; }
    public string OldSecurityPin { get; set; }
    public string ProcessName { get; set; }
    public int Regno { get; set; }
  }

  public class LuckyDrawModel
  {
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string LoginId { get; set; }
    public int Regno { get; set; }
    public int Id { get; set; }
    public string Processname { get; set; }
    public int GiftId { get; set; }
  }

  public class CheckUserResponse
  {
    public string message { get; set; }
    public CheckUserResultResponse result { get; set; }
  }
  public class CheckUserResultResponse
  {
    public string uid { get; set; }
    public int level { get; set; }
  }

}
