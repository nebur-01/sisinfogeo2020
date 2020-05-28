using System;
using Newtonsoft.Json;

namespace _38.FacebookAp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //token
            string fbtoken  = "EAACyGR7aItABAGxxKQoQZASqV1NrCrmRbkYh1UsMTcrQqzQdlIZBtAPPMrsfZCxQ3YUwGDyNo08p2H6ZCWJq9CRM7YkF9CSFmaAirmdbpzhbZBp68IPLcUV1Mlvh8aCdMlw6nlcWPTfdjctRbuEStjCG36V4snM8tjcMLIfv3aoFA4cpjni5uc6bQGvF7l2UZD";
            string fbfields = "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb = new FacebookApi(fbtoken);

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(res);
        }
    }
}
