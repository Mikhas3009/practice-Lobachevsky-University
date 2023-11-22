using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_2task_
{
    public class Courier
    {
        public Courier(int exp, string fio, int id)
        {
            this.expirience = exp;
            this.fio = fio;
            this.id = id;
            this.setStatus("free");
        }

        private string status;
        private int expirience;
        public string fio;
        private int id;

        public string getStatus()
        {
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
