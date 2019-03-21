using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Pessoa
    {
        #region .: Contructor

        public Pessoa()
        {

        }

        #endregion

        #region .: Atributes



        #endregion

        #region .: Properties

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        //public virtual DateTime BirthDate
        //{
        //    get
        //    {
        //        return BirthDate;
        //    }
        //    set
        //    {
        //        if (value > DateTime.Now)
        //            throw new Exception("date is bigger than now");
        //        else
        //            BirthDate = value;
        //    }
        //}
        public virtual DateTime BirthDate { get; set; }

        #endregion
    }
}
