using Microsoft.AspNetCore.Mvc;
using My.Models;

namespace My.Controllers
{
    
    public class calcController : Controller
    {
        public string text1;
        public string text2;
        public string text3;
        public string text4;
        public string text5="0";
        public string cl;

        public IActionResult Index()
        {
            
            
            return View(new calm());
        }
        [HttpPost]
        public IActionResult Index(calm c,string tb2,string cal, string tb1)
        {
             double num1;
             double num2;


            if (HttpContext.Session.GetString("temp2") == null) {

                cl = cal;
            }
            else {

               
                if (cal == "+" || cal == "-" || cal == "/" || cal == "*" )
                {
                   
                    cl = HttpContext.Session.GetString("temp2") +"";
                }
                else {

                    cl = cal;

                }
            }







            

            

            if (cl == "+")
            {


                text2 = HttpContext.Session.GetString("temp1") +"";
                if (text2 == null) {
                    a();
                }
                else {
                    b();

                    text3 = (num1 + num2).ToString();


                    cc();
                }

            }
            else if (cl =="-") {
                text2 = HttpContext.Session.GetString("temp1") +"";
                if (text2 == null)
                {
                    a();
                }
                else
                {
                    b();

                    text3 = (num1 - num2).ToString();


                    cc();
                }

            }
            else if (cl == "*") {
                text2 = HttpContext.Session.GetString("temp1") +"";
                if (text2 == null)
                {
                    a();
                }
                else
                {
                    b();

                    text3 = (num1 * num2).ToString();


                    cc();
                }

            }
            else if (cl == "/") {
                text2 = HttpContext.Session.GetString("temp1") +"";
                if (text2 == null)
                {
                    a();
                }
                else
                {
                    b();

                    text3 = (num1 / num2).ToString();


                    cc();
                }

            }
            else if ( cal == "=" ) {


              

                if(HttpContext.Session.GetString("temp2") =="+"){

                    b();

                    text3 = (num1 + num2).ToString();


                    cc();
                    c.tbm2="Thank you !";
                }
                else if(HttpContext.Session.GetString("temp2") == "-") {
                    b();

                    text3 = (num1 - num2).ToString();


                    cc();
                    c.tbm2 = "Thank you !";
                }
                else if(HttpContext.Session.GetString("temp2") == "*") {
                    b();

                    text3 = (num1 * num2).ToString();


                    cc();
                    c.tbm2 = "Thank you !";
                }
                else if(HttpContext.Session.GetString("temp2") == "/") {
                    b();

                    text3 = (num1 / num2).ToString();


                    cc();
                    c.tbm2 = "Thank you !";
                }
                
                
            }
            else if (cal == "c") {
                c.tbm1 = "";
                c.tbm2 = "";
                HttpContext.Session.Remove("temp");
                HttpContext.Session.Remove("temp1");
                HttpContext.Session.Remove("temp2");
            }
            else {

                if (HttpContext.Session.GetString("temp1")==null) {
                    HttpContext.Session.SetString("temp1","0");
                }
                
                    c.tbm1 = HttpContext.Session.GetString("temp1");
                

               c.tbm1= HttpContext.Session.GetString("temp1");
               


                if (HttpContext.Session.GetString("temp3") ==".") {

                    if (cal == ".")
                    {

                        c.tbm2 = tb2;
                    }
                    else {

                        c.tbm2 = tb2 + cal;


                        text4 = HttpContext.Session.GetString("temp");
                        text4 = text4 + cal;
                        HttpContext.Session.SetString("temp", text4);

                        HttpContext.Session.SetString("temp3", cal);
                    }
                }
                else {

                    c.tbm2 = tb2 + cal;


                    text4 = HttpContext.Session.GetString("temp");
                    text4 = text4 + cal;
                    HttpContext.Session.SetString("temp", text4);

                    HttpContext.Session.SetString("temp3", cal);


                }





            }




            void a() {

                text1 = HttpContext.Session.GetString("temp");
                HttpContext.Session.SetString("temp1", text1);

                c.tbm1 = HttpContext.Session.GetString("temp1");
                c.tbm2 = tb2 + cal;
                HttpContext.Session.Remove("temp");
                HttpContext.Session.SetString("temp2", cal);
            }
            void b() {

                text1 = HttpContext.Session.GetString("temp");
                text2 = HttpContext.Session.GetString("temp1");

                num2 = Convert.ToDouble(text1);
                num1 = Convert.ToDouble(text2);
            }

            void cc() {

                HttpContext.Session.SetString("temp1", text3);

                c.tbm1 = HttpContext.Session.GetString("temp1");
                c.tbm2 = tb2 + cal;
                HttpContext.Session.Remove("temp");
                HttpContext.Session.SetString("temp2", cal);
            }
            
            
            return View(c);
        }
           
       
    }
}
