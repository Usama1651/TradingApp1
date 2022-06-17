using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Form
{
    public class idGenerator
    {

        public string idf() { 
       // Form1 ff = new Form1();
        
            
        
            string num = "123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getindex;
            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();

                } while (otp.IndexOf(finaldigit) != -1);
                otp = finaldigit;

            }
            return otp;
            //string ab= ff.textBox4.Text = (otp);
            //return ab;
                //string ab= ff.textBox4.Text = (otp);
                //return ab;
            }
        }

    }

