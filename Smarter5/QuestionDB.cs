using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarter5
{
    class QuestionDB
    {

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        string strSQL;
        public QuestionDB() { }



        public string grabQ(int grade) {

            string q;
            int gradeLvl = grade;


            
            return q;
        }

    }
}
