using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMWatson
{
    public class Program
    {
        public static void Main(string[] args)
        {

            WatsonConversationHelper helper = new WatsonConversationHelper("<WorkSpace ID>", "<UserID>", "<Password>");
            var res = helper.GetResponse("hi").GetAwaiter().GetResult();
        }
    }
}
