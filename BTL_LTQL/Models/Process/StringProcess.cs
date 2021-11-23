using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BTL_LTQL.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string strInput)
        {
            //Khai bao bien
            string strResult = "", numPart, strPart;
            int intPart;
            //strInput = CD1
            //tach phan so
            numPart = Regex.Match(strInput, @"\d+").Value;
            //tach phan chu
            strPart = Regex.Match(strInput, @"\D+").Value;
            //chuyen phan so sang kieu int va tang len 1 don vi
            intPart = Convert.ToInt32(numPart) + 1;
            //bo sung ky tu 0 va phan so cho du chieu dai
            
            //ket hop phan so voi phan chu de tra ve ma tu dong sinh
            strResult = strPart + intPart;
            return strResult;
        }
    }
}