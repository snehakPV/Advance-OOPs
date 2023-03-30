using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    public class FileHandling
    {
        public void Create()
        {
            if(!Directory.Exists("OnlineDTHRechargeDS"))
            {
                System.Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("OnlineDTHRechargeDS");
            }
            if(!File.Exists("OnlineDTHRechargeDS/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File UserDetails");
                File.Create("OnlineDTHRechargeDS/UserDetails.csv").Close();
            }
            if(!File.Exists("OnlineDTHRechargeDS/PackDetails.csv"))
            {
                System.Console.WriteLine("Creating File PackDetails");
                File.Create("OnlineDTHRechargeDS/PackDetails.csv").Close();
            }
            if(!File.Exists("OnlineDTHRechargeDS/RechargeDetails.csv"))
            {
                System.Console.WriteLine("Creating File RechargeDetails");
                File.Create("OnlineDTHRechargeDS/RechargeDetails.csv").Close();
            }
        }
        public void WriteToCSV()
        {
            string [] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                var user=Operations.userList[i];
                users[i]=user.UserID+","+user.UserName+","+user.MobileNumber+","+user.EmailID+","+user.WalletBalance;
            }
            File.WriteAllLines("OnlineDTHRechargeDS/UserDetails.csv",users);

            string [] packs=new string[Operations.packList.Count];
            for(int i=0;i<Operations.packList.Count;i++)
            {
                var pack=Operations.packList[i];
                packs[i]=pack.PackID+","+pack.PackName+","+pack.Price+","+pack.Validity+","+pack.NumOfChannels;
            }
            File.WriteAllLines("OnlineDTHRechargeDS/PackDetails.csv",packs);

            string [] recharge=new string[Operations.rechargeList.Count];
            for(int i=0;i<Operations.rechargeList.Count;i++)
            {
                var charge=Operations.rechargeList[i];
                recharge[i]=charge.RechargeID+","+charge.UserID+","+charge.PackID+","+charge.RechargeDate+","+charge.RechargeAmount+","+charge.ValidTill+","+charge.NumberOfChannels;
            }
            File.WriteAllLines("OnlineDTHRechargeDS/RechargeDetails.csv",recharge);
        }
        public void ReadFromCSV()
        {
            string [] users=File.ReadAllLines("OnlineDTHRechargeDS/UserDetails.csv");
            for(int i=0;i<users.Length;i++)
            {
                Operations.userList.Add(new UserDetails(users[i]));
            }

            string [] packs=File.ReadAllLines("OnlineDTHRechargeDS/PackDetails.csv");
                for(int i=0;i<packs.Length;i++)
                {
                    Operations.packList.Add(new PackDetails(packs[i]));
                }
            
            string [] recharge=File.ReadAllLines("OnlineDTHRechargeDS/RechargeDetails.csv");
            for(int i=0;i<recharge.Length;i++)
            {
                Operations.rechargeList.Add(new RechargeDetails(recharge[i]));
            }
        }
    }
}