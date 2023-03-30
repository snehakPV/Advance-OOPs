using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
        /*ShowAccountInfo, Deposit , Withdraw, ShowBalance*/
        public int AccountNumber {get;set;}
        public string BranchName {get;set;}
        public string IFSCCode {get;set;}
        public double Balance {get;set;}
        public AccountInfo(string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int accountNumber,string branchName,string iFSCCode, double balance):base(name,fatherName,phone,mailID,dob,gender)
        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Balance=balance;
        }
        public void ShowAccountInfo()
        {
            System.Console.WriteLine("Account number:"+AccountNumber);
            System.Console.WriteLine("Branch Name:"+BranchName);
            System.Console.WriteLine("IFSC code:"+IFSCCode);
            System.Console.WriteLine("Balance:"+Balance);
        }
    }
}