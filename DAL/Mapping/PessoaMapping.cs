using Entidade;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class PessoaMapping : ClassMap<Pessoa>
    {
        public PessoaMapping()
        {
            Table("Pessoa");
            Id(c => c.Id).Not.Nullable();
            Map(c => c.Name).Not.Nullable().Column("nome");
            Map(c => c.Email).Not.Nullable().Unique();
            Map(c => c.Password).Not.Nullable().Column("senha");
            Map(c => c.BirthDate).Not.Nullable(); //AAAA-MM-DD
        }
    }
}
