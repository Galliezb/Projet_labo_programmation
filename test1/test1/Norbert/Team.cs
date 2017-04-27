using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
namespace test1.Norbert.forms
{
    public  class Team
    {
        int idTeam_;
        string name_;
        DateTime date_;
            
        
        public Team(int idTeam=-1,string name="....",int day=0,int month=0, int year=0)
        {
            idTeam_ = idTeam;
            date_ = new DateTime(year, month, day);
        }
        
    }
}
