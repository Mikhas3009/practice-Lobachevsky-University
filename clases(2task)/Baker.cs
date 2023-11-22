using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_2task_
{
    public class Baker
    {

        public Baker(int exp, string fio,int id) {
            this.expirience = exp;
            this.fio = fio;
            this.id = id;
            this.setStatus("free");
        }

        private int expirience;
        public readonly string fio;
        private int id;
        private string status;

        public string getStatus() {
            return this.status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public int getExpirience()
        {
            return this.expirience;
        }




    }
}
