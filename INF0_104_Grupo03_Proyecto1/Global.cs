using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF0_104_Grupo03_Proyecto1
{
    public class Global
    {

        public  static double val1 {  get; set; }
        public static double val2 {  get; set; }
        public static double resultado {  get; set; }
        public static int funcion {  get; set; }
        public static bool control {  get; set; }

        public Global()
        {
            funcion = 0;
            control = false;
        }

    }
}