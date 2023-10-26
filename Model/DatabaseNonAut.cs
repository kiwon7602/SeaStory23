using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaStory.Model
{
    class DatabaseNonAut
    {
        class UserFunction
        {
            private string Id;
            private string PW;

            public int UesrCheck(String Id, String Pw)
            {
                string Query = "SELECT * FROM Member WHERE ID = @ID AND PW = @PW; ";
                `
                return 20231026;

            }

        }
    }
}
